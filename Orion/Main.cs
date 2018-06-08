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

        List<DevComponents.DotNetBar.Metro.MetroTileItem> MainAvailableMTIs = new List<DevComponents.DotNetBar.Metro.MetroTileItem>();

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
            DefineUserRole();
            LayoutControlFloat();
            if (MainAvailableMTIs[0] == SalesMTI) Sales_Load();
            else if (MainAvailableMTIs[0] == RestockMTI) Restock_Load();
            else if (MainAvailableMTIs[0] == ProductsMTI) ;
        }

        private void LayoutControlFloat() {
            SalesLC.Dock = DockStyle.Fill;
            RestockLC.Dock = DockStyle.Fill;
        }

        public void LayoutControlHide() {
            SalesLC.Visible = false;
            RestockLC.Visible = false;
        }

        private void DefineUserRole() {
            SalesMTI.Enabled = ReportMTI.Enabled = ProductsMTI.Enabled = EmployeesMTI.Enabled = ReportMTI.Enabled = false;
            if (Properties.Settings.Default.LoginRole == "SUPER") {
                MainAvailableMTIs.Add(SalesMTI);
                MainAvailableMTIs.Add(RestockMTI);
                MainAvailableMTIs.Add(ProductsMTI);
                MainAvailableMTIs.Add(EmployeesMTI);
                MainAvailableMTIs.Add(ReportMTI);
            } else if (Properties.Settings.Default.LoginRole == "MANAGER") {
                MainAvailableMTIs.Add(ProductsMTI);
                MainAvailableMTIs.Add(EmployeesMTI);
                MainAvailableMTIs.Add(ReportMTI);
            } else if (Properties.Settings.Default.LoginRole == "CLERK") {
                MainAvailableMTIs.Add(SalesMTI);
            } else if (Properties.Settings.Default.LoginRole == "WAREHOUSE") {
                MainAvailableMTIs.Add(RestockMTI);
                MainAvailableMTIs.Add(ProductsMTI);
            }
            foreach(DevComponents.DotNetBar.Metro.MetroTileItem MTI in MainAvailableMTIs) MTI.Enabled = true;
        }

        #region Sales definition

        public bool SalesLoaded = false;
        public static double SalesTotalPrice = 0;
        DataTable SalesProductTable = new DataTable();
        DataTable SalesProductTableResult = new DataTable();
        DataTable SalesPendingTransaction = new DataTable();

        private void SalesMTI_Click(object sender, EventArgs e) {
            Sales_Load();
        }

        private void Sales_Load() {
            LayoutControlHide();
            SalesLC.Visible = true;
            SalesLC_SizeChanged(new object(), new EventArgs());
            SalesRefreshPrice();
            SalesProductSearchTB.Select();
            SalesProductSearchTB.Focus();
            if (!SalesLoaded) Sales_LoadOnce();
        }

        private void Sales_LoadOnce() {
            MySqlDataReader SalesProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
            SalesProductTable.Load(SalesProductReader);
            SalesProductTableResult.Columns.Add("ID");
            SalesProductTableResult.Columns.Add("Name");
            SalesProductTableResult.Columns.Add("Price");
            SalesProductTableResult.Columns.Add("Stock");
            SalesProductTableResult.PrimaryKey = new DataColumn[] { SalesProductTableResult.Columns["ID"] };
            SalesProductSeachResultDGV.DataSource = SalesProductTableResult;
            SalesProductSeachResultDGV.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesProductSeachResultDGV.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SalesProductSeachResultDGV.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesProductSeachResultDGV.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesPendingTransaction.Columns.Add("ID");
            SalesPendingTransaction.Columns.Add("Name");
            SalesPendingTransaction.Columns.Add("Price");
            SalesPendingTransaction.Columns.Add("Disc");
            SalesPendingTransaction.Columns.Add("Qty");
            SalesPendingTransaction.PrimaryKey = new DataColumn[] { SalesPendingTransaction.Columns["ID"] };
            SalesCartDGV.DataSource = SalesPendingTransaction;
            SalesCartDGV.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesCartDGV.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SalesCartDGV.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesCartDGV.Columns["Disc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesCartDGV.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SalesLoaded = true;
        }

        private void SalesLC_SizeChanged(object sender, EventArgs e) {
            int SalesOtherComponentHeight = SalesProductSearchLCI.Height + SalesTotalLG.Height;
            SalesProductSearchResultLCI.Height = (int)((SalesLC.Height - SalesOtherComponentHeight) * 1 / 3.5);
            SalesCartLCI.Height = (int)((SalesLC.Height - SalesOtherComponentHeight) * 2.5 / 3.5);
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
                SalesPendingTransaction.PrimaryKey = new DataColumn[] { SalesPendingTransaction.Columns["ID"] };
                DataRow SelectedProductRow = SalesPendingTransaction.Rows.Find(SelectedProductResultID);
                if (SelectedProductResultStock == 0) ToastNotification.Show(this, "Insufficient Stock");
                else {
                    if (SelectedProductRow == null) {
                        string[] ProductsColumn = new string[] { "product_id", "product_name", "product_price", "product_disc_pct" };
                        DataRow NewPendingProductRow = new DataView(SalesProductTable).ToTable(false, ProductsColumn).Select("product_id = '" + SelectedProductResultID + "'")[0];
                        SalesPendingTransaction.Rows.Add(NewPendingProductRow.ItemArray);
                        SelectedProductRow = SalesPendingTransaction.Rows.Find(SelectedProductResultID);
                        SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Qty"] = 1;
                        SalesCartDGV.CurrentCell = SalesCartDGV.Rows[SalesCartDGV.Rows.Count - 1].Cells[4];
                        SalesCartDGV.BeginEdit(true);
                    } else if (SelectedProductResultStock >= int.Parse(SelectedProductRow["Qty"].ToString()) + 1) {
                        SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Qty"] =
                         int.Parse(SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Qty"].ToString()) + 1;
                    } else ToastNotification.Show(this, "Insufficient Stock");
                    SalesRefreshPrice();
                }
            } 
        }

        private void SalesCartDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int SelectedProductResultStock = int.Parse(SalesProductTable.Rows.Find(SalesCartDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString())["product_stock"].ToString());
            int.TryParse(SalesPendingTransaction.Rows[e.RowIndex]["Qty"].ToString(), out int NewSelectedProductResultStock);
            SalesPendingTransaction.Rows[e.RowIndex]["Qty"] = Math.Max(Math.Min(NewSelectedProductResultStock, SelectedProductResultStock), 0).ToString();
            if (int.Parse(SalesPendingTransaction.Rows[e.RowIndex]["Qty"].ToString()) == 0) SalesPendingTransaction.Rows.RemoveAt(e.RowIndex);
            SalesRefreshPrice();
        }

        private double SalesRefreshPrice() {
            double subtotal = 0;
            foreach(DataRow dr in SalesPendingTransaction.Rows) {
                subtotal += double.Parse(dr["Price"].ToString()) * double.Parse(dr["Qty"].ToString())
                    * (String.IsNullOrEmpty(dr["Disc"].ToString())?1: ((100.0 - double.Parse(dr["Disc"].ToString())) / 100.0));
            }
            SalesSubtotalL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", subtotal);
            SalesVATL.Text      = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", subtotal * 0.1);
            SalesTotalL.Text    = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", subtotal * 1.1);
            return subtotal * 1.1;
        }

        private void SalesClearCartBI_Click(object sender, EventArgs e) {
            SalesPendingTransaction.Clear();
            SalesRefreshPrice();
        }

        private void SalesCheckoutB_Click(object sender, EventArgs e) {
            using (var Checkout = new Checkout()) {
                SalesTotalPrice = SalesRefreshPrice();
                Opacity = .5;
                var result = Checkout.ShowDialog();
                if (result == DialogResult.OK) {
                    string salesTransactionId = Checkout.transaction_id;
                    foreach (DataRow dr in SalesPendingTransaction.Rows) {
                        MySqlDataReader SalesTransactionDetailReader = new DbConnect().ExecQuery("INSERT transaction_detail (transaction_id, product_id, transaction_qty, transaction_discount) " +
                    "VALUES ('" + salesTransactionId + "', '" + dr["ID"].ToString() + "', '" + dr["Qty"].ToString() + "', '" + dr["Disc"].ToString() + "');");
                        MySqlDataReader ProductStockUpdateReader = new DbConnect().ExecQuery("UPDATE product SET product_stock = product_stock - " + dr["Qty"] + " WHERE product_id = '" + dr["ID"].ToString() + "'");
                    }
                    MySqlDataReader SalesProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
                    SalesProductTable.Load(SalesProductReader);
                    SalesProductSeachResultDGV.DataSource = SalesProductTableResult;
                    SalesProductTableResult.Clear();
                    SalesProductSearchTB.Clear();
                    Opacity = 1.0;
                    SalesClearCartBI_Click(sender, e);
                }
            }
        }

        #endregion

        #region Restock definition

        public bool RestockLoaded = false;
        DataTable RestockProductTable = new DataTable();
        DataTable RestockProductTableResult = new DataTable();
        DataTable RestockPendingChanges = new DataTable();

        private void RestockMTI_Click(object sender, EventArgs e) {
            Restock_Load();
        }

        private void Restock_Load() {
            LayoutControlHide();
            RestockLC.Visible = true;
            RestockLC_SizeChanged(new object(), new EventArgs());
            RestockProductSearchTB.Select();
            RestockProductSearchTB.Focus();
            if (!RestockLoaded) Restock_LoadOnce();
        }

        private void Restock_LoadOnce() {
            MySqlDataReader RestockProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
            RestockProductTable.Load(RestockProductReader);
            RestockProductTableResult.Columns.Add("ID");
            RestockProductTableResult.Columns.Add("Name");
            RestockProductTableResult.Columns.Add("Stock");
            RestockProductTableResult.PrimaryKey = new DataColumn[] { RestockProductTableResult.Columns["ID"] };
            RestockProductSeachResultDGV.DataSource = RestockProductTableResult;
            RestockProductSeachResultDGV.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RestockProductSeachResultDGV.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RestockProductSeachResultDGV.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RestockPendingChanges.Columns.Add("ID");
            RestockPendingChanges.Columns.Add("Name");
            RestockPendingChanges.Columns.Add("Qty");
            RestockPendingChanges.PrimaryKey = new DataColumn[] { RestockPendingChanges.Columns["ID"] };
            RestockPendingChangesDGV.DataSource = RestockPendingChanges;
            RestockPendingChangesDGV.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RestockPendingChangesDGV.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RestockPendingChangesDGV.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RestockLoaded = true;
        }

        private void RestockLC_SizeChanged(object sender, EventArgs e) {
            int RestockOtherComponentHeight = RestockProductSearchLCI.Height + RestockCommitLCI.Height;
            RestockProductSeachResultLCI.Height = (int)((RestockLC.Height - RestockOtherComponentHeight) * 1 / 3.5);
            RestockPendingChangesLCI.Height = (int)((RestockLC.Height - RestockOtherComponentHeight) * 2.5 / 3.5);
        }

        private void RestockProductSearchTB_TextChanged(object sender, EventArgs e) {
            string[] RestockSearchTerms = DbConnect.EscapeLikeValue(RestockProductSearchTB.Text).Split(' ');
            for (int i = 0; i < RestockSearchTerms.Length; i++) RestockSearchTerms[i] = "(product_id + ' ' + product_name) LIKE '%" + RestockSearchTerms[i] + "%'";
            string[] RestockProductSeachResultColumns = new string[] { "product_id", "product_name", "product_stock" };
            DataRow[] RestockProductSeachResultProductRows = new DataView(RestockProductTable).ToTable(false, RestockProductSeachResultColumns).Select(String.Join(" AND ", RestockSearchTerms));
            RestockProductTableResult.Rows.Clear();
            RestockProductSeachResultProductRows.CopyToDataTable(RestockProductTableResult, LoadOption.OverwriteChanges);
        }

        private void RestockProductSeachResultDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                string SelectedProductResultID = DbConnect.EscapeLikeValue(RestockProductSeachResultDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                RestockPendingChanges.PrimaryKey = new DataColumn[] { RestockPendingChanges.Columns["ID"] };
                DataRow SelectedProductRow = RestockPendingChanges.Rows.Find(SelectedProductResultID);
                if (SelectedProductRow == null) {
                    string[] ProductsColumn = new string[] { "product_id", "product_name", "product_disc_pct" };
                    DataRow NewPendingProductRow = new DataView(RestockProductTable).ToTable(false, ProductsColumn).Select("product_id = '" + SelectedProductResultID + "'")[0];
                    RestockPendingChanges.Rows.Add(NewPendingProductRow.ItemArray);
                    SelectedProductRow = RestockPendingChanges.Rows.Find(SelectedProductResultID);
                    RestockPendingChanges.Rows[RestockPendingChanges.Rows.IndexOf(SelectedProductRow)]["Qty"] = 1;
                    RestockPendingChangesDGV.CurrentCell = RestockPendingChangesDGV.Rows[RestockPendingChangesDGV.Rows.Count - 1].Cells[2];
                    RestockPendingChangesDGV.BeginEdit(true);
                } else ToastNotification.Show(this, "Product Exists on Pending Changes.");
            }
        }

        private void RestockPendingChangesDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int.TryParse(RestockPendingChanges.Rows[e.RowIndex]["Qty"].ToString(), out int NewSelectedProductResultStock);
            RestockPendingChanges.Rows[e.RowIndex]["Qty"] = Math.Max(NewSelectedProductResultStock, 0).ToString();
            if (int.Parse(RestockPendingChanges.Rows[e.RowIndex]["Qty"].ToString()) == 0) RestockPendingChanges.Rows.RemoveAt(e.RowIndex);
        }

        #endregion
    }
}