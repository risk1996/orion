using System;
using System.Threading;
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
            ProgressCP.Visible = true;
            new Thread(() => {
                Thread.CurrentThread.IsBackground = true;
                Main main = new Main();
                Invoke((MethodInvoker)delegate { main.Show(); Close(); });
            }).Start();
        }

        private void Login_Load(object sender, EventArgs e) {
            ProgressCP.IsRunning = true;
        }
    }
}