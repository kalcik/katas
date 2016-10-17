namespace Car
{
    using System.Collections.Generic;
    using Parts.Chassis;
    using Parts.Engine;
    using Parts.Exterior;
    using Parts.Extras;
    using Parts.Interior;

    public abstract class Car
    {
        public string Name { get; }
        public IEngine Engine { get; }
        public Color Color { get; }
        public InteriorColor InteriorColor { get; }
        public IEnumerable<IExtraPackage> ExtraPackages { get; }
        public IChassis Chassis { get; }
    }
}