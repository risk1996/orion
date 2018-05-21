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
            //DataTable dt = employeeTableAdapter.GetData();
            MySqlDataReader emp = new DbConnect().ExecQuery("SELECT * FROM employee WHERE employee_uname = '" + PasswordTB.Text + "'");
            //DataRow[] dr = dt.Select("employee_uname = '" + UsernameTB.Text + "'");
            ToastNotification.Show(this, emp.FieldCount.ToString());
            //if (dr.Length > 0) {
            //    SHA512 sha512 = new SHA512Managed();
            //    String salt = dr[0]["employee_salt"].ToString();
            //    String hashedPass = BitConverter.ToString(sha512.ComputeHash(Encoding.ASCII.GetBytes(PasswordTB.Text + salt))).Replace("-", "").ToLower();
            //    if (hashedPass == dr[0]["employee_password"].ToString()) {
            //        Properties.Settings.Default.LoginEmployeeID = int.Parse(dr[0]["employee_id"].ToString());
            //        Properties.Settings.Default.Save();
            //        ProgressCP.Visible = true;
            //        new Thread(() => {
            //            Thread.CurrentThread.IsBackground = true;
            //            Main main = new Main();
            //            Invoke((MethodInvoker)delegate { main.Show(); Close(); });
            //        }).Start();
            //    }
            //} else {
            //    ToastNotification.Show(this, "Invalid login credentials");
            //}
        }

        private void UsernameTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) LoginB_Click(sender, e);
        }

        private void PasswordTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) LoginB_Click(sender, e);
        }
    }
}