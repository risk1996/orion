using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace Orion {
    public partial class Checkout : DevComponents.DotNetBar.Metro.MetroForm {
        public Checkout() {
            InitializeComponent();
        }

        DataTable CheckoutTransactionTable = new DataTable();
        public string Transaction_id { get; set; }

        private void Checkout_Load(object sender, EventArgs e) {
            StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Properties.Settings.Default.ColorScheme);
            SelectedH.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Custom;
            SelectedH.CustomHighlightColors = new Color[] { Properties.Settings.Default.ColorScheme, Properties.Settings.Default.ColorScheme, Properties.Settings.Default.ColorScheme };
            String CheckoutDate = DateTime.Today.ToString("yyMMdd");
            MySqlDataReader CheckoutTransactionReader = new DbConnect().ExecQuery("SELECT * FROM transaction_header WHERE transaction_id LIKE 'O-INV-" + CheckoutDate + "%';");
            CheckoutTransactionTable.Load(CheckoutTransactionReader);
            int NextInvoiceNoBase10 = CheckoutTransactionTable.Rows.Count + 1;
            String InvoiceNoBase36 = DbConnect.ConvertToBase(NextInvoiceNoBase10, 36).PadLeft(8, '0');
            CheckoutInvoiceNoL.Text = String.Format("O-INV-" + CheckoutDate + InvoiceNoBase36);
            CheckoutPriceL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", Main.SalesTotalPrice);
            CheckoutTransactionMethodCB.Items.Add("Cash");
            CheckoutTransactionMethodCB.Items.Add("Debit");
            CheckoutTransactionMethodCB.Items.Add("Credit");
            CheckoutTransactionMethodCB.SelectedIndex = 0;
            RefreshPaymentAmount();
        }

        private void CheckoutTransactionMethodCB_SelectedIndexChanged(object sender, EventArgs e) {
            if (CheckoutTransactionMethodCB.SelectedIndex == 0) {
                PaymentAmount = 0;
                CheckoutPaymentTB.Enabled = true;
            } else {
                PaymentAmount = (decimal)Main.SalesTotalPrice;
                CheckoutPaymentTB.Enabled = false;
            }
            RefreshPaymentAmount();
        }

        private decimal PaymentAmount = 0;

        private void CheckoutPaymentTB_KeyDown(object sender, KeyEventArgs e) {
            e.SuppressKeyPress = true;
            List<Keys> PaymentValidNumbers = new List<Keys>{ Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
            Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 };
            if (PaymentValidNumbers.Contains(e.KeyCode) && PaymentAmount < 100000000000) {
                PaymentAmount *= 10;
                PaymentAmount += (decimal)(PaymentValidNumbers.IndexOf(e.KeyCode) % 10) / 100;
            } else if (e.KeyCode == Keys.Back) {
                PaymentAmount -= decimal.Remainder(PaymentAmount, 0.1M);
                PaymentAmount /= 10;
            } else if (e.KeyCode == Keys.Escape) PaymentAmount = 0;
            RefreshPaymentAmount();
        }

        private void RefreshPaymentAmount() {
            CheckoutPaymentTB.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", PaymentAmount);
            CheckoutPaymentTB.Select(CheckoutPaymentTB.Text.Length, 0);
            RefreshChange();
        }

        private void RefreshChange() {
            CheckoutChangeL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", PaymentAmount  - (decimal)Main.SalesTotalPrice);
            if (PaymentAmount - (decimal)Main.SalesTotalPrice < 0) {
                CheckoutChangeL.ForeColor = Color.Red;
                CheckoutConfirmB.Enabled = false;
            } else {
                CheckoutChangeL.ForeColor = Color.Black;
                CheckoutConfirmB.Enabled = true;
            }
        }

        private void CheckoutCancelB_Click(object sender, EventArgs e) {
            if (CheckoutConfirmB.Text == "Confirm Checkout") Close();
            else CheckoutConfirmB.Text = "Confirm Checkout";
            LockPayment();
        }

        private void CheckoutConfirmB_Click(object sender, EventArgs e) {
            if(CheckoutConfirmB.Text == "Confirm Checkout") {
                CheckoutConfirmB.Text = "Confirm Payment";
                LockPayment();
            } else {
                String TimeStamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                int SalesProductReader = new DbConnect().ExecNonQuery("INSERT transaction_header (transaction_id, transaction_timestamp, employee_id, transaction_method) " +
                    "VALUES ('" + CheckoutInvoiceNoL.Text.ToString() + "', '" + TimeStamp + "', '" + Properties.Settings.Default.LoginEmployeeID + "', '" 
                    + CheckoutTransactionMethodCB.Text + "');");
                Transaction_id = CheckoutInvoiceNoL.Text.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void LockPayment() {
            CheckoutTransactionMethodCB.Enabled = CheckoutConfirmB.Text == "Confirm Checkout";
            CheckoutPaymentTB.Enabled = CheckoutTransactionMethodCB.SelectedIndex==0 && CheckoutConfirmB.Text == "Confirm Checkout";
        }
    }
}