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
            if (!changessaved)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveBtn_Click(null, null);
                else if (result == DialogResult.Cancel)
                    return;

            }
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
            this.CurrentColorLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.ColorPickBtn = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorCombo = new System.Windows.Forms.ComboBox();
            this.RightBtn = new System.Windows.Forms.Button();
            this.CenterBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.AligmentLabel = new System.Windows.Forms.Label();
            this.ItalicBtn = new System.Windows.Forms.Button();
            this.UnderlineBtn = new System.Windows.Forms.Button();
            this.BoldBtn = new System.Windows.Forms.Button();
            this.FontStyle = new System.Windows.Forms.Label();
            this.SizeCombo = new System.Windows.Forms.ComboBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.FontCombo = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.ColorPickDialog = new System.Windows.Forms.ColorDialog();
            this.MainTxt = new System.Windows.Forms.TextBox();
            this.UploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.CurrentColorLabel);
            this.TopPanel.Controls.Add(this.SaveBtn);
            this.TopPanel.Controls.Add(this.UploadBtn);
            this.TopPanel.Controls.Add(this.ColorPickBtn);
            this.TopPanel.Controls.Add(this.ColorLabel);
            this.TopPanel.Controls.Add(this.ColorCombo);
            this.TopPanel.Controls.Add(this.RightBtn);
            this.TopPanel.Controls.Add(this.CenterBtn);
            this.TopPanel.Controls.Add(this.LeftBtn);
            this.TopPanel.Controls.Add(this.AligmentLabel);
            this.TopPanel.Controls.Add(this.ItalicBtn);
            this.TopPanel.Controls.Add(this.UnderlineBtn);
            this.TopPanel.Controls.Add(this.BoldBtn);
            this.TopPanel.Controls.Add(this.FontStyle);
            this.TopPanel.Controls.Add(this.SizeCombo);
            this.TopPanel.Controls.Add(this.SizeLabel);
            this.TopPanel.Controls.Add(this.FontCombo);
            this.TopPanel.Controls.Add(this.FontLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // CurrentColorLabel
            // 
            this.CurrentColorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentColorLabel.Location = new System.Drawing.Point(498, 49);
            this.CurrentColorLabel.Name = "CurrentColorLabel";
            this.CurrentColorLabel.Size = new System.Drawing.Size(22, 22);
            this.CurrentColorLabel.TabIndex = 17;
            this.CurrentColorLabel.BackColorChanged += new System.EventHandler(this.CurrentColorLabel_BackColorChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Image = global::WordPaddKiller.Properties.Resources.SaveIco;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(709, 60);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 34);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadBtn.Image = global::WordPaddKiller.Properties.Resources.UploadFileIco;
            this.UploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UploadBtn.Location = new System.Drawing.Point(709, 20);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(88, 34);
            this.UploadBtn.TabIndex = 15;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // ColorPickBtn
            // 
            this.ColorPickBtn.BackgroundImage = global::WordPaddKiller.Properties.Resources.ColorPickerIco;
            this.ColorPickBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorPickBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPickBtn.FlatAppearance.BorderSize = 0;
            this.ColorPickBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ColorPickBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ColorPickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPickBtn.Location = new System.Drawing.Point(653, 48);
            this.ColorPickBtn.Name = "ColorPickBtn";
            this.ColorPickBtn.Size = new System.Drawing.Size(24, 24);
            this.ColorPickBtn.TabIndex = 14;
            this.ColorPickBtn.UseVisualStyleBackColor = true;
            this.ColorPickBtn.Click += new System.EventHandler(this.ColorPickBtn_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorLabel.Location = new System.Drawing.Point(526, 23);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(121, 23);
            this.ColorLabel.TabIndex = 13;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ColorCombo
            // 
            this.ColorCombo.DropDownHeight = 110;
            this.ColorCombo.DropDownWidth = 144;
            this.ColorCombo.FormattingEnabled = true;
            this.ColorCombo.IntegralHeight = false;
            this.ColorCombo.Items.AddRange(new object[] {
            "Black"});
            this.ColorCombo.Location = new System.Drawing.Point(526, 49);
            this.ColorCombo.Name = "ColorCombo";
            this.ColorCombo.Size = new System.Drawing.Size(121, 23);
            this.ColorCombo.TabIndex = 12;
            this.ColorCombo.Text = "Control";
            this.ColorCombo.SelectedIndexChanged += new System.EventHandler(this.ColorCombo_SelectedIndexChanged);
            // 
            // RightBtn
            // 
            this.RightBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RightBtn.Location = new System.Drawing.Point(438, 46);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(24, 26);
            this.RightBtn.TabIndex = 11;
            this.RightBtn.Tag = System.Windows.Forms.HorizontalAlignment.Right;
            this.RightBtn.Text = "R";
            this.RightBtn.UseVisualStyleBackColor = false;
            this.RightBtn.Click += new System.EventHandler(this.Aligment_Btns_Clicks);
            // 
            // CenterBtn
            // 
            this.CenterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CenterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CenterBtn.Location = new System.Drawing.Point(408, 46);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(24, 26);
            this.CenterBtn.TabIndex = 10;
            this.CenterBtn.Tag = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenterBtn.Text = "C";
            this.CenterBtn.UseVisualStyleBackColor = false;
            this.CenterBtn.Click += new System.EventHandler(this.Aligment_Btns_Clicks);
            // 
            // LeftBtn
            // 
            this.LeftBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LeftBtn.Location = new System.Drawing.Point(378, 46);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(24, 26);
            this.LeftBtn.TabIndex = 9;
            this.LeftBtn.Tag = System.Windows.Forms.HorizontalAlignment.Left;
            this.LeftBtn.Text = "L";
            this.LeftBtn.UseVisualStyleBackColor = false;
            this.LeftBtn.Click += new System.EventHandler(this.Aligment_Btns_Clicks);
            // 
            // AligmentLabel
            // 
            this.AligmentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AligmentLabel.Location = new System.Drawing.Point(378, 20);
            this.AligmentLabel.Name = "AligmentLabel";
            this.AligmentLabel.Size = new System.Drawing.Size(84, 23);
            this.AligmentLabel.TabIndex = 8;
            this.AligmentLabel.Text = "Aligment";
            this.AligmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ItalicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItalicBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ItalicBtn.Location = new System.Drawing.Point(321, 46);
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(24, 26);
            this.ItalicBtn.TabIndex = 7;
            this.ItalicBtn.Text = "I";
            this.ItalicBtn.UseVisualStyleBackColor = false;
            this.ItalicBtn.Click += new System.EventHandler(this.FontSyle_Btns_Clicks);
            // 
            // UnderlineBtn
            // 
            this.UnderlineBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UnderlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnderlineBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.UnderlineBtn.Location = new System.Drawing.Point(291, 46);
            this.UnderlineBtn.Name = "UnderlineBtn";
            this.UnderlineBtn.Size = new System.Drawing.Size(24, 26);
            this.UnderlineBtn.TabIndex = 6;
            this.UnderlineBtn.Text = "U";
            this.UnderlineBtn.UseVisualStyleBackColor = false;
            this.UnderlineBtn.Click += new System.EventHandler(this.FontSyle_Btns_Clicks);
            // 
            // BoldBtn
            // 
            this.BoldBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoldBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BoldBtn.Location = new System.Drawing.Point(261, 46);
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(24, 26);
            this.BoldBtn.TabIndex = 5;
            this.BoldBtn.Text = "B";
            this.BoldBtn.UseVisualStyleBackColor = false;
            this.BoldBtn.Click += new System.EventHandler(this.FontSyle_Btns_Clicks);
            // 
            // FontStyle
            // 
            this.FontStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FontStyle.Location = new System.Drawing.Point(261, 20);
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(84, 23);
            this.FontStyle.TabIndex = 4;
            this.FontStyle.Text = "Font Style";
            this.FontStyle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SizeCombo
            // 
            this.SizeCombo.DropDownHeight = 110;
            this.SizeCombo.DropDownWidth = 144;
            this.SizeCombo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SizeCombo.FormattingEnabled = true;
            this.SizeCombo.IntegralHeight = false;
            this.SizeCombo.Location = new System.Drawing.Point(170, 46);
            this.SizeCombo.Name = "SizeCombo";
            this.SizeCombo.Size = new System.Drawing.Size(54, 23);
            this.SizeCombo.TabIndex = 3;
            this.SizeCombo.SelectedIndexChanged += new System.EventHandler(this.FontSizeCombo_SelectedIndexChanged);
            this.SizeCombo.TextChanged += new System.EventHandler(this.SizeCombo_TextChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.Location = new System.Drawing.Point(170, 20);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(54, 23);
            this.SizeLabel.TabIndex = 2;
            this.SizeLabel.Text = "Size";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FontCombo
            // 
            this.FontCombo.DropDownHeight = 110;
            this.FontCombo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FontCombo.FormattingEnabled = true;
            this.FontCombo.IntegralHeight = false;
            this.FontCombo.Location = new System.Drawing.Point(3, 46);
            this.FontCombo.Name = "FontCombo";
            this.FontCombo.Size = new System.Drawing.Size(144, 23);
            this.FontCombo.TabIndex = 1;
            this.FontCombo.SelectedIndexChanged += new System.EventHandler(this.FontSizeCombo_SelectedIndexChanged);
            this.FontCombo.TextChanged += new System.EventHandler(this.FontCombo_TextChanged);
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
            // MainTxt
            // 
            this.MainTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTxt.Location = new System.Drawing.Point(0, 100);
            this.MainTxt.MaxLength = 100000;
            this.MainTxt.Multiline = true;
            this.MainTxt.Name = "MainTxt";
            this.MainTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainTxt.Size = new System.Drawing.Size(800, 350);
            this.MainTxt.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTxt);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainView";
            this.Text = "Word Pad Killer";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopPanel;
        private ComboBox FontCombo;
        private Label FontLabel;
        private ComboBox SizeCombo;
        private Label SizeLabel;
        private Label ColorLabel;
        private ComboBox ColorCombo;
        private Button RightBtn;
        private Button CenterBtn;
        private Button LeftBtn;
        private Label AligmentLabel;
        private Button ItalicBtn;
        private Button UnderlineBtn;
        private Button BoldBtn;
        private Label FontStyle;
        private Button ColorPickBtn;
        private Button SaveBtn;
        private Button UploadBtn;
        private ColorDialog ColorPickDialog;
        private Label CurrentColorLabel;
        private TextBox MainTxt;
        private OpenFileDialog UploadDialog;
        private SaveFileDialog SaveDialog;
    }
}