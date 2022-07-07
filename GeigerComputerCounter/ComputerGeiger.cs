using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GeigerComputerCounter
{
    public partial class FormComputerGeiger : Form
    {
        private Stopwatch _stopwatch;
        private Stopwatch _lockStopwatch;

        public FormComputerGeiger()
        {
            InitializeComponent();

            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
            _stopwatch = Stopwatch.StartNew();
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            OnSessionSwitch(e.Reason);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            OnTimerTick();
        }

        private void OnSessionSwitch(SessionSwitchReason reason)
        {
            if (reason == SessionSwitchReason.SessionLock)
            {
                EventsList.Items.Add($"Locked at: {DateTime.Now.ToShortTimeString()}");
                _stopwatch.Stop();
                _lockStopwatch = Stopwatch.StartNew();
            }

            if (reason == SessionSwitchReason.SessionUnlock)
            {
                EventsList.Items.Add($"Unlocked at: {DateTime.Now.ToShortTimeString()}");
                VerifyScreenBreakLength();
            }
        }

        private void VerifyScreenBreakLength()
        {
            _lockStopwatch.Stop();
            
            if (_lockStopwatch.Elapsed.Minutes < 5 && _lockStopwatch.Elapsed.Hours < 1)
            {
                EventsList.Items.Add("** Screen lock was under 5 mins. Please take a longer break! **");
                _stopwatch.Start();
                return; 
                
            }

            _stopwatch = Stopwatch.StartNew();
            _lockStopwatch.Reset();
        }

        private void OnTimerTick()
        {
            SetUnlockedText();
            SetColourPanel();
        }

        private void SetUnlockedText()
        {
            TimeSinceUnlocked.Text = "Computer unlocked for: " +
                $"{_stopwatch.Elapsed.Hours}:" +
                $"{_stopwatch.Elapsed.Minutes}:" +
                $"{_stopwatch.Elapsed.Seconds}";
        }

        private void SetColourPanel()
        {
            var colourPanelService = new GeigerPanelService();
            var status = colourPanelService.Get(_stopwatch.Elapsed);

            ColourPanel.BackColor = status.Colour;
            BreakLabel.Visible = status.ShowLabel;
            this.TopMost = status.ShowOnTop;
        }
    }
}
