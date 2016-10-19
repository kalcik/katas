namespace Phone.Components
{
    public interface IProcessor
    {
        byte NumberOfCores { get; }
        float ClockSpeed { get; }
    }
}