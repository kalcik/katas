namespace Phone.Components
{
    class SixteenMegapixel : ICamera
    {
        public SixteenMegapixel()
        {
            Resolution = 16.0f;
            DigitalZoom = 3;
        }

        public byte DigitalZoom { get; }

        public float Resolution { get; }
    }
}