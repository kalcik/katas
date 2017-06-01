namespace CarRental.BusinessLayer.IntegrationTests
{
    using System;
    using System.Linq;
    using Entities;
    using Models;
    using Ploeh.AutoFixture;
    using Repositories;
    using Xunit;

    public class CarRentalBusinessLayerTests : IDisposable
    {
        public void Dispose()
        {
            TestCleanup();
        }

        private const string CustomersLastNameToBeDeleted = "FC5EC369-1CDB-4A6E-B0D0-9D3E89ADFE6C";
        private readonly Fixture _autoFixture = new Fixture();

        public void TestCleanup()
        {
            using (var carRentalDbContext = new CarRentalDbContext())
            {
                var customerToBeDeleted = carRentalDbContext.Customers.SingleOrDefault(c => c.LastName == CustomersLastNameToBeDeleted);
                if (customerToBeDeleted != null)
                {
                    carRentalDbContext.Customers.Remove(customerToBeDeleted);
                    carRentalDbContext.SaveChanges();
                }
            }
        }

        [Fact]
        public void SearchInViennaReturns2Cars()
        {
            //Arrange
            var systemUnderTest = new CarRentalBusinessLayer();
            var requestedReservationStart = new DateTime(2014, 09, 22, 8, 0, 0);
            var requestedReservationEnd = new DateTime(2014, 09, 25, 8, 0, 0);
            var anonymousCustomerDoSearch = _autoFixture.Create<CustomerModel>();
            const string cityToSearchFor = "Wien";

            //Act
            var actualResult = systemUnderTest.FindAvailableCarsForRental(anonymousCustomerDoSearch, requestedReservationStart, requestedReservationEnd, cityToSearchFor);

            //Assert
            var expectedResult = 2;
            Assert.True(actualResult.Count == expectedResult);
        }

        [Fact]
        public void SearchResultRetunsCarsWithViennaOffice()
        {
            //Arrange
            var systemUnderTest = new CarRentalBusinessLayer();
            var requestedReservationStart = new DateTime(2014, 09, 22, 8, 0, 0);
            var requestedReservationEnd = new DateTime(2014, 09, 25, 8, 0, 0);
            var anonymousCustomerDoSearch = _autoFixture.Create<CustomerModel>();
            const string cityToSearchFor = "Wien";

            //Act
            var actualResult = systemUnderTest.FindAvailableCarsForRental(anonymousCustomerDoSearch, requestedReservationStart, requestedReservationEnd, cityToSearchFor);

            //Assert
            Func<CarModel, bool> expectedResult = (car => car.Office.City != cityToSearchFor);
            Assert.False(actualResult.Keys.Any(expectedResult));
        }

        [Fact]
        public void CarPriceOfCarTypeBIsCorrectCalculatedForCustomerOfTypeConsumer()
        {
            //Arrange
            var systemUnderTest = new CarRentalBusinessLayer();
            var requestedReservationStart = new DateTime(2014, 09, 22, 8, 0, 0);
            var requestedReservationEnd = new DateTime(2014, 09, 25, 8, 0, 0);
            var customerOfTypeConsumerDoSearch = _autoFixture.Build<CustomerModel>().With(property => property.CustomerType, CustomerModel.Consumer).Create();
            const string cityToSearchFor = "Wien";

            //Act
            var actualResult = systemUnderTest.FindAvailableCarsForRental(customerOfTypeConsumerDoSearch, requestedReservationStart, requestedReservationEnd, cityToSearchFor)
                                              .Where(availableCar => availableCar.Key.Category == CarModel.Medium).Select(result => result.Value);

            //Assert
            var expectedResult = 195.0m;
            foreach (var price in actualResult) { Assert.True(price == expectedResult); }
        }

        [Fact]
        public void NewCustomerIsCreated()
        {
            const string customerLastName = CustomersLastNameToBeDeleted;

            //Arrange
            var systemUnderTest = new CarRentalBusinessLayer();
            var customerToBeCreated = _autoFixture.Build<CustomerModel>().Without(property => property.CustomerId).With(property => property.CustomerType, CustomerModel.Consumer).With(property => property.LastName, customerLastName)
                                                  .Create();
            var expectedResult = customerToBeCreated;

            //Act
            systemUnderTest.CreateNewCustomer(
                customerToBeCreated.FirstName,
                customerToBeCreated.LastName,
                customerToBeCreated.DateOfBirth,
                customerToBeCreated.Street,
                customerToBeCreated.City,
                customerToBeCreated.Postcode,
                customerToBeCreated.CustomerType);

            //Assert
            Customer actualResult;
            using (var carRentalDbContext = new CarRentalDbContext()) { actualResult = carRentalDbContext.Customers.SingleOrDefault(c => c.LastName == customerLastName); }
            Assert.True(actualResult != null && expectedResult.LastName == actualResult.LastName);
        }
    }
}