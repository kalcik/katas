using System.Collections.Generic;
using System.Runtime;

namespace CarRental.Models
{
    public class OfficeModel
    {
        public int OfficeId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }
}