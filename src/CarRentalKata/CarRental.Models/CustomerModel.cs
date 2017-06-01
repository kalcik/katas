using System;
using System.Collections.Generic;
using System.Reflection;

namespace CarRental.Models
{
    public class CustomerModel
    {
        public const int Consumer = 1;
        public const int ConsumerPremium = Consumer + 1;
        public const int Business = ConsumerPremium + 1;
        public const int BusinessPremium = Business + 1;

        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CustomerType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

    }
}