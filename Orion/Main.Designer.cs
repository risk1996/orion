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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.SalesLC = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.SalesSubtotalL = new DevComponents.DotNetBar.LabelX();
            this.SalesCartDGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.SalesTotalL = new DevComponents.DotNetBar.LabelX();
            this.SalesVATL = new DevComponents.DotNetBar.LabelX();
            this.SalesProductSeachResultDGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.SalesProductSearchTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SalesProductSearchLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesProductSearchResultLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesCartLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesSubtotalLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesVATLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SalesTotalLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            this.SalesLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCartDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesProductSeachResultDGV)).BeginInit();
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
            this.LocationLI.DoubleClick += new System.EventHandler(this.LocationLI_DoubleClick);
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
            this.UserLI.Text = "<USERNAME>";
            // 
            // SelectedH
            // 
            this.SelectedH.ContainerControl = this;
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
            this.SalesTotalLCI});
            this.SalesLC.Size = new System.Drawing.Size(562, 505);
            this.SalesLC.TabIndex = 9;
            // 
            // SalesSubtotalL
            // 
            // 
            // 
            // 
            this.SalesSubtotalL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesSubtotalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesSubtotalL.Location = new System.Drawing.Point(56, 432);
            this.SalesSubtotalL.Margin = new System.Windows.Forms.Padding(0);
            this.SalesSubtotalL.Name = "SalesSubtotalL";
            this.SalesSubtotalL.Size = new System.Drawing.Size(277, 29);
            this.SalesSubtotalL.TabIndex = 3;
            this.SalesSubtotalL.Text = "<SUBTOTAL>";
            // 
            // SalesCartDGV
            // 
            this.SalesCartDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesCartDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesCartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesCartDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesCartDGV.EnableHeadersVisualStyles = false;
            this.SalesCartDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectedH.SetHighlightOnFocus(this.SalesCartDGV, true);
            this.SalesCartDGV.Location = new System.Drawing.Point(56, 132);
            this.SalesCartDGV.Margin = new System.Windows.Forms.Padding(0);
            this.SalesCartDGV.Name = "SalesCartDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesCartDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesCartDGV.Size = new System.Drawing.Size(502, 292);
            this.SalesCartDGV.TabIndex = 2;
            // 
            // SalesTotalL
            // 
            // 
            // 
            // 
            this.SalesTotalL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesTotalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTotalL.Location = new System.Drawing.Point(56, 469);
            this.SalesTotalL.Margin = new System.Windows.Forms.Padding(0);
            this.SalesTotalL.Name = "SalesTotalL";
            this.SalesTotalL.Size = new System.Drawing.Size(502, 32);
            this.SalesTotalL.TabIndex = 5;
            this.SalesTotalL.Text = "<TOTAL>";
            // 
            // SalesVATL
            // 
            // 
            // 
            // 
            this.SalesVATL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SalesVATL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesVATL.ForeColor = System.Drawing.Color.DimGray;
            this.SalesVATL.Location = new System.Drawing.Point(393, 432);
            this.SalesVATL.Margin = new System.Windows.Forms.Padding(0);
            this.SalesVATL.Name = "SalesVATL";
            this.SalesVATL.Size = new System.Drawing.Size(165, 29);
            this.SalesVATL.TabIndex = 4;
            this.SalesVATL.Text = "<VAT>";
            // 
            // SalesProductSeachResultDGV
            // 
            this.SalesProductSeachResultDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesProductSeachResultDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SalesProductSeachResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesProductSeachResultDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.SalesProductSeachResultDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SalesProductSeachResultDGV.EnableHeadersVisualStyles = false;
            this.SalesProductSeachResultDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectedH.SetHighlightOnFocus(this.SalesProductSeachResultDGV, true);
            this.SalesProductSeachResultDGV.Location = new System.Drawing.Point(56, 32);
            this.SalesProductSeachResultDGV.Margin = new System.Windows.Forms.Padding(0);
            this.SalesProductSeachResultDGV.Name = "SalesProductSeachResultDGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesProductSeachResultDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.SalesProductSearchTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.SalesProductSearchTB, true);
            this.SalesProductSearchTB.Location = new System.Drawing.Point(56, 4);
            this.SalesProductSearchTB.Margin = new System.Windows.Forms.Padding(0);
            this.SalesProductSearchTB.Name = "SalesProductSearchTB";
            this.SalesProductSearchTB.PreventEnterBeep = true;
            this.SalesProductSearchTB.Size = new System.Drawing.Size(502, 20);
            this.SalesProductSearchTB.TabIndex = 0;
            this.SalesProductSearchTB.WatermarkText = "Enter Product ID or Product Name";
            this.SalesProductSearchTB.TextChanged += new System.EventHandler(this.SalesProductSearchTB_TextChanged);
            // 
            // SalesProductSearchLCI
            // 
            this.SalesProductSearchLCI.Control = this.SalesProductSearchTB;
            this.SalesProductSearchLCI.Height = 28;
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
            this.SalesCartLCI.Height = 300;
            this.SalesCartLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesCartLCI.Name = "SalesCartLCI";
            this.SalesCartLCI.Text = "Cart:";
            this.SalesCartLCI.Width = 100;
            this.SalesCartLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesSubtotalLCI
            // 
            this.SalesSubtotalLCI.Control = this.SalesSubtotalL;
            this.SalesSubtotalLCI.Height = 37;
            this.SalesSubtotalLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesSubtotalLCI.Name = "SalesSubtotalLCI";
            this.SalesSubtotalLCI.Text = "Subtotal:";
            this.SalesSubtotalLCI.Width = 60;
            this.SalesSubtotalLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesVATLCI
            // 
            this.SalesVATLCI.Control = this.SalesVATL;
            this.SalesVATLCI.Height = 31;
            this.SalesVATLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesVATLCI.Name = "SalesVATLCI";
            this.SalesVATLCI.Text = "VAT:";
            this.SalesVATLCI.Width = 40;
            this.SalesVATLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SalesTotalLCI
            // 
            this.SalesTotalLCI.Control = this.SalesTotalL;
            this.SalesTotalLCI.Height = 40;
            this.SalesTotalLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SalesTotalLCI.Name = "SalesTotalLCI";
            this.SalesTotalLCI.Text = "Total:";
            this.SalesTotalLCI.Width = 100;
            this.SalesTotalLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
            this.SalesLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesCartDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesProductSeachResultDGV)).EndInit();
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
    }
}