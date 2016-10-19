namespace Phone.Components
{
    public class Snapdragon805 : IProcessor
    {
        public Snapdragon805()
        {
            NumberOfCores = 4;
            ClockSpeed = 2.7f;
        }

        public byte NumberOfCores { get; }
        public float ClockSpeed { get; }
    }
}