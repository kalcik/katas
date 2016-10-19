namespace Phone.Components
{
    class SixteenMegapixel : ICamera
    {
        public SixteenMegapixel()
        {
            Resolution = 16.0f;
            DigitalZoom = 3;
            OpticalZoom = 0;
        }

        public float Resolution { get; }
        public byte DigitalZoom { get; }
        public byte OpticalZoom { get; }
    }
}