using System;
using System.Drawing;

namespace ComputerGeigerCounter
{
    public class GeigerService
    {
        private readonly string _colourFade;
        private TimeSpan _stopwatchElapsed;

        public GeigerService(string colourFade)
        {
            _colourFade = colourFade;
        }

        public GeigerPanelStatus Get(TimeSpan stopwatchElapsed)
        {
            _stopwatchElapsed = stopwatchElapsed;

            var colour = GetColour();
            var showLabel = GetShowLabel();
            var showOnTop = GetShowOnTop();

            return new GeigerPanelStatus(colour, showLabel, showOnTop);
        }

        private bool GetShowOnTop()
        {
            return StopwatchExceeded(1, 10, 0);
        }

        private bool GetShowLabel()
        {
            return StopwatchExceeded(1, 0, 0);
        }

        private Color GetColour()
        {
            if (StopwatchExceeded(1, 15, 0))
            {
                return Colour.Index[11].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(1, 10, 0))
            {
                return Colour.Index[10].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(1, 5, 0))
            {
                return Colour.Index[9].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(1, 0, 0))
            {
                return Colour.Index[8].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(0, 55, 0))
            {
                return Colour.Index[7].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(0, 50, 0))
            {
                return Colour.Index[6].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(0, 45, 0))
            {
                return Colour.Index[5].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(0, 40, 0))
            {
                return Colour.Index[4].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(0, 35, 0))
            {
                return Colour.Index[3].ForSetting(_colourFade);
            }

            if (StopwatchExceeded(0, 30, 0))
            {
                return Colour.Index[2].ForSetting(_colourFade);
            }

            return Colour.Index[1].ForSetting(_colourFade);
        }

        private bool StopwatchExceeded(int hour, int minute, int second)
        {
            return _stopwatchElapsed >= new TimeSpan(hour, minute, second);
        }
    }
}