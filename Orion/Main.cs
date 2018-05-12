using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Orion {
    public partial class Main : DevComponents.DotNetBar.RibbonForm {
        public Main() {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void LocationLI_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CalcBI_Click(object sender, EventArgs e) {
            new Calc().Show();
        }

        private void SettingsBI_Click(object sender, EventArgs e) {

        }

        private void AboutBI_Click(object sender, EventArgs e) {

        }

        private void MinimizeBI_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeBI_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;
        }

        private void ExitBI_Click(object sender, EventArgs e) {
            Close();
        }

        private void LocationLI_DoubleClick(object sender, EventArgs e) {
            WindowState = (WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Main_Resize(object sender, EventArgs e) {
            ItemSearchLCI.Width = SalesLC.Width - AddLCI.Width - 1;
        }
    }
}