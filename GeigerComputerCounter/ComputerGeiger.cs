using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ComputerGeigerCounter
{
    public partial class FormComputerGeiger : Form
    {
        private Stopwatch _stopwatch;
        private Stopwatch _breakStopwatch;
        private GeigerService _service;
        private readonly AppSettings _appSettings;
        private string SettingsJsonPath => "../../../settings.json";

        public FormComputerGeiger()
        {
            InitializeComponent();

            _stopwatch = Stopwatch.StartNew();
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;

            if (!File.Exists(SettingsJsonPath))
            {
                _appSettings = AppSettings.DefaultSettings();
            }
            else
            {
                var appSettingsFile = File.ReadAllText(SettingsJsonPath);
                _appSettings = JsonConvert.DeserializeObject<AppSettings>(appSettingsFile)
                    ?? AppSettings.DefaultSettings();
            }

            _service = new GeigerService(_appSettings.ColourFade);
            SetTheme();
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            OnSessionSwitch(e.Reason);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            OnTimerTick();
        }

        private void themeButton_Click(object sender, EventArgs e)
        {
            OnClickTheme();
        }

        private void ColourFadeButton_Click(object sender, EventArgs e)
        {
            OnClickColourFade();
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
            TimeSinceUnlocked.Text =
                @"Computer unlocked for " +
                $@"{_stopwatch.Elapsed.Hours:D2}:" +
                $@"{_stopwatch.Elapsed.Minutes:D2}:" +
                $@"{_stopwatch.Elapsed.Seconds:D2}";
        }

        private void SetColourPanel()
        {
            var status = _service.Get(_stopwatch.Elapsed);

            ColourPanel.BackColor = status.Colour;
            BreakLabel.Visible = status.ShowLabel;
            this.TopMost = status.ShowOnTop;
        }

        private void OnClickTheme()
        {
            if (_appSettings.Theme == AppSettings.DarkTheme)
            {
                _appSettings.Theme = AppSettings.LightTheme;
                themeButton.Text = "Dark";
            }
            else
            {
                _appSettings.Theme = AppSettings.DarkTheme;
                themeButton.Text = "Light";
            }

            SetTheme();
        }

        private void SetTheme()
        {
            var theme = _appSettings.Theme == AppSettings.LightTheme 
                ? Theme.Light()
                : Theme.Dark();

            BackColor = theme.BackgroundColour;
            ForeColor = theme.TextColour;
            TimeSinceUnlocked.BackColor = theme.BackgroundColour;
            TimeSinceUnlocked.ForeColor = theme.TextColour;
            EventsGroupBox.BackColor = theme.BackgroundColour;
            EventsGroupBox.ForeColor = theme.TextColour;
            EventsList.BackColor = theme.BackgroundColour;
            EventsList.ForeColor = theme.TextColour;
            SettingsGroupBox.BackColor = theme.BackgroundColour;
            SettingsGroupBox.ForeColor = theme.TextColour;
            ThemeLabel.BackColor = theme.BackgroundColour;
            ThemeLabel.ForeColor = theme.TextColour;
            ColourFadeLabel.BackColor = theme.BackgroundColour;
            ColourFadeLabel.ForeColor = theme.TextColour;
            ColourFadeButton.BackColor = theme.BackgroundColour;
            ColourFadeButton.ForeColor = theme.TextColour;
            ColourFadeButton.FlatAppearance.BorderColor = theme.OutlineColour;

            var reverseTheme = _appSettings.Theme == AppSettings.LightTheme
                ? Theme.Dark()
                : Theme.Light();

            themeButton.BackColor = reverseTheme.BackgroundColour;
            themeButton.ForeColor = reverseTheme.TextColour;
            themeButton.FlatAppearance.BorderColor = reverseTheme.OutlineColour;
        }

        private void OnClickColourFade()
        {
            if (_appSettings.ColourFade == AppSettings.BlueToRed)
            {
                _appSettings.ColourFade = AppSettings.GreenToRed;
                ColourFadeButton.Text = "Blue to Red";
            }
            else
            {
                _appSettings.ColourFade = AppSettings.BlueToRed;
                ColourFadeButton.Text = "Green to Red";
            }

            _service = new GeigerService(_appSettings.ColourFade);
            WriteSettingsToFile();
        }

        private void WriteSettingsToFile()
        {
            File.WriteAllText(SettingsJsonPath, JsonConvert.SerializeObject(_appSettings));
        }
    }
}
