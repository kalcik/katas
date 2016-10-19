namespace Phone
{
    using Components;

    public abstract class CameraPhone : BasePhone
    {
        protected ICamera Camera { get; set; }
    }
}