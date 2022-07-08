using System;
using System.Drawing;

namespace GeigerComputerCounter
{
    public class GeigerService
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
                return Color.FromArgb(210, 0, 0);
            }

            if (StopwatchExceeded(1, 10, 0))
            {
                return Color.FromArgb(210, 90, 0);
            }

            if (StopwatchExceeded(1, 5, 0))
            {
                return Color.FromArgb(210, 120, 0);
            }

            if (StopwatchExceeded(1, 0, 0))
            {
                return Color.FromArgb(210, 150, 0);
            }

            if (StopwatchExceeded(0, 55, 0))
            {
                return Color.FromArgb(210, 180, 0);
            }

            if (StopwatchExceeded(0, 50, 0))
            {
                return Color.FromArgb(210, 210, 0);
            }

            if (StopwatchExceeded(0, 45, 0))
            {
                return Color.FromArgb(180, 210, 0);
            }

            if (StopwatchExceeded(0, 40, 0))
            {
                return Color.FromArgb(150, 210, 0);
            }

            if (StopwatchExceeded(0, 35, 0))
            {
                return Color.FromArgb(120, 210, 0);
            }

            if (StopwatchExceeded(0, 30, 0))
            {
                return Color.FromArgb(90, 210, 0);
            }

            return Color.FromArgb(0, 210, 0);
        }

        private bool StopwatchExceeded(int hour, int minute, int second)
        {
            return _stopwatchElapsed >= new TimeSpan(hour, minute, second);
        }
    }
}