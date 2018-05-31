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
    public partial class Main : RibbonForm {

        public Main() {
            InitializeComponent();
            UserLI.Text = Properties.Settings.Default.LoginUsername;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
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
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void ExitBI_Click(object sender, EventArgs e) {
            Close();
        }

        private void LocationLI_DoubleClick(object sender, EventArgs e) {
            MaximizeBI_Click(sender, e);
        }

        private void Main_Load(object sender, EventArgs e) {
            Sales_Load();
            SalesProductSearchTB.Select();
            SalesProductSearchTB.Focus();
        }

        #region Sales definition
        
        public static double SalesTotalPrice = 0;
        DataTable SalesProductTable = new DataTable();
        DataTable SalesProductTableResult = new DataTable();
        DataTable SalesPendingTransaction = new DataTable();
        
        private void Sales_Load() {
            MySqlDataReader SalesProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
            SalesProductTable.Load(SalesProductReader);
            SalesProductTable.PrimaryKey = new DataColumn[] { SalesProductTable.Columns["product_id"] };
            SalesProductTableResult.PrimaryKey = new DataColumn[] { SalesProductTableResult.Columns["product_id"] };
            SalesProductTableResult.Columns.Add("product_id");
            SalesProductTableResult.Columns.Add("product_name");
            SalesProductTableResult.Columns.Add("product_price");
            SalesProductTableResult.Columns.Add("product_stock");
            SalesProductSeachResultDGV.DataSource                            = SalesProductTableResult;
            SalesProductSeachResultDGV.Columns["product_id"].AutoSizeMode    = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesProductSeachResultDGV.Columns["product_name"].AutoSizeMode  = DataGridViewAutoSizeColumnMode.Fill;
            SalesProductSeachResultDGV.Columns["product_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesProductSeachResultDGV.Columns["product_stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesPendingTransaction.PrimaryKey = new DataColumn[] { SalesPendingTransaction.Columns["product_id"] };
            SalesPendingTransaction.Columns.Add("product_id");
            SalesPendingTransaction.Columns.Add("product_name");
            SalesPendingTransaction.Columns.Add("product_price");
            SalesPendingTransaction.Columns.Add("product_disc_pct");
            SalesPendingTransaction.Columns.Add("transaction_qty");
            SalesCartDGV.DataSource                                   = SalesPendingTransaction;
            SalesCartDGV.Columns["product_id"].AutoSizeMode           = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesCartDGV.Columns["product_name"].AutoSizeMode         = DataGridViewAutoSizeColumnMode.Fill;
            SalesCartDGV.Columns["product_price"].AutoSizeMode        = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesCartDGV.Columns["product_disc_pct"].AutoSizeMode     = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesCartDGV.Columns["transaction_qty"].AutoSizeMode      = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesRefreshPrice();
        }

        private void SalesProductSearchTB_TextChanged(object sender, EventArgs e) {
            string[] SalesSearchTerms = DbConnect.EscapeLikeValue(SalesProductSearchTB.Text).Split(' ');
            for (int i = 0; i < SalesSearchTerms.Length; i++) SalesSearchTerms[i] = "(product_id + ' ' + product_name) LIKE '%" + SalesSearchTerms[i] + "%'";
            string[] SalesProductSeachResultColumns = new string[] { "product_id", "product_name", "product_price", "product_stock" };
            DataRow[] SalesProductSeachResultProductRows = new DataView(SalesProductTable).ToTable(false, SalesProductSeachResultColumns).Select(String.Join(" AND ", SalesSearchTerms));
            SalesProductTableResult.Rows.Clear();
            SalesProductSeachResultProductRows.CopyToDataTable(SalesProductTableResult, LoadOption.OverwriteChanges);
        }

        private void SalesProductSeachResultDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                string SelectedProductResultID = DbConnect.EscapeLikeValue(SalesProductSeachResultDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                int SelectedProductResultStock = int.Parse(DbConnect.EscapeLikeValue(SalesProductSeachResultDGV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString()));
                SalesPendingTransaction.PrimaryKey = new DataColumn[] { SalesPendingTransaction.Columns["product_id"] };
                DataRow SelectedProductRow = SalesPendingTransaction.Rows.Find(SelectedProductResultID);
                if (SelectedProductResultStock == 0) ToastNotification.Show(this, "Insuficient Stock");
                else {
                    if (SelectedProductRow == null) {
                        string[] ProductsColumn = new string[] { "product_id", "product_name", "product_price", "product_disc_pct" };
                        DataRow NewPendingProductRow = new DataView(SalesProductTable).ToTable(false, ProductsColumn).Select("product_id = '" + SelectedProductResultID + "'")[0];
                        SalesPendingTransaction.Rows.Add(NewPendingProductRow.ItemArray);
                        SelectedProductRow = SalesPendingTransaction.Rows.Find(SelectedProductResultID);
                        SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["transaction_qty"] = 1;
                    } else if (SelectedProductResultStock >= int.Parse(SelectedProductRow["transaction_qty"].ToString()) + 1) {
                        SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["transaction_qty"] =
                         int.Parse(SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["transaction_qty"].ToString()) + 1;
                    } else ToastNotification.Show(this, "Insuficient Stock");
                    SalesRefreshPrice();
                }
            } 
        }

        private void SalesCartDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int SelectedProductResultStock = int.Parse(DbConnect.EscapeLikeValue(SalesProductSeachResultDGV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString()));
            int.TryParse(SalesPendingTransaction.Rows[e.RowIndex]["transaction_qty"].ToString(), out int NewSelectedProductResultStock);
            SalesPendingTransaction.Rows[e.RowIndex]["transaction_qty"] = Math.Max(Math.Min(NewSelectedProductResultStock, SelectedProductResultStock), 0).ToString();
            if(int.Parse(SalesPendingTransaction.Rows[e.RowIndex]["transaction_qty"].ToString()) == 0) SalesPendingTransaction.Rows.RemoveAt(e.RowIndex);
            SalesRefreshPrice();
        }

        private double SalesRefreshPrice() {
            double subtotal = 0;
            foreach(DataRow dr in SalesPendingTransaction.Rows) {
                subtotal += double.Parse(dr["product_price"].ToString()) * double.Parse(dr["transaction_qty"].ToString())
                    * (String.IsNullOrEmpty(dr["product_disc_pct"].ToString())?1: ((100.0 - double.Parse(dr["product_disc_pct"].ToString())) / 100.0));
            }
            SalesSubtotalL.Text = String.Format("Rp {0:###,##0.00}", subtotal);
            SalesVATL.Text      = String.Format("Rp {0:###,##0.00}", subtotal * 0.1);
            SalesTotalL.Text    = String.Format("Rp {0:###,##0.00}", subtotal * 1.1);
            return subtotal * 1.1;
        }

        private void SalesCheckoutB_Click(object sender, EventArgs e) {
            SalesTotalPrice = SalesRefreshPrice();
            Opacity = .5;
            new Checkout().ShowDialog();
            Opacity = 1.0;
        }

        #endregion
    }
}