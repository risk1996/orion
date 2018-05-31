namespace Orion {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuMTP = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.ContainerIC = new DevComponents.DotNetBar.ItemContainer();
            this.SalesMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.RestockMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ProductsMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.EmployeesMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ReportMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.TopBar = new DevComponents.DotNetBar.Bar();
            this.LocationLI = new DevComponents.DotNetBar.LabelItem();
            this.CalcBI = new DevComponents.DotNetBar.ButtonItem();
            this.SettingsBI = new DevComponents.DotNetBar.ButtonItem();
            this.AboutBI = new DevComponents.DotNetBar.ButtonItem();
            this.MinimizeBI = new DevComponents.DotNetBar.ButtonItem();
            this.MaximizeBI = new DevComponents.DotNetBar.ButtonItem();
            this.ExitBI = new DevComponents.DotNetBar.ButtonItem();
            this.MainMSB = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.StatusLI = new DevComponents.DotNetBar.LabelItem();
            this.UserLI = new DevComponents.DotNetBar.LabelItem();
            this.SelectedH = new DevComponents.DotNetBar.Validator.Highlighter();
            this.SalesCartDGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.SalesProductSeachResultDGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.SalesProductSearchTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SalesLC = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.SalesSubtotalL = new DevComponents.DotNetBar.LabelX();
            this.SalesTotalL = new DevComponents.DotNetBar.LabelX();
            this.SalesVATL = new DevComponents.DotNetBar.LabelX();
            this.SalesCheckoutB = new DevComponents.DotNetBar.ButtonX();
            this.SalesProductSearchLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesProductSearchResultLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesCartLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesSubtotalLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesVATLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesTotalLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesCheckoutLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesClearCartBI = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCartDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesProductSeachResultDGV)).BeginInit();
            this.SalesLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMTP
            // 
            // 
            // 
            // 
            this.MenuMTP.BackgroundStyle.Class = "MetroTilePanel";
            this.MenuMTP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MenuMTP.ContainerControlProcessDialogKey = true;
            this.MenuMTP.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuMTP.DragDropSupport = true;
            this.MenuMTP.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ContainerIC});
            this.MenuMTP.Location = new System.Drawing.Point(5, 32);
            this.MenuMTP.Name = "MenuMTP";
            this.MenuMTP.Size = new System.Drawing.Size(212, 505);
            this.MenuMTP.TabIndex = 0;
            this.MenuMTP.Text = "Main Menu";
            // 
            // ContainerIC
            // 
            // 
            // 
            // 
            this.ContainerIC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ContainerIC.MultiLine = true;
            this.ContainerIC.Name = "ContainerIC";
            this.ContainerIC.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SalesMTI,
            this.RestockMTI,
            this.ProductsMTI,
            this.EmployeesMTI,
            this.ReportMTI});
            // 
            // 
            // 
            this.ContainerIC.TitleStyle.Class = "MetroTileGroupTitle";
            this.ContainerIC.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // SalesMTI
            // 
            this.SalesMTI.Name = "SalesMTI";
            this.SalesMTI.Symbol = "";
            this.SalesMTI.SymbolColor = System.Drawing.Color.Green;
            this.SalesMTI.SymbolSize = 48F;
            this.SalesMTI.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.SalesMTI.TileStyle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.SalesMTI.TileStyle.BackColor2 = System.Drawing.Color.Green;
            this.SalesMTI.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesMTI.TitleText = "Sales";
            // 
            // RestockMTI
            // 
            this.RestockMTI.Name = "RestockMTI";
            this.RestockMTI.Symbol = "";
            this.RestockMTI.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RestockMTI.SymbolSize = 48F;
            this.RestockMTI.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.RestockMTI.TileStyle.BackColor = System.Drawing.Color.Chocolate;
            this.RestockMTI.TileStyle.BackColor2 = System.Drawing.Color.SaddleBrown;
            this.RestockMTI.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RestockMTI.TitleText = "Restock";
            // 
            // ProductsMTI
            // 
            this.ProductsMTI.Name = "ProductsMTI";
            this.ProductsMTI.Symbol = "";
            this.ProductsMTI.SymbolColor = System.Drawing.Color.Indigo;
            this.ProductsMTI.SymbolSize = 48F;
            this.ProductsMTI.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.ProductsMTI.TileStyle.BackColor = System.Drawing.Color.BlueViolet;
            this.ProductsMTI.TileStyle.BackColor2 = System.Drawing.Color.Purple;
            this.ProductsMTI.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ProductsMTI.TitleText = "Products";
            // 
            // EmployeesMTI
            // 
            this.EmployeesMTI.Name = "EmployeesMTI";
            this.EmployeesMTI.Symbol = "";
            this.EmployeesMTI.SymbolColor = System.Drawing.Color.LightSeaGreen;
            this.EmployeesMTI.SymbolSize = 48F;
            this.EmployeesMTI.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.EmployeesMTI.TileStyle.BackColor = System.Drawing.Color.Aquamarine;
            this.EmployeesMTI.TileStyle.BackColor2 = System.Drawing.Color.Teal;
            this.EmployeesMTI.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.EmployeesMTI.TitleText = "Employees";
            // 
            // ReportMTI
            // 
            this.ReportMTI.Name = "ReportMTI";
            this.ReportMTI.Symbol = "";
            this.ReportMTI.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ReportMTI.SymbolSize = 48F;
            this.ReportMTI.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.ReportMTI.TileStyle.BackColor = System.Drawing.Color.Coral;
            this.ReportMTI.TileStyle.BackColor2 = System.Drawing.Color.OrangeRed;
            this.ReportMTI.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReportMTI.TitleText = "Financial Report";
            // 
            // TopBar
            // 
            this.TopBar.AntiAlias = true;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TopBar.IsMaximized = false;
            this.TopBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.LocationLI,
            this.CalcBI,
            this.SettingsBI,
            this.AboutBI,
            this.MinimizeBI,
            this.MaximizeBI,
            this.ExitBI});
            this.TopBar.Location = new System.Drawing.Point(5, 1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(774, 31);
            this.TopBar.Stretch = true;
            this.TopBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TopBar.TabIndex = 4;
            this.TopBar.TabStop = false;
            // 
            // LocationLI
            // 
            this.LocationLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLI.Icon = ((System.Drawing.Icon)(resources.GetObject("LocationLI.Icon")));
            this.LocationLI.Name = "LocationLI";
            this.LocationLI.Stretch = true;
            this.LocationLI.Text = "Orion";
            this.LocationLI.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LocationLI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocationLI_MouseDown);
            // 
            // CalcBI
            // 
            this.CalcBI.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.CalcBI.Name = "CalcBI";
            this.CalcBI.Symbol = "";
            this.CalcBI.SymbolColor = System.Drawing.Color.Black;
            this.CalcBI.Click += new System.EventHandler(this.CalcBI_Click);
            // 
            // SettingsBI
            // 
            this.SettingsBI.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.SettingsBI.Name = "SettingsBI";
            this.SettingsBI.Symbol = "";
            this.SettingsBI.SymbolColor = System.Drawing.Color.Black;
            this.SettingsBI.Click += new System.EventHandler(this.SettingsBI_Click);
            // 
            // AboutBI
            // 
            this.AboutBI.Name = "AboutBI";
            this.AboutBI.Symbol = "";
            this.AboutBI.Click += new System.EventHandler(this.AboutBI_Click);
            // 
            // MinimizeBI
            // 
            this.MinimizeBI.Name = "MinimizeBI";
            this.MinimizeBI.Symbol = "";
            this.MinimizeBI.Click += new System.EventHandler(this.MinimizeBI_Click);
            // 
            // MaximizeBI
            // 
            this.MaximizeBI.Name = "MaximizeBI";
            this.MaximizeBI.Symbol = "";
            this.MaximizeBI.Click += new System.EventHandler(this.MaximizeBI_Click);
            // 
            // ExitBI
            // 
            this.ExitBI.Name = "ExitBI";
            this.ExitBI.Symbol = "";
            this.ExitBI.Click += new System.EventHandler(this.ExitBI_Click);
            // 
            // MainMSB
            // 
            // 
            // 
            // 
            this.MainMSB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MainMSB.ContainerControlProcessDialogKey = true;
            this.MainMSB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainMSB.DragDropSupport = true;
            this.MainMSB.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMSB.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.StatusLI,
            this.UserLI});
            this.MainMSB.Location = new System.Drawing.Point(5, 537);
            this.MainMSB.Name = "MainMSB";
            this.MainMSB.Size = new System.Drawing.Size(774, 22);
            this.MainMSB.TabIndex = 3;
            // 
            // StatusLI
            // 
            this.StatusLI.Name = "StatusLI";
            this.StatusLI.Stretch = true;
            this.StatusLI.Text = "Ready";
            // 
            // UserLI
            // 
            this.UserLI.Name = "UserLI";
            this.UserLI.Symbol = "";
            this.UserLI.Text = "<USERNAME>";
            // 
            // SelectedH
            // 
            this.SelectedH.ContainerControl = this;
            // 
            // SalesCartDGV
            // 
            this.SalesCartDGV.AllowUserToAddRows = false;
            this.SalesCartDGV.AllowUserToDeleteRows = false;
            this.SalesCartDGV.AllowUserToResizeColumns = false;
            this.SalesCartDGV.AllowUserToResizeRows = false;
            this.SalesCartDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesCartDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.SalesCartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesCartDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.SalesCartDGV.EnableHeadersVisualStyles = false;
            this.SalesCartDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectedH.SetHighlightOnFocus(this.SalesCartDGV, true);
            this.SalesCartDGV.Location = new System.Drawing.Point(56, 144);
            this.SalesCartDGV.Margin = new System.Windows.Forms.Padding(0);
            this.SalesCartDGV.Name = "SalesCartDGV";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesCartDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.SalesCartDGV.Size = new System.Drawing.Size(502, 242);
            this.SalesCartDGV.TabIndex = 2;
            this.SalesCartDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesCartDGV_CellEndEdit);
            // 
            // SalesProductSeachResultDGV
            // 
            this.SalesProductSeachResultDGV.AllowUserToAddRows = false;
            this.SalesProductSeachResultDGV.AllowUserToDeleteRows = false;
            this.SalesProductSeachResultDGV.AllowUserToResizeColumns = false;
            this.SalesProductSeachResultDGV.AllowUserToResizeRows = false;
            this.SalesProductSeachResultDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesProductSeachResultDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.SalesProductSeachResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesProductSeachResultDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.SalesProductSeachResultDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SalesProductSeachResultDGV.EnableHeadersVisualStyles = false;
            this.SalesProductSeachResultDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectedH.SetHighlightOnFocus(this.SalesProductSeachResultDGV, true);
            this.SalesProductSeachResultDGV.Location = new System.Drawing.Point(56, 44);
            this.SalesProductSeachResultDGV.Margin = new System.Windows.Forms.Padding(0);
            this.SalesProductSeachResultDGV.Name = "SalesProductSeachResultDGV";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesProductSeachResultDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.SalesProductSeachResultDGV.Size = new System.Drawing.Size(502, 92);
            this.SalesProductSeachResultDGV.TabIndex = 1;
            this.SalesProductSeachResultDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesProductSeachResultDGV_CellDoubleClick);
            // 
            // SalesProductSearchTB
            // 
            this.SalesProductSearchTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.SalesProductSearchTB.Border.Class = "TextBoxBorder";
            this.SalesProductSearchTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesProductSearchTB.DisabledBackColor = System.Drawing.Color.White;
            this.SalesProductSearchTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesProductSearchTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.SalesProductSearchTB, true);
            this.SalesProductSearchTB.Location = new System.Drawing.Point(56, 4);
            this.SalesProductSearchTB.Margin = new System.Windows.Forms.Padding(0);
            this.SalesProductSearchTB.Name = "SalesProductSearchTB";
            this.SalesProductSearchTB.PreventEnterBeep = true;
            this.SalesProductSearchTB.Size = new System.Drawing.Size(502, 33);
            this.SalesProductSearchTB.TabIndex = 0;
            this.SalesProductSearchTB.WatermarkText = "Enter Product ID or Product Name";
            this.SalesProductSearchTB.TextChanged += new System.EventHandler(this.SalesProductSearchTB_TextChanged);
            // 
            // SalesLC
            // 
            this.SalesLC.AutoScaleLayout = false;
            this.SalesLC.BackColor = System.Drawing.Color.White;
            this.SalesLC.Controls.Add(this.SalesSubtotalL);
            this.SalesLC.Controls.Add(this.SalesCartDGV);
            this.SalesLC.Controls.Add(this.SalesTotalL);
            this.SalesLC.Controls.Add(this.SalesVATL);
            this.SalesLC.Controls.Add(this.SalesProductSeachResultDGV);
            this.SalesLC.Controls.Add(this.SalesProductSearchTB);
            this.SalesLC.Controls.Add(this.SalesCheckoutB);
            this.SalesLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesLC.ForeColor = System.Drawing.Color.Black;
            this.SalesLC.Location = new System.Drawing.Point(217, 32);
            this.SalesLC.Name = "SalesLC";
            // 
            // 
            // 
            this.SalesLC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.SalesProductSearchLCI,
            this.SalesProductSearchResultLCI,
            this.SalesCartLCI,
            this.SalesSubtotalLCI,
            this.SalesVATLCI,
            this.SalesTotalLCI,
            this.SalesCheckoutLCI});
            this.SalesLC.Size = new System.Drawing.Size(562, 505);
            this.SalesLC.TabIndex = 9;
            this.SalesLC.SizeChanged += new System.EventHandler(this.SalesLC_SizeChanged);
            // 
            // SalesSubtotalL
            // 
            // 
            // 
            // 
            this.SalesSubtotalL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesSubtotalL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesSubtotalL.Location = new System.Drawing.Point(56, 394);
            this.SalesSubtotalL.Margin = new System.Windows.Forms.Padding(0);
            this.SalesSubtotalL.Name = "SalesSubtotalL";
            this.SalesSubtotalL.Size = new System.Drawing.Size(221, 42);
            this.SalesSubtotalL.TabIndex = 3;
            this.SalesSubtotalL.Text = "<SUBTOTAL>";
            // 
            // SalesTotalL
            // 
            // 
            // 
            // 
            this.SalesTotalL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesTotalL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.SalesTotalL.Location = new System.Drawing.Point(56, 444);
            this.SalesTotalL.Margin = new System.Windows.Forms.Padding(0);
            this.SalesTotalL.Name = "SalesTotalL";
            this.SalesTotalL.Size = new System.Drawing.Size(221, 42);
            this.SalesTotalL.TabIndex = 5;
            this.SalesTotalL.Text = "<TOTAL>";
            // 
            // SalesVATL
            // 
            // 
            // 
            // 
            this.SalesVATL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesVATL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.SalesVATL.ForeColor = System.Drawing.Color.DimGray;
            this.SalesVATL.Location = new System.Drawing.Point(337, 394);
            this.SalesVATL.Margin = new System.Windows.Forms.Padding(0);
            this.SalesVATL.Name = "SalesVATL";
            this.SalesVATL.Size = new System.Drawing.Size(221, 42);
            this.SalesVATL.TabIndex = 4;
            this.SalesVATL.Text = "<VAT>";
            // 
            // SalesCheckoutB
            // 
            this.SalesCheckoutB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SalesCheckoutB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SalesCheckoutB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.SelectedH.SetHighlightOnFocus(this.SalesCheckoutB, true);
            this.SalesCheckoutB.Location = new System.Drawing.Point(285, 444);
            this.SalesCheckoutB.Margin = new System.Windows.Forms.Padding(0);
            this.SalesCheckoutB.Name = "SalesCheckoutB";
            this.SalesCheckoutB.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom;
            this.SalesCheckoutB.Size = new System.Drawing.Size(273, 42);
            this.SalesCheckoutB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SalesCheckoutB.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SalesClearCartBI});
            this.SalesCheckoutB.SubItemsExpandWidth = 50;
            this.SalesCheckoutB.Symbol = "";
            this.SalesCheckoutB.TabIndex = 6;
            this.SalesCheckoutB.Text = "Checkout";
            this.SalesCheckoutB.Click += new System.EventHandler(this.SalesCheckoutB_Click);
            // 
            // SalesProductSearchLCI
            // 
            this.SalesProductSearchLCI.Control = this.SalesProductSearchTB;
            this.SalesProductSearchLCI.Height = 40;
            this.SalesProductSearchLCI.MinSize = new System.Drawing.Size(120, 0);
            this.SalesProductSearchLCI.Name = "SalesProductSearchLCI";
            this.SalesProductSearchLCI.Text = "Search:";
            this.SalesProductSearchLCI.Width = 100;
            this.SalesProductSearchLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesProductSearchResultLCI
            // 
            this.SalesProductSearchResultLCI.Control = this.SalesProductSeachResultDGV;
            this.SalesProductSearchResultLCI.Height = 100;
            this.SalesProductSearchResultLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesProductSearchResultLCI.Name = "SalesProductSearchResultLCI";
            this.SalesProductSearchResultLCI.Text = "Result:";
            this.SalesProductSearchResultLCI.Width = 100;
            this.SalesProductSearchResultLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesCartLCI
            // 
            this.SalesCartLCI.Control = this.SalesCartDGV;
            this.SalesCartLCI.Height = 250;
            this.SalesCartLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesCartLCI.Name = "SalesCartLCI";
            this.SalesCartLCI.Text = "Cart:";
            this.SalesCartLCI.Width = 100;
            this.SalesCartLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesSubtotalLCI
            // 
            this.SalesSubtotalLCI.Control = this.SalesSubtotalL;
            this.SalesSubtotalLCI.Height = 50;
            this.SalesSubtotalLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesSubtotalLCI.Name = "SalesSubtotalLCI";
            this.SalesSubtotalLCI.Text = "Subtotal:";
            this.SalesSubtotalLCI.Width = 50;
            this.SalesSubtotalLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesVATLCI
            // 
            this.SalesVATLCI.Control = this.SalesVATL;
            this.SalesVATLCI.Height = 40;
            this.SalesVATLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesVATLCI.Name = "SalesVATLCI";
            this.SalesVATLCI.Text = "VAT:";
            this.SalesVATLCI.Width = 50;
            this.SalesVATLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesTotalLCI
            // 
            this.SalesTotalLCI.Control = this.SalesTotalL;
            this.SalesTotalLCI.Height = 50;
            this.SalesTotalLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesTotalLCI.Name = "SalesTotalLCI";
            this.SalesTotalLCI.Text = "Total:";
            this.SalesTotalLCI.Width = 50;
            this.SalesTotalLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesCheckoutLCI
            // 
            this.SalesCheckoutLCI.Control = this.SalesCheckoutB;
            this.SalesCheckoutLCI.Height = 31;
            this.SalesCheckoutLCI.MinSize = new System.Drawing.Size(32, 20);
            this.SalesCheckoutLCI.Name = "SalesCheckoutLCI";
            this.SalesCheckoutLCI.Width = 50;
            this.SalesCheckoutLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesClearCartBI
            // 
            this.SalesClearCartBI.GlobalItem = false;
            this.SalesClearCartBI.Name = "SalesClearCartBI";
            this.SalesClearCartBI.Symbol = "";
            this.SalesClearCartBI.Text = "Clear Cart";
            this.SalesClearCartBI.Click += new System.EventHandler(this.SalesClearCartBI_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SalesLC);
            this.Controls.Add(this.MenuMTP);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.MainMSB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(784, 561);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main | Orion";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCartDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesProductSeachResultDGV)).EndInit();
            this.SalesLC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel MenuMTP;
        private DevComponents.DotNetBar.ItemContainer ContainerIC;
        private DevComponents.DotNetBar.Metro.MetroTileItem RestockMTI;
        private DevComponents.DotNetBar.Metro.MetroTileItem SalesMTI;
        private DevComponents.DotNetBar.Metro.MetroTileItem ProductsMTI;
        private DevComponents.DotNetBar.Metro.MetroTileItem EmployeesMTI;
        private DevComponents.DotNetBar.Metro.MetroTileItem ReportMTI;
        private DevComponents.DotNetBar.Bar TopBar;
        private DevComponents.DotNetBar.ButtonItem SettingsBI;
        private DevComponents.DotNetBar.ButtonItem AboutBI;
        private DevComponents.DotNetBar.ButtonItem ExitBI;
        private DevComponents.DotNetBar.LabelItem LocationLI;
        private DevComponents.DotNetBar.ButtonItem MinimizeBI;
        private DevComponents.DotNetBar.ButtonItem MaximizeBI;
        private DevComponents.DotNetBar.Metro.MetroStatusBar MainMSB;
        private DevComponents.DotNetBar.Validator.Highlighter SelectedH;
        private DevComponents.DotNetBar.ButtonItem CalcBI;
        private DevComponents.DotNetBar.LabelItem StatusLI;
        private DevComponents.DotNetBar.LabelItem UserLI;
        private DevComponents.DotNetBar.Layout.LayoutControl SalesLC;
        private DevComponents.DotNetBar.Controls.DataGridViewX SalesCartDGV;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesCartLCI;
        private DevComponents.DotNetBar.LabelX SalesSubtotalL;
        private DevComponents.DotNetBar.LabelX SalesTotalL;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesSubtotalLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesTotalLCI;
        private DevComponents.DotNetBar.LabelX SalesVATL;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesVATLCI;
        private DevComponents.DotNetBar.Controls.DataGridViewX SalesProductSeachResultDGV;
        private DevComponents.DotNetBar.Controls.TextBoxX SalesProductSearchTB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesProductSearchLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesProductSearchResultLCI;
        private DevComponents.DotNetBar.ButtonX SalesCheckoutB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SalesCheckoutLCI;
        private DevComponents.DotNetBar.ButtonItem SalesClearCartBI;
    }
}