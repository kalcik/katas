namespace CarRental.Entities
{
    public class Car
    {
        public const string Small = "A";
        public const string Medium = "B";
        public const string Large = "C";
        public const string Luxury = "D";

        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string LicenceNumber { get; set; }
        public float KilometerReading { get; set; }
        public string Category { get; set; }
        public Office Office { get; set; }
        public int OfficeId { get; set; }

        public void AddKilometers(float kilometersDriven)
        {
            KilometerReading += kilometersDriven;
        }

    }
}