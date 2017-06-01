using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using CarRental.Entities;

namespace CarRental.Repositories
{
    internal sealed class CarRentalDbInitializer : CreateDatabaseIfNotExists<CarRentalDbContext>
    {
        protected override void Seed(CarRentalDbContext context)
        {
            #region Cars

            var carVWUp_1 = new Car
                            {
                                CarBrand = "VW Up!",
                                LicenceNumber = "LicenceNumberb2efb16b-3e67-4913-b60c-e47f566cb8fd",
                                KilometerReading = 213,
                                Category = "A"
                            };
            var carVWUp_2 = new Car
                            {
                                CarBrand = "VW Up!",
                                LicenceNumber = "LicenceNumber1f683d72-1fdb-4e2b-afa0-a4d97541e1a2",
                                KilometerReading = 117,
                                Category = "A"
                            };

            var carVWUp_3 = new Car
                            {
                                CarBrand = "VW Up!",
                                LicenceNumber = "LicenceNumber825366cc-f15c-4b0d-aac2-e3d99d6c9102",
                                KilometerReading = 146,
                                Category = "A"
                            };
            var carVWUp_4 = new Car
                            {
                                CarBrand = "VW Up!",
                                LicenceNumber = "LicenceNumber0ebe4849-907c-41c3-8b62-fd256b596d2e",
                                KilometerReading = 180,
                                Category = "A"
                            };


            var carMercedesC_1 = new Car
                                 {
                                     CarBrand = "Mercedes C",
                                     LicenceNumber = "LicenceNumber4e4942e3-fdab-4e0a-b909-b5965c6107c5",
                                     KilometerReading = 198,
                                     Category = "D"
                                 };

            var carMercedesC_2 = new Car
                                 {
                                     CarBrand = "Mercedes C",
                                     LicenceNumber = "LicenceNumber4c574dc8-be20-45b7-933b-924a16de4ff7",
                                     KilometerReading = 149,
                                     Category = "D"
                                 };

            var carMercedesC_3 = new Car
                                 {
                                     CarBrand = "Mercedes C",
                                     LicenceNumber = "LicenceNumberb8d21cd5-cd8d-4325-ab81-e6ed32e5248e",
                                     KilometerReading = 1,
                                     Category = "D"
                                 };

            var carMercedesC_4 = new Car
                                 {
                                     CarBrand = "Mercedes C",
                                     LicenceNumber = "LicenceNumber637c5ac3-b4ea-4e6c-afef-feac5f7cdb49",
                                     KilometerReading = 23,
                                     Category = "D"
                                 };

            var carMercedesC_5 = new Car
                                 {
                                     CarBrand = "Mercedes C",
                                     LicenceNumber = "LicenceNumber20dbf74b-c789-4fad-aaf7-7c0602ea3088",
                                     KilometerReading = 99,
                                     Category = "D"
                                 };

            var carSkodaRapid_1 = new Car
                                  {
                                      CarBrand = "Skoda Rapid",
                                      LicenceNumber = "LicenceNumber147fd1d4-5951-49e5-aa11-0f6bb03fcd67",
                                      KilometerReading = 112,
                                      Category = "B"
                                  };

            var carSkodaRapid_2 = new Car
                                  {
                                      CarBrand = "Skoda Rapid",
                                      LicenceNumber = "LicenceNumber097d720b-48fc-4aa2-8689-bff64061294d",
                                      KilometerReading = 88,
                                      Category = "B"
                                  };

            var carBMW7_1 = new Car
                            {
                                CarBrand = "BMW 7",
                                LicenceNumber = "LicenceNumberc4dc4724-8a52-4267-a471-8f52d6becf22",
                                KilometerReading = 37,
                                Category = "D"
                            };
            var carBMW7_2 = new Car
                            {
                                CarBrand = "BMW 7",
                                LicenceNumber = "LicenceNumber1c1b8167-ab05-4de7-921f-a4d88cb0b596",
                                KilometerReading = 52,
                                Category = "D"
                            };


            var carVWGolf_1 = new Car
                              {
                                  CarBrand = "VW Golf",
                                  LicenceNumber = "LicenceNumber5bf4d32c-6303-4637-8a67-b534c96eb1af",
                                  KilometerReading = 236,
                                  Category = "B"
                              };

            var carVWGolf_2 = new Car
                              {
                                  CarBrand = "VW Golf",
                                  LicenceNumber = "LicenceNumberccf13664-fee6-417e-b444-de33d472c874",
                                  KilometerReading = 110,
                                  Category = "B"
                              };
            var carVWGolf_3 = new Car
                              {
                                  CarBrand = "VW Golf",
                                  LicenceNumber = "LicenceNumber7ea168b0-7bb5-4e68-8442-7b02d7d46a90",
                                  KilometerReading = 224,
                                  Category = "B"
                              };

            var carSkodaSuperB_1 = new Car
                                   {
                                       CarBrand = "Skoda SuperB",
                                       LicenceNumber = "LicenceNumberccfa0a7b-a8a8-4ceb-b6b2-4bc6526a7844",
                                       KilometerReading = 166,
                                       Category = "C"
                                   };

            var carPeugeot107_1 = new Car
                                  {
                                      CarBrand = "Peugeout 107",
                                      LicenceNumber = "LicenceNumber2e940a9a-8a7f-4897-938c-466abb8f6cae",
                                      KilometerReading = 92,
                                      Category = "A"
                                  };

            var carKiaRio_1 = new Car
                              {
                                  CarBrand = "Kia Rio",
                                  LicenceNumber = "LicenceNumberef36b3f0-ca81-46bc-a327-b848ad9b98c5",
                                  KilometerReading = 30,
                                  Category = "A"
                              };

            var carFiat500_1 = new Car
                               {
                                   CarBrand = "Fiat 500",
                                   LicenceNumber = "LicenceNumberc9a3d4c8-2de9-4208-9b17-ca40a858779b",
                                   KilometerReading = 219,
                                   Category = "A"
                               };

            #endregion

            #region Customers

            var customer1 = new Customer
                            {
                                CustomerNumber = "CustomerNumberf7cc1e29-18b5-4d86-9d28-aa8e7625d57b",
                                FirstName = "FirstNamec57b643a-1ec0-4e2b-8ba5-320703167ed4",
                                LastName = "LastNameab18fc10-9e57-4737-93ba-6cc36b31fa59",
                                DateOfBirth = new DateTime(1964, 12, 12),
                                CustomerType = 4
                            };
            var customer2 = new Customer
                            {
                                CustomerNumber = "CustomerNumber125fa9a0-a87a-4234-8f6b-f6614541c3c1",
                                FirstName = "FirstName277c3bce-24be-473d-a4b0-032500ffe661",
                                LastName = "LastName8165d4d2-9bfc-4bcf-916a-3764ff995d6c",
                                DateOfBirth = new DateTime(1978, 09, 25),
                                CustomerType = 2
                            };
            var customer3 = new Customer
                            {
                                CustomerNumber = "CustomerNumber545e2341-e660-4fdd-a91f-4e1dfe47f900",
                                FirstName = "FirstNamea1e7edab-9901-4d6d-8440-8fffd674dd4c",
                                LastName = "LastName528bd4ef-2dd1-476a-9ffd-8d63278e3ef2",
                                DateOfBirth = new DateTime(1990, 06, 05),
                                CustomerType = 3
                            };
            var customer4 = new Customer
                            {
                                CustomerNumber = "CustomerNumber13a4ce5f-cd86-4a8e-926b-73f0d6ab9535",
                                FirstName = "FirstName247d1074-b539-42e6-a49a-7f5bc59fb98c",
                                LastName = "LastName4aae48f7-5554-4297-a9bf-ef7455323ee7",
                                DateOfBirth = new DateTime(1985, 07, 02),
                                CustomerType = 2
                            };
            var customer5 = new Customer
                            {
                                CustomerNumber = "CustomerNumber6c649a16-4f56-43fa-8230-4cd55082c455",
                                FirstName = "FirstName67c39b04-e322-4b01-8a0a-cc66fa14156b",
                                LastName = "LastName80fcb0e5-042e-43c6-99b0-7d0ea412d85c",
                                DateOfBirth = new DateTime(1930, 03, 03),
                                CustomerType = 2
                            };
            var customer6 = new Customer
                            {
                                CustomerNumber = "CustomerNumber133418f0-fd29-44ea-a86d-9f74942e4a83",
                                FirstName = "FirstName6d01f71f-f883-4c99-b8d6-a507bf10806c",
                                LastName = "LastNamec4e10d54-7871-47bf-82c3-ca5f3ae78c75",
                                DateOfBirth = new DateTime(1945, 06, 03),
                                CustomerType = 3
                            };
            var customer7 = new Customer
                            {
                                CustomerNumber = "CustomerNumber89e6e2e8-b8d1-49d6-a1ff-183af8078935",
                                FirstName = "FirstNameaa934db4-83a7-44d9-bdd9-29bdfdb5450c",
                                LastName = "LastName86abfd86-950b-4e82-a726-5d1fd5b50c0c",
                                DateOfBirth = new DateTime(1995, 10, 04),
                                CustomerType = 4
                            };
            var customer8 = new Customer
                            {
                                CustomerNumber = "CustomerNumber5a4c26bb-8821-4b1e-a4de-8fb1206d3b14",
                                FirstName = "FirstNamee855016d-7a4a-438b-8578-22627b995e48",
                                LastName = "LastNameb1844e9e-2d75-4c07-be3a-412ba604d795",
                                DateOfBirth = new DateTime(1954, 09, 24),
                                CustomerType = 3
                            };
            var customer9 = new Customer
                            {
                                CustomerNumber = "CustomerNumber9cb1f5e9-25f4-424b-8247-318955907048",
                                FirstName = "FirstNameed0518f6-fdc8-4daa-8219-09fd192ab9e0",
                                LastName = "LastName71f9ab65-6e1a-4d0f-92c7-1f9f11c244be",
                                DateOfBirth = new DateTime(1943, 12, 12),
                                CustomerType = 1
                            };
            var customer10 = new Customer
                             {
                                 CustomerNumber = "CustomerNumberef071835-d02c-4534-aa3d-2db17e9962b2",
                                 FirstName = "FirstNamef11cbc5a-fa06-49df-b1a1-0edfbfabbf28",
                                 LastName = "LastName73c456f9-4cdd-4885-b743-1ab3de1166f0",
                                 DateOfBirth = new DateTime(1968, 1, 1),
                                 CustomerType = 3
                             };

            #endregion

            #region Offices

            var officeWien = new Office
                             {
                                 City = "Wien",
                                 Country = "Austria",
                                 Postcode = "1100",
                                 Street = "Am Hauptbahnhof 1"
                             };

            var officeSalzburg = new Office
                                 {
                                     City = "Salzburg",
                                     Country = "Austria",
                                     Postcode = "5020",
                                     Street = "Gniglerstrasse 12"
                                 };


            var officeBerlin = new Office
                               {
                                   City = "Berlin",
                                   Country = "Germany",
                                   Postcode = "10243",
                                   Street = "Strasse der pariser kommune 5"
                               };

            var officeMuenchen = new Office
                                 {
                                     City = "München",
                                     Country = "Germany",
                                     Postcode = "80335",
                                     Street = "Bahnhofpl. 2"
                                 };

            var officeBratislava = new Office
                                   {
                                       City = "Bratislava",
                                       Country = "Slovakia",
                                       Postcode = "83104",
                                       Street = "Vajnorská 160"
                                   };

            var officePrag = new Office
                             {
                                 City = "Prag",
                                 Country = "Czech Republic",
                                 Postcode = "11015",
                                 Street = "Elišky Krásnohorské 9"
                             };

            #endregion

            #region Assign Cars to Offices

            carSkodaRapid_1.Office = officeWien;
            carBMW7_1.Office = officeWien;

            carMercedesC_1.Office = officeSalzburg;
            carMercedesC_2.Office = officeSalzburg;

            carVWUp_1.Office = officeBerlin;
            carVWUp_2.Office = officeBerlin;
            carPeugeot107_1.Office = officeBerlin;
            carKiaRio_1.Office = officeBerlin;
            carVWGolf_1.Office = officeBerlin;
            carSkodaRapid_2.Office = officeBerlin;

            carSkodaSuperB_1.Office = officeMuenchen;
            carBMW7_2.Office = officeMuenchen;
            carVWUp_3.Office = officeMuenchen;

            carVWGolf_2.Office = officeBratislava;
            carVWUp_4.Office = officeBratislava;
            carMercedesC_3.Office = officeBratislava;

            carMercedesC_4.Office = officePrag;
            carMercedesC_5.Office = officePrag;
            carFiat500_1.Office = officePrag;
            carVWGolf_3.Office = officePrag;

            #endregion

            #region Invoices

            var invoice1 = new Invoice
                           {
                               Price = 312.0m
                           };

            var invoice2 = new Invoice
                           {
                               Price = 50.0m
                           };

            var invoice3 = new Invoice
                           {
                               Price = 147.0m
                           };

            var invoice4 = new Invoice
                           {
                               Price = 883.20m
                           };

            var invoice5 = new Invoice
                           {
                               Price = 350.00m
                           };

            var invoice6 = new Invoice
                           {
                               Price = 120.0m
                           };

            var invoice7 = new Invoice
                           {
                               Price = 65.0m
                           };

            var invoice8 = new Invoice
                           {
                               Price = 720.0m
                           };

            #endregion

            #region Reservations

            var reservation1 = new Reservation
                               {
                                   Car = carVWUp_1,
                                   Customer = customer3,
                                   Invoice = invoice2,
                                   ReservationStart = new DateTime(2014, 09, 23),
                                   ReservationEnd = new DateTime(2014, 09, 24)
                               };

            var reservation2 = new Reservation
                               {
                                   Car = carBMW7_2,
                                   Customer = customer9,
                                   Invoice = invoice6,
                                   ReservationStart = new DateTime(2015, 03, 31),
                                   ReservationEnd = new DateTime(2015, 04, 01)
                               };

            var reservation3 = new Reservation
                               {
                                   Car = carVWUp_3,
                                   Customer = customer10,
                                   ReservationStart = new DateTime(2017, 10, 17),
                                   ReservationEnd = new DateTime(2017, 10, 19)
                               };

            var reservation4 = new Reservation
                               {
                                   Car = carPeugeot107_1,
                                   Customer = customer10,
                                   Invoice = invoice3,
                                   ReservationStart = new DateTime(2013, 12, 29),
                                   ReservationEnd = new DateTime(2014, 01, 01)
                               };

            var reservation5 = new Reservation
                               {
                                   Car = carMercedesC_1,
                                   Customer = customer6,
                                   Invoice = invoice4,
                                   ReservationStart = new DateTime(2014, 05, 24),
                                   ReservationEnd = new DateTime(2014, 06, 01)
                               };

            var reservation6 = new Reservation
                               {
                                   Car = carMercedesC_4,
                                   Customer = customer6,
                                   Invoice = invoice8,
                                   ReservationStart = new DateTime(2014, 03, 27),
                                   ReservationEnd = new DateTime(2014, 04, 02)
                               };

            var reservation7 = new Reservation
                               {
                                   Car = carSkodaSuperB_1,
                                   Customer = customer8,
                                   ReservationStart = new DateTime(2017, 11, 18),
                                   ReservationEnd = new DateTime(2014, 11, 23)
                               };

            var reservation8 = new Reservation
                               {
                                   Car = carPeugeot107_1,
                                   Customer = customer8,
                                   Invoice = invoice5,
                                   ReservationStart = new DateTime(2014, 06, 28),
                                   ReservationEnd = new DateTime(2014, 07, 05)
                               };

            var reservation9 = new Reservation
                               {
                                   Car = carVWGolf_3,
                                   Customer = customer3,
                                   Invoice = invoice7,
                                   ReservationStart = new DateTime(2014, 01, 29),
                                   ReservationEnd = new DateTime(2014, 01, 30)
                               };

            var reservation10 = new Reservation
                                {
                                    Car = carSkodaRapid_2,
                                    Customer = customer7,
                                    Invoice = invoice1,
                                    ReservationStart = new DateTime(2014, 09, 23),
                                    ReservationEnd = new DateTime(2014, 09, 28)
                                };

            #endregion

            #region Add reservation to context

            context.Reservations.Add(reservation1);
            context.Reservations.Add(reservation2);
            context.Reservations.Add(reservation3);
            context.Reservations.Add(reservation4);
            context.Reservations.Add(reservation5);
            context.Reservations.Add(reservation6);
            context.Reservations.Add(reservation7);
            context.Reservations.Add(reservation8);
            context.Reservations.Add(reservation9);
            context.Reservations.Add(reservation10);

            #endregion

            #region Add cars to context

            context.Cars.AddOrUpdate(c => c.LicenceNumber, carVWUp_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carVWUp_2);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carVWUp_3);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carVWUp_4);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carMercedesC_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carMercedesC_2);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carMercedesC_3);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carMercedesC_4);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carMercedesC_5);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carSkodaRapid_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carSkodaRapid_2);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carBMW7_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carBMW7_2);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carVWGolf_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carVWGolf_2);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carVWGolf_3);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carSkodaSuperB_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carPeugeot107_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carKiaRio_1);
            context.Cars.AddOrUpdate(c => c.LicenceNumber,carFiat500_1);

            #endregion

            #region Add customers to context

            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer1);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer2);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer3);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer4);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer5);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer6);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer7);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer8);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer8);
            context.Customers.AddOrUpdate(c => c.CustomerNumber, customer10);

            #endregion

            #region Add offices to context

            context.Offices.AddOrUpdate(o => new {o.City, o.Street}, officeWien);
            context.Offices.AddOrUpdate(o => new { o.City, o.Street }, officeSalzburg);
            context.Offices.AddOrUpdate(o => new { o.City, o.Street }, officeBerlin);
            context.Offices.AddOrUpdate(o => new { o.City, o.Street }, officeMuenchen);
            context.Offices.AddOrUpdate(o => new { o.City, o.Street }, officeBratislava);
            context.Offices.AddOrUpdate(o => new { o.City, o.Street }, officePrag);

            #endregion

            #region Add Invoices to context

            context.Invoices.AddOrUpdate(i => i.Price, invoice1);
            context.Invoices.AddOrUpdate(i => i.Price, invoice2);
            context.Invoices.AddOrUpdate(i => i.Price, invoice3);
            context.Invoices.AddOrUpdate(i => i.Price, invoice4);
            context.Invoices.AddOrUpdate(i => i.Price, invoice5);
            context.Invoices.AddOrUpdate(i => i.Price, invoice6);
            context.Invoices.AddOrUpdate(i => i.Price, invoice7);
            context.Invoices.AddOrUpdate(i => i.Price, invoice8);

            #endregion

            base.Seed(context);
        }
    }
}