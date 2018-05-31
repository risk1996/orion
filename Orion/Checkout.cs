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
            ToastNotification.Show(this, InvoiceNoBase36);
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
    }
}