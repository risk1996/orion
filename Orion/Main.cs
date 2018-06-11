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
        DataTable ProductViewTable = new DataTable();

        public Main() {
            InitializeComponent();
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

        private void LogoutBI_Click(object sender, EventArgs e) {
            new Login().Show();
            Close();
        }

        private void LocationLI_DoubleClick(object sender, EventArgs e) {
            MaximizeBI_Click(sender, e);
        }

        private void Main_Load(object sender, EventArgs e) {
            UserLI.Text = Properties.Settings.Default.LoginUsername;
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
            SalesMTI.Enabled = RestockMTI.Enabled = ReportMTI.Enabled = ProductsMTI.Enabled = EmployeesMTI.Enabled = ReportMTI.Enabled = false;
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
        DataTable SalesProductViewTableResult = new DataTable();
        DataTable SalesPendingTransaction = new DataTable();

        private void SalesMTI_Click(object sender, EventArgs e) {
            Sales_Load();
        }

        private void Sales_Load() {
            LayoutControlHide();
            SalesLC.Visible = true;
            SalesLC_SizeChanged(new object(), new EventArgs());
            SalesCartDGV_RowsAdded(new object(), new DataGridViewRowsAddedEventArgs(0, 0));
            SalesRefreshPrice();
            SalesProductSearchTB.Select();
            SalesProductSearchTB.Focus();
            if (!SalesLoaded) Sales_LoadOnce();
        }

        private void Sales_LoadOnce() {
            MySqlDataReader SalesProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
            ProductViewTable.Load(SalesProductReader);
            ProductViewTable.PrimaryKey = new DataColumn[] { ProductViewTable.Columns["product_id"] };
            SalesProductViewTableResult.Columns.Add("ID");
            SalesProductViewTableResult.Columns.Add("Name");
            SalesProductViewTableResult.Columns.Add("Price");
            SalesProductViewTableResult.Columns.Add("Stock");
            SalesProductViewTableResult.PrimaryKey = new DataColumn[] { SalesProductViewTableResult.Columns["ID"] };
            SalesProductSeachResultDGV.DataSource = SalesProductViewTableResult;
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
            SalesCartDGV.Columns["ID"].ReadOnly = true;
            SalesCartDGV.Columns["Name"].ReadOnly = true;
            SalesCartDGV.Columns["Price"].ReadOnly = true;
            SalesCartDGV.Columns["Disc"].ReadOnly = true;
            SalesLoaded = true;
        }

        private void SalesLC_SizeChanged(object sender, EventArgs e) {
            int SalesOtherComponentHeight = SalesProductSearchLCI.Height + SalesTotalLG.Height;
            SalesProductSearchResultLCI.Height = (int)((SalesLC.Height - SalesOtherComponentHeight) * 1 / 3.5);
            SalesCartLCI.Height = (int)((SalesLC.Height - SalesOtherComponentHeight) * 2.5 / 3.5);
        }

        private void SalesProductSearchTB_TextChanged(object sender, EventArgs e) {
            if (SalesProductSearchTB.Text == "") {
                SalesProductViewTableResult.Clear();
            } else {
                string[] SalesSearchTerms = DbConnect.EscapeLikeValue(SalesProductSearchTB.Text).Split(' ');
                for (int i = 0; i < SalesSearchTerms.Length; i++) SalesSearchTerms[i] = "(product_id + ' ' + product_name) LIKE '%" + SalesSearchTerms[i] + "%'";
                string[] SalesProductSeachResultColumns = new string[] { "product_id", "product_name", "product_price", "product_stock" };
                DataRow[] SalesProductSeachResultProductRows = new DataView(ProductViewTable).ToTable(false, SalesProductSeachResultColumns).Select(String.Join(" AND ", SalesSearchTerms));
                SalesProductViewTableResult.Rows.Clear();
                SalesProductSeachResultProductRows.CopyToDataTable(SalesProductViewTableResult, LoadOption.OverwriteChanges);
            }
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
                        DataRow NewPendingProductRow = new DataView(ProductViewTable).ToTable(false, ProductsColumn).Select("product_id = '" + SelectedProductResultID + "'")[0];
                        SalesPendingTransaction.Rows.Add(NewPendingProductRow.ItemArray);
                        SelectedProductRow = SalesPendingTransaction.Rows.Find(SelectedProductResultID);
                        if(SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Disc"].ToString()=="") SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Disc"] = 0;
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
            int SelectedProductResultStock = int.Parse(ProductViewTable.Rows.Find(SalesCartDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString())["product_stock"].ToString());
            int.TryParse(SalesPendingTransaction.Rows[e.RowIndex]["Qty"].ToString(), out int NewSelectedProductResultStock);
            SalesPendingTransaction.Rows[e.RowIndex]["Qty"] = Math.Max(Math.Min(NewSelectedProductResultStock, SelectedProductResultStock), 0).ToString();
            if (int.Parse(SalesPendingTransaction.Rows[e.RowIndex]["Qty"].ToString()) == 0) SalesPendingTransaction.Rows.RemoveAt(e.RowIndex);
            SalesCartDGV_RowsAdded(sender, new DataGridViewRowsAddedEventArgs(0, 0));
            SalesRefreshPrice();
        }

        private void SalesCartDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            SalesCheckoutB.Enabled = SalesPendingTransaction.Rows.Count > 0;
        }

        private double SalesRefreshPrice() {
            double subtotal = 0, vat, total;
            foreach(DataRow dr in SalesPendingTransaction.Rows) {
                subtotal += double.Parse(dr["Price"].ToString()) * double.Parse(dr["Qty"].ToString())
                    * (String.IsNullOrEmpty(dr["Disc"].ToString())?1: ((100.0 - double.Parse(dr["Disc"].ToString())) / 100.0));
            }
            SalesSubtotalL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", subtotal);
            total = Math.Ceiling(subtotal * 1.1 / 500) * 500;
            vat = total - subtotal;
            SalesVATL.Text      = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", vat);
            SalesTotalL.Text    = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", total);
            return total;
        }

        private void SalesClearCartBI_Click(object sender, EventArgs e) {
            SalesPendingTransaction.Clear();
            SalesRefreshPrice();
        }

        private void SalesCheckoutB_Click(object sender, EventArgs e) {
            using (var Checkout = new Checkout()) {
                SalesTotalPrice = SalesRefreshPrice();
                Opacity = .5;
                if (Checkout.ShowDialog() == DialogResult.OK) {
                    string salesTransactionId = Checkout.transaction_id;
                    String TimeStamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    foreach (DataRow dr in SalesPendingTransaction.Rows) {
                        new DbConnect().ExecNonQuery("INSERT transaction_detail (transaction_id, product_id, transaction_qty, transaction_discount) " +
                            "VALUES ('" + salesTransactionId + "', '" + dr["ID"].ToString() + "', '" + dr["Qty"].ToString() + "', '" + dr["Disc"].ToString() + "');");
                        new DbConnect().ExecNonQuery("UPDATE product SET product_stock = product_stock - " + dr["Qty"] + " WHERE product_id = '" + dr["ID"].ToString() + "';");
                        new DbConnect().ExecNonQuery("INSERT product_stock_history(product_id, employee_id, product_stock_history_timestamp, product_stock_history_qty) " +
                            "VALUES ('" + dr["ID"].ToString() + "', '" + Properties.Settings.Default.LoginEmployeeID + "', '" + TimeStamp + "', '-" + dr["Qty"].ToString() + "');");
                    }
                    MySqlDataReader SalesProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
                    ProductViewTable.Load(SalesProductReader);
                    SalesProductViewTableResult.Clear();
                    SalesProductSearchTB.Clear();
                    SalesClearCartBI_Click(sender, e);
                }
                Opacity = 1.0;
            }
        }

        #endregion

        #region Restock definition

        public bool RestockLoaded = false;
        DataTable RestockProductViewTableResult = new DataTable();
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
            RestockPendingChangesDGV_RowsAdded(new object(), new DataGridViewRowsAddedEventArgs(0, 0));
        }

        private void Restock_LoadOnce() {
            MySqlDataReader RestockProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
            ProductViewTable.Load(RestockProductReader);
            RestockProductViewTableResult.Columns.Add("ID");
            RestockProductViewTableResult.Columns.Add("Name");
            RestockProductViewTableResult.Columns.Add("Stock");
            RestockProductViewTableResult.PrimaryKey = new DataColumn[] { RestockProductViewTableResult.Columns["ID"] };
            RestockProductSeachResultDGV.DataSource = RestockProductViewTableResult;
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
            RestockPendingChangesDGV.Columns["ID"].ReadOnly = true;
            RestockPendingChangesDGV.Columns["Name"].ReadOnly = true;
            RestockLoaded = true;
        }

        private void RestockLC_SizeChanged(object sender, EventArgs e) {
            int RestockOtherComponentHeight = RestockProductSearchLCI.Height + RestockCommitLCI.Height;
            RestockProductSeachResultLCI.Height = (int)((RestockLC.Height - RestockOtherComponentHeight) * 1 / 3.5);
            RestockPendingChangesLCI.Height = (int)((RestockLC.Height - RestockOtherComponentHeight) * 2.5 / 3.5);
        }

        private void RestockProductSearchTB_TextChanged(object sender, EventArgs e) {
            if (RestockProductSearchTB.Text == "") {
                RestockProductViewTableResult.Clear();
            } else {
                string[] RestockSearchTerms = DbConnect.EscapeLikeValue(RestockProductSearchTB.Text).Split(' ');
                for (int i = 0; i < RestockSearchTerms.Length; i++) RestockSearchTerms[i] = "(product_id + ' ' + product_name) LIKE '%" + RestockSearchTerms[i] + "%'";
                string[] RestockProductSeachResultColumns = new string[] { "product_id", "product_name", "product_stock" };
                DataRow[] RestockProductSeachResultProductRows = new DataView(ProductViewTable).ToTable(false, RestockProductSeachResultColumns).Select(String.Join(" AND ", RestockSearchTerms));
                RestockProductViewTableResult.Rows.Clear();
                RestockProductSeachResultProductRows.CopyToDataTable(RestockProductViewTableResult, LoadOption.OverwriteChanges);
            }
        }

        private void RestockProductSeachResultDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                string SelectedProductResultID = DbConnect.EscapeLikeValue(RestockProductSeachResultDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                RestockPendingChanges.PrimaryKey = new DataColumn[] { RestockPendingChanges.Columns["ID"] };
                DataRow SelectedProductRow = RestockPendingChanges.Rows.Find(SelectedProductResultID);
                if (SelectedProductRow == null) {
                    string[] ProductsColumn = new string[] { "product_id", "product_name", "product_disc_pct" };
                    DataRow NewPendingProductRow = new DataView(ProductViewTable).ToTable(false, ProductsColumn).Select("product_id = '" + SelectedProductResultID + "'")[0];
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
            RestockPendingChangesDGV_RowsAdded(sender, new DataGridViewRowsAddedEventArgs(0, 0));
        }

        private void RestockPendingChangesDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            RestockCommitB.Enabled = RestockPendingChanges.Rows.Count > 0;
            RestockCancelB.Enabled = RestockPendingChanges.Rows.Count > 0;
        }

        private void RestockCancelB_Click(object sender, EventArgs e) {
            if (RestockCancelB.Text == "Clear Changes") {
                RestockPendingChanges.Clear();
                RestockPendingChangesDGV_RowsAdded(sender, new DataGridViewRowsAddedEventArgs(0, 0));
            } else {
                RestockCommitB.Text = "OK";
                RestockCancelB.Text = "Clear Changes";
                RestockProductSeachResultDGV.Enabled = true;
                RestockProductSearchTB.Enabled = true;
            }
        }

        private void RestockCommitB_Click(object sender, EventArgs e) {
            if (RestockCommitB.Text == "OK") {
                RestockCommitB.Text = "Commit Changes";
                RestockCancelB.Text = "Cancel";
                LockRestock();
            } else {
                String TimeStamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                foreach (DataRow dr in RestockPendingChanges.Rows) {
                    new DbConnect().ExecNonQuery("UPDATE product SET product_stock = product_stock + " + dr["Qty"] + " WHERE product_id = '" + dr["ID"].ToString() + "';");
                    new DbConnect().ExecNonQuery("INSERT product_stock_history(product_id, employee_id, product_stock_history_timestamp, product_stock_history_qty) " +
                        "VALUES ('" + dr["ID"].ToString() + "', '" + Properties.Settings.Default.LoginEmployeeID + "', '" + TimeStamp + "', '" + dr["Qty"].ToString() + "');");
                }
                RestockCancelB.Text = "Clear Changes";
                RestockCommitB.Text = "OK";
                RestockPendingChanges.Clear();
                RestockProductSeachResultDGV.Enabled = true;
                RestockProductSearchTB.Enabled = true;
                RestockProductSearchTB.Clear();
                MySqlDataReader RestockProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
                ProductViewTable.Load(RestockProductReader);
                RestockPendingChangesDGV_RowsAdded(sender, new DataGridViewRowsAddedEventArgs(0, 0));
            }
        }

        private void LockRestock() {
            RestockProductSeachResultDGV.Enabled = false;
            RestockProductSearchTB.Enabled = false;
        }

        #endregion
    }
}