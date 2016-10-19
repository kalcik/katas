namespace Phone.Components
{
    public class FiveInchDisplay : IDisplay
    {
        public FiveInchDisplay()
        {
            Size = 5.0f;
            Resolution = "1920x1080";
        }

        public float Size { get; }
        public string Resolution { get; }
    }
}