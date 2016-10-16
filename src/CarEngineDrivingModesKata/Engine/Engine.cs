namespace Engine
{
    using Interfaces;

    public class Engine : IEngine
    {
        public decimal CurrentThrust { get; set; }

        public IDrivingMode DrivingMode { get; private set; }

        public void Accelerate()
        {
            DrivingMode.Accelerate(this);
        }

        public void ChangeDrivingMode(IDrivingMode drivingMode)
        {
            DrivingMode = drivingMode;
        }

        public void Decelerate()
        {
            DrivingMode.Decelerate(this);
        }
    }
}