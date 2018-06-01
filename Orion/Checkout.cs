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

        private void Checkout_Load(object sender, EventArgs e) {
            String CheckoutDate = DateTime.Today.ToString("yyMMdd");
            MySqlDataReader CheckoutTransactionReader = new DbConnect().ExecQuery("SELECT * FROM transaction_header WHERE transaction_id LIKE 'O-INV-" + CheckoutDate + "%';");
            CheckoutTransactionTable.Load(CheckoutTransactionReader);
            int NextInvoiceNoBase10 = CheckoutTransactionTable.Rows.Count + 1;
            String InvoiceNoBase36 = ConvertToBase(NextInvoiceNoBase10, 36).PadLeft(8, '0');
            CheckoutInvoiceNoL.Text = String.Format("O-INV-" + CheckoutDate + InvoiceNoBase36);
            CheckoutPriceL.Text = String.Format("Rp {0:###,##0.00}", Main.SalesTotalPrice);
            RefreshPaymentAmount();
        }

        private void Checkout_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void CheckoutCancelB_Click(object sender, EventArgs e) {
            this.Hide();
        }

        public String ConvertToBase(int num, int nbase) {
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (nbase < 2 || nbase > chars.Length) return "";
            int r;
            String newNumber = "";
            while (num >= nbase) {
                r = num % nbase;
                newNumber = chars[r] + newNumber;
                num = num / nbase;
            }
            newNumber = chars[num] + newNumber;
            return newNumber;
        }

        public int ConvertFromBase(String num, int nbase) {
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (nbase < 2 || nbase > chars.Length) return 0;
            int newNumber=0;
            for (int i = 0; i < num.Length; i++) {
                newNumber *= nbase;
                newNumber += chars.IndexOf(num[i]);
            }
            return newNumber;
        }

        private decimal PaymentAmount = 0;

        private void CheckoutPaymentTB_KeyDown(object sender, KeyEventArgs e) {
            e.SuppressKeyPress = true;
            List<Keys> PaymentValidNumbers = new List<Keys>{ Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
            Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 };
            ToastNotification.Show(this, e.KeyValue.ToString() + " " + e.KeyCode.ToString() + " " + e.KeyData.ToString());
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
            CheckoutPaymentTB.Text = String.Format("Rp {0:###,##0.00}", PaymentAmount);
            CheckoutPaymentTB.Select(CheckoutPaymentTB.Text.Length, 0);
            RefreshChange();
        }

        private void RefreshChange() {
            CheckoutChangeL.Text = String.Format("Rp {0:###,##0.00}", PaymentAmount  - (decimal)Main.SalesTotalPrice);
        }
    }
}