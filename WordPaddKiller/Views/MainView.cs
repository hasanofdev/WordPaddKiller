using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPaddKiller.Views
{
    public partial class MainView : Form
    {
        List<string> fonts = new();
        List<float> sizes = new() { 8.25F, 9F, 9.75F, 10.75F, 11.25F, 12F, 14.25F, 15.75F, 18F, 20.25F, 21.75F, 24F, 26.25F, 27.75F, 36F, 48F, 72F };

        bool changessaved = false;

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            foreach (var font in FontFamily.Families)
                fonts.Add(font.Name);
            FontCombo.DisplayMember = "Name";
            FontCombo.ValueMember = "Name";
            FontCombo.DataSource = fonts;
            FontCombo.Text = "Arial";

            SizeCombo.DataSource = sizes;
            ColorCombo.DataSource = ColorStructToList();
            ColorCombo.ValueMember = "Name";
        }

        private void ColorPickBtn_Click(object sender, EventArgs e)
        {
            ColorPickDialog.AnyColor = true;
            DialogResult result = ColorPickDialog.ShowDialog();
            CurrentColorLabel.BackColor = ColorPickDialog.Color;
        }

        public static List<Color> ColorStructToList()
        {
            return typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
                                .Select(c => (Color)c.GetValue(null, null))
                                .ToList();
        }

        private void ColorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? cb = sender as ComboBox;

            if (cb!.SelectedItem.GetType() == typeof(Color))
                CurrentColorLabel.BackColor = (Color)cb.SelectedItem;
        }

        private void FontSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SizeCombo!.SelectedItem != null && FontCombo.SelectedItem == null)
                MainTxt.Font = new Font("Arial", float.Parse(SizeCombo!.SelectedItem.ToString()!));
            else if (FontCombo.SelectedItem != null && SizeCombo!.SelectedItem == null)
                MainTxt.Font = new Font(FontCombo.SelectedItem.ToString()!, 8.25F);
            else
                MainTxt.Font = new Font(FontCombo.SelectedItem.ToString()!, float.Parse(SizeCombo!.SelectedItem.ToString()!));
        }

        private void FontSyle_Btns_Clicks(object sender, EventArgs e) => MainTxt.Font = new Font(FontCombo!.SelectedItem.ToString()!, float.Parse(SizeCombo!.SelectedItem.ToString()!), (sender as Button)!.Font.Style);

        private void Aligment_Btns_Clicks(object sender, EventArgs e) => MainTxt.TextAlign = (HorizontalAlignment)(sender as Button)!.Tag;

        private void FontCombo_TextChanged(object sender, EventArgs e)
        {
            ComboBox? cb = sender as ComboBox;

            if (fonts.Find((fontName) => fontName == cb!.Text) is null)
                cb!.Text = "Arial";
        }

        private void SizeCombo_TextChanged(object sender, EventArgs e)
        {
            ComboBox? cb = sender as ComboBox;

            if (sizes.Find((size) => cb.Text == size.ToString()) is 0)
                cb!.Text = sizes[0].ToString();
        }

        private void CurrentColorLabel_BackColorChanged(object sender, EventArgs e)
        {
            MainTxt.ForeColor = (sender as Label)!.BackColor;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            UploadDialog.Filter = @"Txt|*.txt|All Files(*.*)|*.*";
            UploadDialog.InitialDirectory = $@"C:\Users\{Environment.UserName}\{Environment.SpecialFolder.Desktop}";
            DialogResult result = UploadDialog.ShowDialog();

            if (result == DialogResult.OK)
                MainTxt.Text = File.ReadAllText(UploadDialog.FileName);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UploadDialog.FileName))
            {
                File.WriteAllText(UploadDialog.FileName, MainTxt.Text);
                MessageBox.Show("File Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changessaved = true;
            }
            else
            {
                SaveDialog.Filter = @"Txt|*.txt|All Files(*.*)|*.*";
                SaveDialog.InitialDirectory = $@"C:\Users\{Environment.UserName}\{Environment.SpecialFolder.Desktop}";
                DialogResult result = SaveDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    File.WriteAllText(SaveDialog.FileName, MainTxt.Text);
                    UploadDialog.FileName = SaveDialog.FileName;
                    changessaved = true;
                }
            }
        }
    }
}
