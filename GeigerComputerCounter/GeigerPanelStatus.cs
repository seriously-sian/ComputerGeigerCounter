using System.Drawing;

namespace ComputerGeigerCounter
{
    public class GeigerPanelStatus
    {
        public Color Colour { get; }
        public bool ShowLabel { get; }
        public bool ShowOnTop { get; }

        public GeigerPanelStatus(
            Color colour, 
            bool showLabel, 
            bool showOnTop)
        {
            Colour = colour;
            ShowLabel = showLabel;
            ShowOnTop = showOnTop;
        }
    }
}