using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Orion {
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm {
        public Login() {
            InitializeComponent();
        }

        private void LoginB_Click(object sender, EventArgs e) {
            Main main = new Main();
            main.Show();
            Close();
        }
    }
}