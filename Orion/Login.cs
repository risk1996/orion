using System;
using System.Security.Cryptography;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace Orion {
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm {
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            ProgressCP.IsRunning = true;
            if (Properties.Settings.Default.LoginRemember) {
                UsernameTB.Text = Properties.Settings.Default.LoginUsername;
                RememberCB.Checked = Properties.Settings.Default.LoginRemember;
                PasswordTB.Select();
                PasswordTB.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.LoginUsername = UsernameTB.Text;
            Properties.Settings.Default.LoginRemember = RememberCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void LoginB_Click(object sender, EventArgs e) {
            ProgressCP.Visible = true;
            MySqlDataReader emp = new DbConnect().ExecQuery("SELECT * FROM employee WHERE employee_uname = '" + UsernameTB.Text + "';");
            if (emp.HasRows) {
                SHA512 sha512 = new SHA512Managed();
                emp.Read();
                string salt = emp.GetString("employee_salt");
                string hashedPass = BitConverter.ToString(sha512.ComputeHash(Encoding.ASCII.GetBytes(PasswordTB.Text + salt))).Replace("-", "").ToLower();
                if (hashedPass == emp.GetString("employee_password")) {
                    Properties.Settings.Default.LoginEmployeeID = int.Parse(emp.GetString("employee_id"));
                    Properties.Settings.Default.Save();
                    new Main().Show();
                    Close();
                    //new Thread(() => {
                    //    Thread.CurrentThread.IsBackground = true;
                    //    Main main = new Main();
                    //    Invoke((MethodInvoker)delegate { main.Show(); Close(); });
                    //}).Start();
                } else ToastNotification.Show(this, "Invalid login credentials");
            } else ToastNotification.Show(this, "Invalid login credentials");
            ProgressCP.Visible = false;
        }

        private void UsernameTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) LoginB_Click(sender, e);
        }

        private void PasswordTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) LoginB_Click(sender, e);
        }
    }
}