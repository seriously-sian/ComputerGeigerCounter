using System.Drawing;

namespace ComputerGeigerCounter
{
    public class Theme
    {
        public Color BackgroundColour { get; }
        public Color TextColour { get; }
        public Color OutlineColour { get; }

        public Theme(Color backgroundColour, 
            Color textColour, 
            Color outlineColour)
        {
            BackgroundColour = backgroundColour;
            TextColour = textColour;
            OutlineColour = outlineColour;
        }

        public static Theme Light()
        {
            return new Theme(
                Color.White, 
                Color.Black, 
                Color.DimGray);
        }

        public static Theme Dark()
        {
            return new Theme(
                Color.Black,
                Color.White,
                Color.LightGray);
        }
    }
}