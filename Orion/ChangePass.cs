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
using System.Text.RegularExpressions;

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
            NewPasswordTB_TextChanged(sender, e);
        }

        private void OKB_Click(object sender, EventArgs e) {
            SHA512 sha512 = new SHA512Managed();
            string oldPassword = BitConverter.ToString(sha512.ComputeHash(Encoding.ASCII.GetBytes(OldPasswordTB.Text + Salt))).Replace("-", "").ToLower();
            if (oldPassword == HashedPass) {
                if (NewPasswordTB.Text == ConfirmPasswordTB.Text) {
                    if (CalculatePasswordStrength(NewPasswordTB.Text) > 40) {
                        string newSalt = DbConnect.SaltGenerator();
                        string newPassword = BitConverter.ToString(sha512.ComputeHash(Encoding.ASCII.GetBytes(NewPasswordTB.Text + newSalt))).Replace("-", "").ToLower();
                        new DbConnect().ExecNonQuery("UPDATE employee SET employee_password = '" + newPassword + "', employee_salt = '" + newSalt + "' WHERE employee_id = " + Properties.Settings.Default.LoginEmployeeID.ToString() + ";");
                        Close();
                    } else ToastNotification.Show(this, "New password is too weak");
                } else ToastNotification.Show(this, "New password does not match");
            } else ToastNotification.Show(this, "Invalid old password");
        }

        private void NewPasswordTB_TextChanged(object sender, EventArgs e) {
            double complexity = CalculatePasswordStrength(NewPasswordTB.Text);
            int percentage = (int)Math.Min(complexity, 100);
            PasswordComplexityPB.Value = percentage;
            PasswordComplexityL.Text = "Password Strength: ";
            if (complexity <= 30) PasswordComplexityL.Text += "Very Weak";
            else if (complexity <= 40) PasswordComplexityL.Text += "Weak";
            else if (complexity <= 50) PasswordComplexityL.Text += "Moderate";
            else if (complexity <= 60) PasswordComplexityL.Text += "Good";
            else if (complexity <= 70) PasswordComplexityL.Text += "Strong";
            else PasswordComplexityL.Text += "Very Strong";
        }

        private double CalculatePasswordStrength(string pass) {
            int search_space = 1;
            if (Regex.IsMatch(pass, "[A-Z]")) search_space += 26;
            if (Regex.IsMatch(pass, "[a-z]")) search_space += 26;
            if (Regex.IsMatch(pass, "[0-9]")) search_space += 10;
            if (Regex.IsMatch(pass, "!@#$£%^&*()-_{}|\\;:'\",./<>?`~=+")) search_space += 30;
            return Math.Log(search_space, 2f) * Math.Pow(pass.Length, 0.8);
        }
    }
}