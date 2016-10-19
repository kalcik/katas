namespace Phone
{
    using Components;

    public class MotoPower : PowerPhone
    {
        public MotoPower()
        {
            Processor = new Snapdragon805();
            Camera = new SixteenMegapixel();
            Display = new FiveInchDisplay();
            BatteryCapacity = 3000;
        }
    }
}