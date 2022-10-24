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
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            List<string> fonts = new();
            foreach (var font in FontFamily.Families)
                fonts.Add(font.Name);
            FontCombo.DisplayMember = "Name";
            FontCombo.ValueMember = "Name";
            FontCombo.DataSource = fonts;
            FontCombo.Text = "Arial";

            List<float> sizes = new() { 8.25F, 9F, 9.75F, 10.75F, 11.25F, 12F, 14.25F, 15.75F, 18F, 20.25F, 21.75F, 24F, 26.25F, 27.75F, 36F, 48F, 72F };
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
            MainTxt.Font = new Font(FontCombo!.SelectedItem.ToString()!, float.Parse(SizeCombo!.SelectedItem.ToString()!));
        }
    }
}
