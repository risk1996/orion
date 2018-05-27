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
    public partial class Main : DevComponents.DotNetBar.RibbonForm {
        DataTable pendingTransaction = new DataTable();
        DataTable productTable = new DataTable();

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            MySqlDataReader productReader = new DbConnect().ExecQuery("SELECT product_id, product_name, product_price FROM product;");
            productTable.Load(productReader);
            pendingTransaction.Columns.Add("product_id");
            pendingTransaction.Columns.Add("product_name");
            pendingTransaction.Columns.Add("transaction_qty");
            pendingTransaction.Columns.Add("transaction_discount");
        }

        private void Main_Resize(object sender, EventArgs e) {
            ItemSearchLCI.Width = SalesLC.Width - AddLCI.Width - 1;
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

        private void ItemSearchTB_TextChanged(object sender, EventArgs e) {
            string[] terms = DbConnect.EscapeLikeValue(ItemSearchTB.Text).Split(' ');
            for (int i = 0; i < terms.Length; i++) terms[i] = "(product_id + ' ' + product_name) LIKE '%" + terms[i] + "%'";
            DataRow[] productRows = productTable.Select(String.Join(" AND ", terms));
            DataTable productTableResult = productTable.Clone();
            productRows.CopyToDataTable(productTableResult, LoadOption.OverwriteChanges);
            ItemSeachResultDGV.DataSource = productTableResult;
            ItemSeachResultDGV.Columns["product_id"].AutoSizeMode    = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ItemSeachResultDGV.Columns["product_name"].AutoSizeMode  = DataGridViewAutoSizeColumnMode.Fill;
            ItemSeachResultDGV.Columns["product_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}