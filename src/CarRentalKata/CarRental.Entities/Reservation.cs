using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace CarRental.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
    }
}