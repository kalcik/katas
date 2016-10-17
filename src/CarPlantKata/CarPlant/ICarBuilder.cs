namespace CarPlant
{
    using Car.Parts.Chassis;
    using Car.Parts.Engine;
    using Car.Parts.Exterior;
    using Car.Parts.Extras;
    using Car.Parts.Interior;

    public interface ICarBuilder
    {
        void SetChassis(IChassis chassis);
        void SetColor(Color color);
        void SetEngine(IEngine engine);
        void SetInterior(InteriorColor interiorColor);
        void AddExtraPackage(IExtraPackage extraPackage);
    }
}