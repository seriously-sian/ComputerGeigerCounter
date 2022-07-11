using System.Drawing;

namespace ComputerGeigerCounter
{
    public class ColourFade
    {
        private Color GreenRed { get; }
        private Color BlueRed { get; }

        public ColourFade(
            Color greenRed,
            Color blueRed)
        {
            GreenRed = greenRed;
            BlueRed = blueRed;
        }

        public Color ForSetting(string colourFade)
        {
            return colourFade == AppSettings.GreenToRed
                ? GreenRed
                : BlueRed;
        }
    }
}