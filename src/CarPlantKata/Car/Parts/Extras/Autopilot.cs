namespace Car.Parts.Extras
{
    public class Autopilot : IExtraPackage
    {
        public Autopilot()
        {
            Name = nameof(Autopilot);
        }

        public string Name { get; }
    }
}