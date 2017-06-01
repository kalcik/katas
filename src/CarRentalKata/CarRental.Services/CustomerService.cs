using System.Linq;
using CarRental.Entities;
using CarRental.Models;
using CarRental.Repositories;

namespace CarRental.Services
{
    public class CustomerService
    {

        public void AddCustomer(CustomerModel customerModel)
        {
            var customerEntity = new Customer
                                 {
                                     City = customerModel.City,
                                     CustomerType = customerModel.CustomerType,
                                     Street = customerModel.Street,
                                     Postcode = customerModel.Postcode,
                                     CustomerId = customerModel.CustomerId,
                                     CustomerNumber = customerModel.CustomerNumber,
                                     DateOfBirth = customerModel.DateOfBirth,
                                     FirstName = customerModel.FirstName,
                                     LastName = customerModel.LastName
                                 };


            using (var carRentalDbContext = new CarRentalDbContext())
            {
                carRentalDbContext.Customers.Add(customerEntity);
                carRentalDbContext.SaveChanges();
            }
        }

        public CustomerModel GetCustomerByCustomerNumber(string customerNumber)
        {
            CustomerModel customerModel = null;
            Customer foundCustomer;

            using (var carRentalDbContext = new CarRentalDbContext())
            {
                foundCustomer = carRentalDbContext.Customers.SingleOrDefault(customer => customer.CustomerNumber == customerNumber);
            }

            if (foundCustomer != null)
            {
                customerModel = new CustomerModel
                                {
                                    CustomerType = foundCustomer.CustomerType,
                                    City = foundCustomer.City,
                                    CustomerId = foundCustomer.CustomerId,
                                    CustomerNumber = foundCustomer.CustomerNumber,
                                    DateOfBirth = foundCustomer.DateOfBirth,
                                    Street = foundCustomer.Street,
                                    Postcode = foundCustomer.Postcode,
                                    LastName = foundCustomer.LastName,
                                    FirstName = foundCustomer.FirstName
                                };
            }

            return customerModel;
        }
    }
}