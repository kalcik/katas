namespace CarPlant
{
    using Car.Parts.Engine;
    using Car.Parts.Exterior;
    using Car.Parts.Extras;

    public interface ICarBuilder
    {
        void AddExtraPackage(IExtraPackage extraPackage);
        void SetColor(Color color);
        void SetEngine(IEngine engine);
    }
}