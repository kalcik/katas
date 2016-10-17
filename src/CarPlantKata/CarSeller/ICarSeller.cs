namespace CarSeller
{
    using Car;
    using CarPlant;

    public interface ICarSeller
    {
        Car Order(ICarBuilder carBuilder);
    }
}