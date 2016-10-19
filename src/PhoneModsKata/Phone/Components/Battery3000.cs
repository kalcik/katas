namespace Phone.Components
{
    public class Battery3000 : IBattery
    {
        public Battery3000()
        {
            Capacity = 3000;
        }

        public uint Capacity { get; }
    }
}