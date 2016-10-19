namespace Phone
{
    using Components;

    public abstract class BasePhone
    {
        protected IProcessor Processor { get; set; }
        protected IDisplay Display { get; set; }
        public uint BatteryCapacity { get; protected set; }
    }
}