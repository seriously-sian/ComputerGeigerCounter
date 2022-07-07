using System;
using System.Drawing;

namespace GeigerComputerCounter
{
    public class GeigerPanelService
    {
        private TimeSpan _stopwatchElapsed;

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
            return StopwatchElapsed(1, 10, 0);
        }

        private bool GetShowLabel()
        {
            return StopwatchElapsed(1, 0, 0);
        }

        private Color GetColour()
        {
            if (StopwatchElapsed(1, 15, 0))
            {
                return Color.FromArgb(210, 0, 0);
            }

            if (StopwatchElapsed(1, 10, 0))
            {
                return Color.FromArgb(210, 90, 0);
            }

            if (StopwatchElapsed(1, 5, 0))
            {
                return Color.FromArgb(210, 120, 0);
            }

            if (StopwatchElapsed(1, 0, 0))
            {
                return Color.FromArgb(210, 150, 0);
            }

            if (StopwatchElapsed(0, 55, 0))
            {
                return Color.FromArgb(210, 180, 0);
            }

            if (StopwatchElapsed(0, 50, 0))
            {
                return Color.FromArgb(210, 210, 0);
            }

            if (StopwatchElapsed(0, 45, 0))
            {
                return Color.FromArgb(180, 210, 0);
            }

            if (StopwatchElapsed(0, 40, 0))
            {
                return Color.FromArgb(150, 210, 0);
            }

            if (StopwatchElapsed(0, 35, 0))
            {
                return Color.FromArgb(120, 210, 0);
            }

            if (StopwatchElapsed(0, 30, 0))
            {
                return Color.FromArgb(90, 210, 0);
            }

            return Color.FromArgb(0, 210, 0);
        }

        private bool StopwatchElapsed(int hourLimit, int minuteLimit, int secondLimit)
        {
            return _stopwatchElapsed.Hours >= hourLimit &&
                   _stopwatchElapsed.Minutes >= minuteLimit &&
                   _stopwatchElapsed.Seconds >= secondLimit;
        }
    }
}