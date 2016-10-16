namespace Interfaces
{
    public interface IEngine
    {
        decimal CurrentThrust { get; set; }
        IDrivingMode DrivingMode { get; }
        void Accelerate();
        void Decelerate();
        void ChangeDrivingMode(IDrivingMode drivingMode);
    }
}