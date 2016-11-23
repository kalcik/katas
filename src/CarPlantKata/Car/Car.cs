namespace Car
{
    using System.Collections.Generic;
    using Parts.Engine;
    using Parts.Exterior;
    using Parts.Extras;

    public abstract class Car
    {
        public Color Color { get; }
        public IEngine Engine { get; }
        public IEnumerable<IExtraPackage> ExtraPackages { get; }
        public string Name { get; }
    }
}