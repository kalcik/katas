using System;
using System.Collections.Generic;
using CarRental.Models;
using CarRental.Services;

namespace CarRental.BusinessLayer
{
    public class CarRentalBusinessLayer
    {
        public void CreateNewCustomer(string firstName, string lastName, DateTime dateOfBirth, string street, string city, string postcode, int customerType)
        {
            var newCustomer = new CustomerModel
                              {
                                  CustomerNumber = Guid.NewGuid().ToString(),
                                  FirstName = firstName,
                                  LastName = lastName,
                                  DateOfBirth = dateOfBirth,
                                  City = city,
                                  CustomerType = customerType,
                                  Street = street,
                                  Postcode = postcode
                              };
            var r = new CustomerService();
            r.AddCustomer(newCustomer);
        }

        public Dictionary<CarModel, decimal> FindAvailableCarsForRental(CustomerModel customer, DateTime requestedReservationStartDateTime, DateTime requestedReservationEndDateTime, string city)
        {

            var r = new ReservationService();
            var availableCars = r.FindAvailableCars(requestedReservationStartDateTime, requestedReservationEndDateTime, city);
            decimal cp = 0;
            var result = new Dictionary<CarModel, decimal>();

            #region Calculate price

            foreach (var availableCar in availableCars)
            {
                switch (availableCar.Category)
                {
                    case "A":
                        {
                            cp = 50 * (requestedReservationEndDateTime - requestedReservationStartDateTime).Days;

                            switch (customer.CustomerType)
                            {
                                case CustomerModel.ConsumerPremium:
                                    {
                                        cp = cp - (cp * 0.02m);
                                        break;
                                    }
                            }

                            break;
                        }

                    case "B":
                        {
                            cp = 65 * (requestedReservationEndDateTime - requestedReservationStartDateTime).Days;

                            switch (customer.CustomerType)
                            {
                                case CustomerModel.ConsumerPremium:
                                    {
                                        cp = cp - (cp * 0.03m);
                                        break;
                                    }

                                case CustomerModel.BusinessPremium:
                                    {
                                        cp = cp - (cp * 0.04m);
                                        break;
                                    }
                            }

                            break;
                        }

                    case "C":
                        {
                            cp = 90 * (requestedReservationEndDateTime - requestedReservationStartDateTime).Days;

                            switch (customer.CustomerType)
                            {
                                case CustomerModel.ConsumerPremium:
                                    {
                                        cp = cp - (cp * 0.05m);
                                        break;
                                    }

                                case CustomerModel.Business:
                                    {
                                        cp = cp - (cp * 0.06m);
                                        break;
                                    }

                                case CustomerModel.BusinessPremium:
                                    {
                                        cp = cp - (cp * 0.08m);
                                        break;
                                    }
                            }

                            break;
                        }

                    case "D":
                        {
                            cp = 120 * (requestedReservationEndDateTime - requestedReservationStartDateTime).Days;

                            switch (customer.CustomerType)
                            {
                                case CustomerModel.ConsumerPremium:
                                    {
                                        cp = cp - (cp * 0.06m);
                                        break;
                                    }

                                case CustomerModel.Business:
                                    {
                                        cp = cp - (cp * 0.08m);
                                        break;
                                    }

                                case CustomerModel.BusinessPremium:
                                    {
                                        cp = cp - (cp * 0.12m);
                                        break;
                                    }
                            }

                            break;
                        }

                    default:
                        {
                            cp = 0;
                            break;
                        }
                }

                result.Add(availableCar, cp);
            } 
            #endregion

            return result.Count > 0  ? result : null;
        }

        public void CreateCarReservation(CustomerModel customer, DateTime requestedReservationStartDateTime, DateTime requestedReservationEndDateTime, string city)
        {
            try
            {
                var r = new ReservationService();
                r.TakeCarReservervation(customer, requestedReservationStartDateTime, requestedReservationEndDateTime, city);
            }
            catch
            {
                
            }
        }
    }
}