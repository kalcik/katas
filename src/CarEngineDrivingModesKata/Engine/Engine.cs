namespace Engine
{
    using System;
    using DrivingModes;

    public class Engine : IEngine
    {
        public decimal CurrentThrust { get; set; }

        public IDrivingMode DrivingMode { get; private set; }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void ChangeDrivingMode(IDrivingMode drivingMode)
        {
            throw new NotImplementedException();
        }

        public void Decelerate()
        {
            throw new NotImplementedException();
        }
    }
}