namespace Engine
{
    using System;
    using Interfaces;

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
            DrivingMode = drivingMode;
        }

        public void Decelerate()
        {
            throw new NotImplementedException();
        }
    }
}