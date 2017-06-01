using System;

namespace CarRental.Models
{
    public class ReservationModel
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public CarModel Car { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public int? InvoiceId { get; set; }
        public InvoiceModel Invoice { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
    }
}