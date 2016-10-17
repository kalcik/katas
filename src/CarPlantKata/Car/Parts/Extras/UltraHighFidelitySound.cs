namespace Car.Parts.Extras
{
    class UltraHighFidelitySound : IExtraPackage
    {
        public UltraHighFidelitySound()
        {
            Name = nameof(UltraHighFidelitySound);
        }

        public string Name { get; }
    }
}