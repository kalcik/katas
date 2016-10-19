namespace Phone
{
    using Components;

    public abstract class PowerPhone : CameraPhone
    {
        public void AttachExtraBattery(IBattery battery)
        {
            BatteryCapacity += battery.Capacity;
        }

        public void DetachExtraBatter(IBattery battery)
        {
            BatteryCapacity -= battery.Capacity;
        }
    }
}