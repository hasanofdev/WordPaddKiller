namespace WordPaddKiller.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.FontCombo = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.FontCombo);
            this.TopPanel.Controls.Add(this.FontLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // FontCombo
            // 
            this.FontCombo.FormattingEnabled = true;
            this.FontCombo.Location = new System.Drawing.Point(3, 46);
            this.FontCombo.Name = "FontCombo";
            this.FontCombo.Size = new System.Drawing.Size(144, 23);
            this.FontCombo.TabIndex = 1;
            // 
            // FontLabel
            // 
            this.FontLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FontLabel.Location = new System.Drawing.Point(3, 20);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(144, 23);
            this.FontLabel.TabIndex = 0;
            this.FontLabel.Text = "Font";
            this.FontLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainView";
            this.Text = "Word Pad Killer";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private ComboBox FontCombo;
        private Label FontLabel;
    }
}