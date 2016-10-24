namespace Engine.Tests
{
    using FluentAssertions;
    using Xunit;

    public class EngineTests
    {
        [Fact]
        public void EngineAccelerateWithNormalDrivingMode()
        {
            IEngine engine = new Engine();
            engine.Accelerate();
            engine.CurrentThrust.Should().Be(90);
        }

        [Fact]
        public void EngineDecelerateWithNormalDrivingMode()
        {
            IEngine engine = new Engine();
            engine.CurrentThrust = 90m;
            engine.Decelerate();
            engine.CurrentThrust.Should().Be(0);
        }
    }
}