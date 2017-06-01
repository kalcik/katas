using System;
using System.Collections.Generic;
using System.Linq;
using CarRental.Models;
using CarRental.Repositories;

namespace CarRental.Services
{
    public class ReservationService
    {

        public IEnumerable<CarModel> FindAvailableCars(DateTime requestedReservationStartDateTime, DateTime requestedReservationEndDateTime, string cityForRequestedReservation)
        {
            using (var carRentalDbContext = new CarRentalDbContext())
            {
                var idsOfCarsNotAvailableNow =
                    carRentalDbContext.Reservations
                                      .Where(placedReservation => placedReservation.ReservationStart <= requestedReservationEndDateTime && placedReservation.ReservationEnd >= requestedReservationStartDateTime)
                                      .Select(placedReservation => placedReservation.CarId);

                var availableCars = carRentalDbContext.Cars.Where(car =>
                                                                          !idsOfCarsNotAvailableNow.Contains(car.CarId) && car.Office.City == cityForRequestedReservation);

                var resultAvailableCars = availableCars.Select(availableCar => new CarModel
                                                                               {
                                                                                   CarId = availableCar.CarId,
                                                                                   Category = availableCar.Category,
                                                                                   CarBrand = availableCar.CarBrand,
                                                                                   KilometerReading = availableCar.KilometerReading,
                                                                                   LicenceNumber = availableCar.LicenceNumber,
                                                                                   OfficeId = availableCar.OfficeId,
                                                                                   Office = new OfficeModel
                                                                                            {
                                                                                                City = availableCar.Office.City,
                                                                                                Country = availableCar.Office.Country,
                                                                                                OfficeId = availableCar.Office.OfficeId,
                                                                                                Postcode = availableCar.Office.Postcode,
                                                                                                Street = availableCar.Office.Street
                                                                                            }
                                                                               }).ToList();

                return resultAvailableCars;
            }
        }

        public void TakeCarReservervation(CustomerModel customer, DateTime requestedReservationStartDateTime, DateTime requestedReservationEndDateTime, string city)
        {
            throw new NotImplementedException();
        }
    }
}