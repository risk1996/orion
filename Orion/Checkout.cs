using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Orion {
    public partial class Checkout : DevComponents.DotNetBar.Metro.MetroForm {
        public Checkout() {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e) {
            CheckoutPriceL.Text = String.Format("Rp {0:###,##0.00}", Main.SalesTotalPrice);
        }

        private void Checkout_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void CheckoutCancelB_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}