using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GeigerComputerCounter
{
    public partial class FormComputerGeiger : Form
    {
        private Stopwatch _stopwatch;
        private Stopwatch _breakStopwatch;
        private readonly GeigerService _service;

        public FormComputerGeiger()
        {
            InitializeComponent();

            _service = new GeigerService();
            _stopwatch = Stopwatch.StartNew();

            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
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
                Log($"Locked at: {DateTime.Now.ToShortTimeString()}");
                _stopwatch.Stop();
                _breakStopwatch = Stopwatch.StartNew();
            }

            if (reason == SessionSwitchReason.SessionUnlock)
            {
                Log($"Unlocked at: {DateTime.Now.ToShortTimeString()}");
                VerifyScreenBreakLength();
            }
        }

        private void Log(string message)
        {
            EventsList.Items.Add(message);
            EventsList.SetSelected(EventsList.Items.Count - 1, true);
        }

        private void VerifyScreenBreakLength()
        {
            _breakStopwatch.Stop();

            if (_breakStopwatch.Elapsed < new TimeSpan(0, 5, 0))
            {
                Log("** Screen lock was under 5 mins. Please take a longer break! **");
                _stopwatch.Start();
                return;
            }

            _stopwatch = Stopwatch.StartNew();
            _breakStopwatch.Reset();
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
            var status = _service.Get(_stopwatch.Elapsed);

            ColourPanel.BackColor = status.Colour;
            BreakLabel.Visible = status.ShowLabel;
            this.TopMost = status.ShowOnTop;
        }
    }
}
