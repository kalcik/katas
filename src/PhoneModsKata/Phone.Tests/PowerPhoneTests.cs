namespace Phone.Tests
{
    using Components;
    using FluentAssertions;
    using Xunit;

    public class PowerPhoneTests
    {
        [Fact]
        public void BatteryCapacityAfterAttachingExtraBatteryIsIncreased()
        {
            PowerPhone phone = new MotoPower();
            phone.AttachExtraBattery(new Battery3000());
            phone.BatteryCapacity.Should().Be(6000);
        }

        [Fact]
        public void BatteryCapacityAfterDetachingExtraBatteryIsDecreased()
        {
            PowerPhone phone = new MotoPower();
            phone.AttachExtraBattery(new Battery3000());
            phone.DetachExtraBatter(new Battery3000());
            phone.BatteryCapacity.Should().Be(3000);
        }
    }
}