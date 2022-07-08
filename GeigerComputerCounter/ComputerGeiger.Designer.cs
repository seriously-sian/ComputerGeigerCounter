namespace GeigerComputerCounter
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
            this.ColourPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeSinceUnlocked
            // 
            this.TimeSinceUnlocked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSinceUnlocked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeSinceUnlocked.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeSinceUnlocked.Location = new System.Drawing.Point(12, 12);
            this.TimeSinceUnlocked.Name = "TimeSinceUnlocked";
            this.TimeSinceUnlocked.Size = new System.Drawing.Size(431, 32);
            this.TimeSinceUnlocked.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EventsList
            // 
            this.EventsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsList.FormattingEnabled = true;
            this.EventsList.ItemHeight = 15;
            this.EventsList.Location = new System.Drawing.Point(12, 159);
            this.EventsList.Name = "EventsList";
            this.EventsList.ScrollAlwaysVisible = true;
            this.EventsList.Size = new System.Drawing.Size(431, 79);
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
            this.ColourPanel.Size = new System.Drawing.Size(431, 103);
            this.ColourPanel.TabIndex = 2;
            // 
            // BreakLabel
            // 
            this.BreakLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BreakLabel.AutoSize = true;
            this.BreakLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakLabel.ForeColor = System.Drawing.Color.Ivory;
            this.BreakLabel.Location = new System.Drawing.Point(89, 37);
            this.BreakLabel.Name = "BreakLabel";
            this.BreakLabel.Size = new System.Drawing.Size(252, 32);
            this.BreakLabel.TabIndex = 1;
            this.BreakLabel.Text = "Take a screen break!";
            this.BreakLabel.Visible = false;
            // 
            // FormComputerGeiger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 251);
            this.Controls.Add(this.ColourPanel);
            this.Controls.Add(this.TimeSinceUnlocked);
            this.Controls.Add(this.EventsList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComputerGeiger";
            this.Text = "Computer Geiger";
            this.ColourPanel.ResumeLayout(false);
            this.ColourPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TimeSinceUnlocked;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox EventsList;
        private System.Windows.Forms.Panel ColourPanel;
        private System.Windows.Forms.Label BreakLabel;
    }
}
