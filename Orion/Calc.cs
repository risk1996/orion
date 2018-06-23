using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Orion {
    public partial class Calc : DevComponents.DotNetBar.Metro.MetroForm {
        public Calc() {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e) {
            StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Properties.Settings.Default.ColorScheme);
            Calculator.Focus();
        }
    }
}