using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Orion {
    public partial class Settings : DevComponents.DotNetBar.Metro.MetroForm {
        private Color selectedColor;

        public Settings() {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {
            StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Properties.Settings.Default.ColorScheme);
            selectedColor = Properties.Settings.Default.ColorScheme;
            UpdateColor(selectedColor);
        }

        private void UpdateColor(Color c) {
            ColorL.ForeColor = c;
            HexL.Text = c.ToArgb().ToString("X").Substring(2);
        }

        private void ColorSchemeCCC_SelectedColorChanged(object sender, EventArgs e) {
            selectedColor = ColorSchemeCCC.SelectedColor;
            UpdateColor(selectedColor);
        }

        private void ResetB_Click(object sender, EventArgs e) {
            selectedColor = Color.FromArgb(43, 87, 154);
            UpdateColor(selectedColor);
        }

        private void OKB_Click(object sender, EventArgs e) {
            Properties.Settings.Default.ColorScheme = selectedColor;
            Properties.Settings.Default.Save();
            StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, selectedColor);
            Close();
        }
    }
}