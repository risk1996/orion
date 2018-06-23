using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Orion {
    public partial class Main : RibbonForm {
        private List<DevComponents.DotNetBar.Metro.MetroTileItem> MainAvailableMTIs = new List<DevComponents.DotNetBar.Metro.MetroTileItem>();
        private DataTable ProductViewTable = new DataTable();
        private DataTable EmployeesViewTable = new DataTable();

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

        private void ChangePasswordBI_Click(object sender, EventArgs e) {

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
            LoadData();
            if (MainAvailableMTIs[0] == SalesMTI) Sales_Load();
            else if (MainAvailableMTIs[0] == RestockMTI) Restock_Load();
            else if (MainAvailableMTIs[0] == ProductsMTI) Products_Load();
        }

        private void LayoutControlFloat() {
            SalesLC.Dock = DockStyle.Fill;
            RestockLC.Dock = DockStyle.Fill;
            ProductsLC.Dock = DockStyle.Fill;
            EmployeesLC.Dock = DockStyle.Fill;
        }

        public void LayoutControlHide() {
            SalesLC.Visible = false;
            RestockLC.Visible = false;
            ProductsLC.Visible = false;
            EmployeesLC.Visible = false;
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
            foreach (DevComponents.DotNetBar.Metro.MetroTileItem MTI in MainAvailableMTIs) MTI.Enabled = true;
        }

        private void LoadData() {
            MySqlDataReader ProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
            ProductViewTable.Load(ProductReader);
            MySqlDataReader EmployeeReader = new DbConnect().ExecQuery("SELECT * FROM employee;");
            EmployeesViewTable.Load(EmployeeReader);
        }

        #region Sales

        public bool SalesLoaded = false;
        public static double SalesTotalPrice = 0;
        private DataTable SalesProductViewTableResult = new DataTable();
        private DataTable SalesPendingTransaction = new DataTable();

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
            if (e.RowIndex >= 0) {
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
                        if (SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Disc"].ToString() == "") SalesPendingTransaction.Rows[SalesPendingTransaction.Rows.IndexOf(SelectedProductRow)]["Disc"] = 0;
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
            foreach (DataRow dr in SalesPendingTransaction.Rows) {
                subtotal += double.Parse(dr["Price"].ToString()) * double.Parse(dr["Qty"].ToString())
                    * (String.IsNullOrEmpty(dr["Disc"].ToString()) ? 1 : ((100.0 - double.Parse(dr["Disc"].ToString())) / 100.0));
            }
            SalesSubtotalL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", subtotal);
            total = Math.Ceiling(subtotal * 1.1 / 500) * 500;
            vat = total - subtotal;
            SalesVATL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", vat);
            SalesTotalL.Text = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", total);
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

        #endregion Sales definition

        #region Restock

        public bool RestockLoaded = false;
        private DataTable RestockProductViewTableResult = new DataTable();
        private DataTable RestockPendingChanges = new DataTable();

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

        #endregion Restock definition

        #region Products

        public bool ProductsLoaded = false;
        private DataTable ProductsProductView = new DataTable();
        private DataTable ProductsSearchResult = new DataTable();
        private DataTable ProductsPendingChanges = new DataTable();

        private void ProductsMTI_Click(object sender, EventArgs e) {
            Products_Load();
        }

        private void Products_Load() {
            LayoutControlHide();
            ProductsLC.Visible = true;
            ProductsLC_SizeChanged(new object(), new EventArgs());
            ProductsProductSearchTB.Select();
            ProductsProductSearchTB.Focus();
            if (!ProductsLoaded) Products_LoadOnce();
            ProductsProductSearchTB_TextChanged(new object(), new EventArgs());
        }

        private void Products_LoadOnce() {
            ProductsProductView = ProductViewTable.Copy();
            ProductsProductView.Columns.Add("product_update");
            ProductsSearchResult.Columns.Add("ID");
            ProductsSearchResult.Columns.Add("Name");
            ProductsSearchResult.Columns.Add("Package");
            ProductsSearchResult.Columns.Add("Substance");
            ProductsSearchResult.Columns.Add("Registrar");
            ProductsSearchResult.Columns.Add("Distributor");
            ProductsSearchResult.Columns.Add("Price");
            ProductsSearchResult.Columns.Add("Stock");
            ProductsSearchResult.Columns.Add("Disc");
            ProductsSearchResult.PrimaryKey = new DataColumn[] { ProductsSearchResult.Columns["ID"] };
            ProductsListDGV.DataSource = ProductsSearchResult;
            ProductsListDGV.Columns["ID"].AutoSizeMode          = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Name"].AutoSizeMode        = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Package"].AutoSizeMode     = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Substance"].AutoSizeMode   = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Registrar"].AutoSizeMode   = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Distributor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Price"].AutoSizeMode       = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Stock"].AutoSizeMode       = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["Disc"].AutoSizeMode        = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProductsListDGV.Columns["ID"].ReadOnly = true;
            ProductsLoaded = true;
        }

        private void ProductsLC_SizeChanged(object sender, EventArgs e) {
            int ProductsOtherComponentHeight = ProductsProductSearchLCI.Height + ProductsCommitLCI.Height;
            ProductsListLCI.Height = ProductsLC.Height - ProductsOtherComponentHeight;
        }

        private void ProductsProductSearchTB_TextChanged(object sender, EventArgs e) {
            string[] ProductsSearchTerms = DbConnect.EscapeLikeValue(ProductsProductSearchTB.Text).Split(' ');
            for (int i = 0; i < ProductsSearchTerms.Length; i++) ProductsSearchTerms[i] = "(product_id + ' ' + product_name + ' ' + product_package + ' ' + product_substance + ' ' + product_registrar + ' ' + product_distributor) LIKE '%" + ProductsSearchTerms[i] + "%'";
            string[] ProductsProductSeachResultColumns = new string[] { "product_id", "product_name", "product_package", "product_substance", "product_registrar", "product_distributor", "product_price", "product_stock", "product_disc_pct" };
            DataRow[] ProductsProductSeachResultProductRows = new DataView(ProductsProductView).ToTable(false, ProductsProductSeachResultColumns).Select(String.Join(" AND ", ProductsSearchTerms));
            ProductsSearchResult.Rows.Clear();
            ProductsProductSeachResultProductRows.CopyToDataTable(ProductsSearchResult, LoadOption.OverwriteChanges);
            ProductsListDGV.Columns[0].ReadOnly = true;
            DataRow[] ProductsProductChange = new DataView(ProductsProductView).ToTable(false, new string[] { "product_id", "product_update" }).Select("product_update IS NOT NULL");
            foreach (DataRow dr in ProductsProductChange) {
                DataRow sr = ProductsSearchResult.Rows.Find(dr[0].ToString());
                if (sr != null) {
                    int isr = ProductsSearchResult.Rows.IndexOf(sr);
                    if (dr[1].ToString() == "UPDATE") ProductsListDGV.Rows[isr].DefaultCellStyle.BackColor = Color.Yellow;
                    else if (dr[1].ToString() == "DELETE") {
                        ProductsListDGV.Rows[isr].DefaultCellStyle.BackColor = Color.Red;
                        ProductsListDGV.Rows[isr].ReadOnly = true;
                    } else if (dr[1].ToString() == "INSERT") {
                        ProductsListDGV.Rows[isr].DefaultCellStyle.BackColor = Color.Green;
                        ProductsListDGV.Rows[isr].ReadOnly = false;
                    }
                }
            }
        }

        private void ProductsListDGV_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void ProductsListDGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            if (e.RowIndex == ProductsListDGV.RowCount - 1) {
                string year = DateTime.Today.ToString("yy");
                DataRow[] drs = ProductsProductView.Select("product_id LIKE 'X" + year + "%'");
                int lastid = drs.Length > 0 ? DbConnect.ConvertFromBase(drs[drs.Length - 1]["product_id"].ToString().Substring(3, 5), 36) : 0;
                int NextProductIDBase10 = lastid + 1;
                string NextProductIDBase36 = DbConnect.ConvertToBase(NextProductIDBase10, 36).PadLeft(5, '0');
                string pid = string.Format("X" + year + NextProductIDBase36);
                ProductsListDGV.Rows[e.RowIndex].Cells[0].Value = pid;
                ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void ProductsListDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsListDGV.Rows.Count) {
                string id = ProductsListDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataRow dr = ProductsProductView.Rows.Find(id);
                if (e.ColumnIndex >= 6) {
                    decimal.TryParse(ProductsListDGV[e.ColumnIndex, e.RowIndex].Value.ToString(), out decimal dec);
                    if (dec < 0) dec = 0;
                    if (e.ColumnIndex == 6) {
                        ProductsListDGV[e.ColumnIndex, e.RowIndex].Value = String.Format("{0:" + Properties.Settings.Default.CurrencyFormat + "}", dec);
                    } else if (e.ColumnIndex == 7) {
                        ProductsListDGV[e.ColumnIndex, e.RowIndex].Value = (int)dec;
                    } else if (e.ColumnIndex == 8) {
                        dec = Math.Min(100, dec);
                        ProductsListDGV[e.ColumnIndex, e.RowIndex].Value = (dec == 0 ? null : dec.ToString());
                    }
                }
                if (dr != null && (dr["product_update"].ToString() == "" || dr["product_update"].ToString() == "UPDATE")) {
                    bool diff = false;
                    int index = ProductsProductView.Rows.IndexOf(dr);
                    if (e.ColumnIndex < 6) dr[e.ColumnIndex] = ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    else {
                        decimal.TryParse(ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out decimal dec);
                        dr[e.ColumnIndex] = dec;
                    }
                    for (int i = 0; i < ProductViewTable.Columns.Count && !diff; i++) diff = ProductsListDGV[i, e.RowIndex].Value.ToString() != ProductViewTable.Rows[index][i].ToString();
                    if (diff) {
                        dr["product_update"] = "UPDATE";
                        ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    } else {
                        dr["product_update"] = null;
                        ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                } else if (dr != null && dr["product_update"].ToString() == "INSERT") {
                    if (e.ColumnIndex < 6) dr[e.ColumnIndex] = ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    else {
                        decimal.TryParse(ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out decimal dec);
                        dr[e.ColumnIndex] = dec;
                    }
                } else if (dr != null && dr["product_update"].ToString() == "TO BE DELETED") {
                    ProductsProductView.Rows.Remove(dr);
                    try { ProductsListDGV.Rows.RemoveAt(e.RowIndex); } catch { }
                } else if (dr == null && ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "") {
                    string pid = ProductsListDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    object[] val = { pid, "", "", "", "", "", 0, 0, 0 };
                    if (e.ColumnIndex < 6) val[e.ColumnIndex] = ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    else {
                        decimal.TryParse(ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out decimal dec);
                        val[e.ColumnIndex] = dec;
                    }
                    DataRow drnew = ProductsProductView.Rows.Add(val);
                    drnew["product_update"] = "INSERT";
                } else if (dr == null && ProductsListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "") {
                    ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    string pid = ProductsListDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    object[] val = { pid, "", "", "", "", "", 0, 0, 0 };
                    DataRow drnew = ProductsProductView.Rows.Add(val);
                    drnew["product_update"] = "TO BE DELETED";
                    ProductsListDGV_CellEndEdit(sender, e);
                }
            }
        }

        private void ProductsListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                string id = ProductsListDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataRow dr = ProductsProductView.Rows.Find(id);
                if (dr != null) {
                    if (dr["product_update"].ToString() == "") {
                        dr["product_update"] = "DELETE";
                        ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        ProductsListDGV.Rows[e.RowIndex].ReadOnly = true;
                    } else if (dr["product_update"].ToString() == "INSERT") {
                        dr["product_update"] = "TO BE DELETED";
                        ProductsProductSearchTB.Select();
                        ProductsProductSearchTB.Focus();
                    } else if (dr["product_update"].ToString() == "DELETE") {
                        dr["product_update"] = null;
                        ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        ProductsListDGV.Rows[e.RowIndex].ReadOnly = false;
                        ProductsListDGV.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                    } else if(dr["product_update"].ToString() == "UPDATE") {
                        int index = ProductsProductView.Rows.IndexOf(dr);
                        for (int i = 0; i < ProductViewTable.Columns.Count; i++) {
                            dr[i] = ProductsListDGV.Rows[e.RowIndex].Cells[i].Value = ProductViewTable.Rows[index][i];
                        }
                        dr["product_update"] = null;
                        ProductsListDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        ProductsListDGV.Rows[e.RowIndex].ReadOnly = false;
                        ProductsListDGV.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                    }
                }
            }
        }

        private void ProductsCancelB_Click(object sender, EventArgs e) {
            if (ProductsCancelB.Text == "Clear Changes") {
                ProductsProductView = ProductViewTable.Copy();
                ProductsProductView.Columns.Add("product_update");
                ProductsProductSearchTB.Text = "";
                ProductsProductSearchTB_TextChanged(sender, e);
                ProductsPendingChanges.Clear();
            } else {
                ProductsCommitB.Text = "OK";
                ProductsCancelB.Text = "Clear Changes";
                UnlockProducts();
                ProductsCommitB.Enabled = true;
            }
        }

        private void ProductsCommitB_Click(object sender, EventArgs e) {
            if (ProductsCommitB.Text == "OK") {
                ProductsCommitB.Text = "Commit Changes";
                ProductsCancelB.Text = "Cancel";
                LockProducts();
                ProductsCommitB.Enabled = ProductsPendingChanges.Rows.Count > 0;
            } else {
                String TimeStamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                foreach (DataRow dr in ProductsPendingChanges.Rows) {
                    if (dr["product_update"].ToString() == "UPDATE") {
                        int ri = ProductsProductView.Rows.IndexOf(ProductsProductView.Rows.Find(dr["ID"]));
                        string id = ProductViewTable.Rows[ri]["product_id"].ToString();
                        int.TryParse(ProductsProductView.Rows[ri]["product_stock"].ToString(), out int newStock);
                        int.TryParse(ProductViewTable.Rows[ri]["product_stock"].ToString(), out int oldStock);
                        float.TryParse(ProductsProductView.Rows[ri]["product_disc_pct"].ToString(), out float newDisc);
                        float.TryParse(ProductViewTable.Rows[ri]["product_disc_pct"].ToString(), out float oldDisc);
                        new DbConnect().ExecNonQuery("UPDATE product SET product_id = '" + dr["ID"] + "', product_name = '" + dr["Name"] + "', product_package = '" + dr["Package"] + "', product_substance = '" + dr["Substance"] + "', product_registrar = '" + dr["Registrar"] + "', product_distributor = '" + dr["Distributor"] + "', product_price = '" + dr["Price"] + "', product_stock = '" + dr["Stock"] + "' " +
                            "WHERE product_id = '" + id + "';");
                        if (newStock - oldStock != 0) {
                            new DbConnect().ExecNonQuery("INSERT product_stock_history(product_id, employee_id, product_stock_history_timestamp, product_stock_history_qty) " +
                                "VALUES ('" + dr["ID"].ToString() + "', '" + Properties.Settings.Default.LoginEmployeeID + "', '" + TimeStamp + "', '" + (newStock - oldStock).ToString() + "');");
                        }
                        if (oldDisc == 0 && newDisc != 0) {
                            new DbConnect().ExecNonQuery("INSERT product_discount " +
                                "VALUES ('" + dr["ID"].ToString() + "', '" + newDisc.ToString() + "');");
                        } else if (oldDisc != 0 && newDisc == 0) {
                            new DbConnect().ExecNonQuery("DELETE FROM product_discount " +
                                "WHERE product_id = '" + dr["ID"].ToString() + "';");
                        } else if (oldDisc != 0 && newDisc != 0) {
                            new DbConnect().ExecNonQuery("UPDATE product_discount SET product_disc_pct = '" + newDisc.ToString() + "'" +
                                "WHERE product_id = '" + dr["ID"].ToString() + "';");
                        }
                    } else if (dr["product_update"].ToString() == "INSERT") {
                        int ri = ProductsProductView.Rows.IndexOf(ProductsProductView.Rows.Find(dr["ID"]));
                        int newStock = int.Parse(ProductsProductView.Rows[ri]["product_stock"].ToString());
                        float newDisc = float.Parse(ProductsProductView.Rows[ri]["product_disc_pct"].ToString());
                        new DbConnect().ExecNonQuery("INSERT product(product_id, product_name, product_package, product_substance, product_registrar, product_distributor, product_price, product_stock)" +
                            "VALUES ('" + dr["ID"] + "', '" + dr["Name"] + "', '" + dr["Package"] + "', '" + dr["Substance"] + "', '" + dr["Registrar"] + "', '" + dr["Distributor"] + "', " + dr["Price"] + ", " + dr["Stock"] + ");");
                        if (newStock != 0) {
                            new DbConnect().ExecNonQuery("INSERT product_stock_history(product_id, employee_id, product_stock_history_timestamp, product_stock_history_qty) " +
                                "VALUES ('" + dr["ID"].ToString() + "', '" + Properties.Settings.Default.LoginEmployeeID + "', '" + TimeStamp + "', '" + dr["Stock"] + "');");
                        }
                        if (newDisc != 0) {
                            new DbConnect().ExecNonQuery("INSERT product_discount " +
                                "VALUES ('" + dr["ID"].ToString() + "', '" + newDisc.ToString() + "');");
                        }
                    } else if (dr["product_update"].ToString() == "DELETE") {
                        new DbConnect().ExecNonQuery("DELETE FROM product_stock_history WHERE product_id = '" + dr["ID"] + "';");
                        new DbConnect().ExecNonQuery("DELETE FROM product_discount WHERE product_id = '" + dr["ID"] + "';");
                        new DbConnect().ExecNonQuery("DELETE FROM product WHERE product_id = '" + dr["ID"] + "';");
                    }
                }
                ProductsCancelB.Text = "Clear Changes";
                ProductsCommitB.Text = "OK";
                MySqlDataReader ProductsProductReader = new DbConnect().ExecQuery("SELECT * FROM product_view;");
                ProductViewTable.Clear();
                ProductViewTable.Load(ProductsProductReader);
                ProductsProductView.Clear();
                ProductsProductView = ProductViewTable.Copy();
                ProductsProductView.Columns.Add("product_update");
                ProductsProductSearchTB.Text = "";
                UnlockProducts();            }
        }

        public void LockProducts() {
            ProductsProductSearchTB.Enabled = false;
            string[] ProductsProductSeachResultColumns = new string[] { "product_id", "product_name", "product_package", "product_substance", "product_registrar", "product_distributor", "product_price", "product_stock", "product_disc_pct", "product_update" };
            DataRow[] ProductsProductSeachResultProductRows = new DataView(ProductsProductView).ToTable(false, ProductsProductSeachResultColumns).Select("product_update IS NOT NULL");
            DataTable ProductsProductPendingTable = ProductsSearchResult.Clone();
            ProductsProductPendingTable.Columns.Add("product_update");
            ProductsProductSeachResultProductRows.CopyToDataTable(ProductsProductPendingTable, LoadOption.OverwriteChanges);
            ProductsPendingChanges = ProductsProductPendingTable.Copy();
            ProductsProductPendingTable.Columns.Remove("product_update");
            ProductsListDGV.DataSource = ProductsProductPendingTable;
            foreach (DataRow dr in ProductsProductSeachResultProductRows) {
                int isr = ProductsProductPendingTable.Rows.IndexOf(ProductsProductPendingTable.Rows.Find(dr["product_id"]));
                if (dr["product_update"].ToString() == "UPDATE") ProductsListDGV.Rows[isr].DefaultCellStyle.BackColor = Color.Yellow;
                else if (dr["product_update"].ToString() == "DELETE") ProductsListDGV.Rows[isr].DefaultCellStyle.BackColor = Color.Red;
                else if (dr["product_update"].ToString() == "INSERT") ProductsListDGV.Rows[isr].DefaultCellStyle.BackColor = Color.Green;
            }
            ProductsListDGV.ReadOnly = true;
            ProductsListDGV.AllowUserToAddRows = false;
            ProductsListDGV.AllowUserToDeleteRows = false;
        }

        public void UnlockProducts() {
            ProductsListDGV.DataSource = ProductsSearchResult;
            ProductsProductSearchTB_TextChanged(new object(), new EventArgs());
            ProductsProductSearchTB.Enabled = true;
            ProductsListDGV.ReadOnly = false;
            ProductsListDGV.AllowUserToAddRows = true;
            ProductsListDGV.AllowUserToDeleteRows = true;
        }

        #endregion Products definition

        #region Employees

        public bool EmployeesLoaded = false;
        private DataTable EmployeesEmployeeView = new DataTable();
        private DataTable EmployeesSearchResult = new DataTable();
        private DataTable EmployeesPendingChanges = new DataTable();

        private void EmployeesMTI_Click(object sender, EventArgs e) {
            Employees_Load();
        }

        private void Employees_Load() {
            LayoutControlHide();
            EmployeesLC.Visible = true;
            EmployeesLC_SizeChanged(new object(), new EventArgs());
            EmployeesEmployeeSearchTB.Select();
            EmployeesEmployeeSearchTB.Focus();
            if (!EmployeesLoaded) Employees_LoadOnce();
            EmployeesEmployeeSearchTB_TextChanged(new object(), new EventArgs());
        }

        private void Employees_LoadOnce() {
            EmployeesEmployeeView = EmployeesViewTable.Copy();
            EmployeesEmployeeView.Columns.Add("employee_update");
            EmployeesSearchResult.Columns.Add("ID");
            EmployeesSearchResult.Columns.Add("Username");
            EmployeesSearchResult.Columns.Add("First Name");
            EmployeesSearchResult.Columns.Add("Last Name");
            EmployeesSearchResult.Columns.Add("Role");
            EmployeesSearchResult.Columns.Add("Gender");
            EmployeesSearchResult.Columns.Add("DOB");
            EmployeesSearchResult.Columns.Add("Phone");
            EmployeesSearchResult.Columns.Add("E-mail");
            EmployeesSearchResult.Columns.Add("Address");
            EmployeesSearchResult.Columns.Add("Hire Date");
            EmployeesSearchResult.Columns.Add("Status");
            EmployeesSearchResult.Columns.Add("Last Login");
            EmployeesSearchResult.PrimaryKey = new DataColumn[] { EmployeesSearchResult.Columns["ID"] };
            EmployeesListDGV.DataSource = EmployeesSearchResult;
            EmployeesListDGV.Columns["ID"].AutoSizeMode         = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Username"].AutoSizeMode   = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["First Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Last Name"].AutoSizeMode  = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Role"].AutoSizeMode       = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Gender"].AutoSizeMode     = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["DOB"].AutoSizeMode        = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Phone"].AutoSizeMode      = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["E-mail"].AutoSizeMode     = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Address"].AutoSizeMode    = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Hire Date"].AutoSizeMode  = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Status"].AutoSizeMode     = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["Last Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EmployeesListDGV.Columns["ID"].ReadOnly = true;
            EmployeesLoaded = true;
        }

        private void EmployeesLC_SizeChanged(object sender, EventArgs e) {
            int EmployeesOtherComponentHeight = EmployeesEmployeeSearchLCI.Height + EmployeesCommitLCI.Height;
            EmployeesListLCI.Height = EmployeesLC.Height - EmployeesOtherComponentHeight;
        }

        private void EmployeesEmployeeSearchTB_TextChanged(object sender, EventArgs e) {

        }

        private void EmployeesListDGV_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void EmployeesListDGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {

        }

        private void EmployeesListDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {

        }

        private void EmployeesListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void EmployeesCancelB_Click(object sender, EventArgs e) {

        }

        private void EmployeesCommitB_Click(object sender, EventArgs e) {

        }

        #endregion

        #region Report



        #endregion
    }
}