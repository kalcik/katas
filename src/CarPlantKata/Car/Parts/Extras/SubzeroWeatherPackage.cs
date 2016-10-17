namespace Car.Parts.Extras
{
    public class SubzeroWeatherPackage : IExtraPackage
    {
        public SubzeroWeatherPackage()
        {
            Name = nameof(SubzeroWeatherPackage);
        }

        public string Name { get; }
    }
}