using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Orion {
    public partial class ChangePass : DevComponents.DotNetBar.Metro.MetroForm {
        private string HashedPass = "";
        private string Salt = "";

        public ChangePass() {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e) {
            StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Properties.Settings.Default.ColorScheme);
            SelectedH.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Custom;
            SelectedH.CustomHighlightColors = new Color[] { Properties.Settings.Default.ColorScheme, Properties.Settings.Default.ColorScheme, Properties.Settings.Default.ColorScheme };
            MySqlDataReader reader = new DbConnect().ExecQuery("SELECT * FROM employee WHERE employee_id = " + Properties.Settings.Default.LoginEmployeeID.ToString() + ";");
            reader.Read();
            UsernameL.Text = reader["employee_uname"].ToString();
            InfoL.Text = reader["employee_fname"].ToString() + " " + reader["employee_lname"].ToString() + "\n" + reader["employee_email"].ToString() + "\n(Since: " + reader["employee_hire_date"].ToString() + ")";
            HashedPass = reader["employee_password"].ToString();
            Salt = reader["employee_salt"].ToString();
        }

        private void CancelB_Click(object sender, EventArgs e) {
            Close();
        }

        private void OKB_Click(object sender, EventArgs e) {
            SHA512 sha512 = new SHA512Managed();
            string oldPassword = BitConverter.ToString(sha512.ComputeHash(Encoding.ASCII.GetBytes(OldPasswordTB.Text + Salt))).Replace("-", "").ToLower();
            if (oldPassword == HashedPass) {
                if (NewPasswordTB.Text == ConfirmPasswordTB.Text) {
                    string newSalt = DbConnect.SaltGenerator();
                    string newPassword = BitConverter.ToString(sha512.ComputeHash(Encoding.ASCII.GetBytes(NewPasswordTB.Text + newSalt))).Replace("-", "").ToLower();
                    new DbConnect().ExecNonQuery("UPDATE employee SET employee_password = '" + newPassword + "', employee_salt = '" + newSalt + "' WHERE employee_id = " + Properties.Settings.Default.LoginEmployeeID.ToString() + ";");
                } else ToastNotification.Show(this, "New password does not match");
            } else ToastNotification.Show(this, "Invalid old password");
        }
    }
}