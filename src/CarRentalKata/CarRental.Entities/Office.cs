using System.Collections.Generic;

namespace CarRental.Entities
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }
}