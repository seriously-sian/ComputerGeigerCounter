using System.Collections.Generic;
using System.Drawing;

namespace ComputerGeigerCounter
{
    public static class Colour
    {
        public static Dictionary<int, ColourFade> Index = new Dictionary<int, ColourFade>
        {
            { 1, new ColourFade(Color.FromArgb(0, 210, 0), Color.FromArgb(0, 0, 210)) },
            { 2, new ColourFade(Color.FromArgb(90, 210, 0), Color.FromArgb(90, 0, 210)) },
            { 3, new ColourFade(Color.FromArgb(120, 210, 0), Color.FromArgb(120, 0, 210)) },
            { 4, new ColourFade(Color.FromArgb(150, 210, 0), Color.FromArgb(150, 0, 210)) },
            { 5, new ColourFade(Color.FromArgb(180, 210, 0), Color.FromArgb(180, 0, 210)) },
            { 6, new ColourFade(Color.FromArgb(210, 210, 0), Color.FromArgb(210, 0, 210)) },
            { 7, new ColourFade(Color.FromArgb(210, 180, 0), Color.FromArgb(210, 0, 180)) },
            { 8, new ColourFade(Color.FromArgb(210, 150, 0), Color.FromArgb(210, 0, 150)) },
            { 9, new ColourFade(Color.FromArgb(210, 120, 0), Color.FromArgb(210, 0, 120)) },
            { 10, new ColourFade(Color.FromArgb(210, 90, 0), Color.FromArgb(210, 0, 90)) },
            { 11, new ColourFade(Color.FromArgb(210, 0, 0), Color.FromArgb(210, 0, 0)) }
        };
    }
}