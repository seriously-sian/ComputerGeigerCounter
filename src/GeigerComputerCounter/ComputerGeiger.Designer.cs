namespace ComputerGeigerCounter
{
    partial class FormComputerGeiger
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeSinceUnlocked = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.EventsList = new System.Windows.Forms.ListBox();
            this.ColourPanel = new System.Windows.Forms.Panel();
            this.BreakLabel = new System.Windows.Forms.Label();
            this.themeButton = new System.Windows.Forms.Button();
            this.ColourFadeButton = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ColourFadeLabel = new System.Windows.Forms.Label();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.EventsGroupBox = new System.Windows.Forms.GroupBox();
            this.ColourPanel.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.EventsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeSinceUnlocked
            // 
            this.TimeSinceUnlocked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSinceUnlocked.BackColor = System.Drawing.Color.White;
            this.TimeSinceUnlocked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeSinceUnlocked.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeSinceUnlocked.ForeColor = System.Drawing.Color.Black;
            this.TimeSinceUnlocked.Location = new System.Drawing.Point(12, 12);
            this.TimeSinceUnlocked.Name = "TimeSinceUnlocked";
            this.TimeSinceUnlocked.Size = new System.Drawing.Size(440, 32);
            this.TimeSinceUnlocked.TabIndex = 1;
            this.TimeSinceUnlocked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EventsList
            // 
            this.EventsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsList.BackColor = System.Drawing.Color.White;
            this.EventsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventsList.ForeColor = System.Drawing.Color.Black;
            this.EventsList.FormattingEnabled = true;
            this.EventsList.ItemHeight = 15;
            this.EventsList.Location = new System.Drawing.Point(6, 22);
            this.EventsList.Name = "EventsList";
            this.EventsList.ScrollAlwaysVisible = true;
            this.EventsList.Size = new System.Drawing.Size(428, 60);
            this.EventsList.TabIndex = 0;
            // 
            // ColourPanel
            // 
            this.ColourPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColourPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.ColourPanel.Controls.Add(this.BreakLabel);
            this.ColourPanel.Location = new System.Drawing.Point(12, 50);
            this.ColourPanel.Name = "ColourPanel";
            this.ColourPanel.Size = new System.Drawing.Size(440, 100);
            this.ColourPanel.TabIndex = 2;
            // 
            // BreakLabel
            // 
            this.BreakLabel.AutoSize = true;
            this.BreakLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakLabel.ForeColor = System.Drawing.Color.Ivory;
            this.BreakLabel.Location = new System.Drawing.Point(90, 34);
            this.BreakLabel.Name = "BreakLabel";
            this.BreakLabel.Size = new System.Drawing.Size(252, 32);
            this.BreakLabel.TabIndex = 1;
            this.BreakLabel.Text = "Take a screen break!";
            this.BreakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BreakLabel.Visible = false;
            // 
            // themeButton
            // 
            this.themeButton.BackColor = System.Drawing.Color.DimGray;
            this.themeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.themeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeButton.ForeColor = System.Drawing.Color.White;
            this.themeButton.Location = new System.Drawing.Point(58, 17);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(135, 26);
            this.themeButton.TabIndex = 3;
            this.themeButton.Text = "Dark";
            this.themeButton.UseVisualStyleBackColor = false;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // ColourFadeButton
            // 
            this.ColourFadeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColourFadeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColourFadeButton.ForeColor = System.Drawing.Color.Black;
            this.ColourFadeButton.Location = new System.Drawing.Point(296, 17);
            this.ColourFadeButton.Name = "ColourFadeButton";
            this.ColourFadeButton.Size = new System.Drawing.Size(135, 26);
            this.ColourFadeButton.TabIndex = 4;
            this.ColourFadeButton.Text = "Blue to Red";
            this.ColourFadeButton.UseVisualStyleBackColor = true;
            this.ColourFadeButton.Click += new System.EventHandler(this.ColourFadeButton_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsGroupBox.Controls.Add(this.ColourFadeLabel);
            this.SettingsGroupBox.Controls.Add(this.ThemeLabel);
            this.SettingsGroupBox.Controls.Add(this.ColourFadeButton);
            this.SettingsGroupBox.Controls.Add(this.themeButton);
            this.SettingsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 253);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(440, 51);
            this.SettingsGroupBox.TabIndex = 5;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // ColourFadeLabel
            // 
            this.ColourFadeLabel.AutoSize = true;
            this.ColourFadeLabel.Location = new System.Drawing.Point(218, 23);
            this.ColourFadeLabel.Name = "ColourFadeLabel";
            this.ColourFadeLabel.Size = new System.Drawing.Size(72, 15);
            this.ColourFadeLabel.TabIndex = 7;
            this.ColourFadeLabel.Text = "Colour fade:";
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(6, 23);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(46, 15);
            this.ThemeLabel.TabIndex = 6;
            this.ThemeLabel.Text = "Theme:";
            // 
            // EventsGroupBox
            // 
            this.EventsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsGroupBox.Controls.Add(this.EventsList);
            this.EventsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.EventsGroupBox.Location = new System.Drawing.Point(12, 156);
            this.EventsGroupBox.Name = "EventsGroupBox";
            this.EventsGroupBox.Size = new System.Drawing.Size(440, 91);
            this.EventsGroupBox.TabIndex = 8;
            this.EventsGroupBox.TabStop = false;
            this.EventsGroupBox.Text = "Events";
            // 
            // FormComputerGeiger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 316);
            this.Controls.Add(this.EventsGroupBox);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.ColourPanel);
            this.Controls.Add(this.TimeSinceUnlocked);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComputerGeiger";
            this.ShowIcon = false;
            this.Text = "Computer Geiger";
            this.ColourPanel.ResumeLayout(false);
            this.ColourPanel.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.EventsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TimeSinceUnlocked;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox EventsList;
        private System.Windows.Forms.Panel ColourPanel;
        private System.Windows.Forms.Label BreakLabel;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.Button ColourFadeButton;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label ColourFadeLabel;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.GroupBox EventsGroupBox;
    }
}
