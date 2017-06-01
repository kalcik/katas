using System.Data.Entity;
using CarRental.Core;
using CarRental.Entities;

namespace CarRental.Repositories
{
    public class CarRentalDbContext : DbContext
    {
        public CarRentalDbContext() : base(ApplicationSettings.CarRentalDbConnectionStringName)
        {
            Database.SetInitializer(new CarRentalDbInitializer());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}