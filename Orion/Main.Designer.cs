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
            this.SubtotalL = new DevComponents.DotNetBar.LabelX();
            this.ItemsDGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AddB = new DevComponents.DotNetBar.ButtonX();
            this.TotalL = new DevComponents.DotNetBar.LabelX();
            this.VATL = new DevComponents.DotNetBar.LabelX();
            this.ItemSeachResultDGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ItemSearchTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ItemSearchLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.AddLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.ItemSearchResultLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.ItemsLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SubtotalLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.TotalLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            this.SalesLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSeachResultDGV)).BeginInit();
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
            this.SalesLC.Controls.Add(this.SubtotalL);
            this.SalesLC.Controls.Add(this.ItemsDGV);
            this.SalesLC.Controls.Add(this.AddB);
            this.SalesLC.Controls.Add(this.TotalL);
            this.SalesLC.Controls.Add(this.VATL);
            this.SalesLC.Controls.Add(this.ItemSeachResultDGV);
            this.SalesLC.Controls.Add(this.ItemSearchTB);
            this.SalesLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesLC.ForeColor = System.Drawing.Color.Black;
            this.SalesLC.Location = new System.Drawing.Point(217, 32);
            this.SalesLC.Name = "SalesLC";
            // 
            // 
            // 
            this.SalesLC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.ItemSearchLCI,
            this.AddLCI,
            this.ItemSearchResultLCI,
            this.ItemsLCI,
            this.SubtotalLCI,
            this.layoutControlItem2,
            this.TotalLCI});
            this.SalesLC.Size = new System.Drawing.Size(562, 505);
            this.SalesLC.TabIndex = 9;
            // 
            // SubtotalL
            // 
            // 
            // 
            // 
            this.SubtotalL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SubtotalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalL.Location = new System.Drawing.Point(56, 435);
            this.SubtotalL.Margin = new System.Windows.Forms.Padding(0);
            this.SubtotalL.Name = "SubtotalL";
            this.SubtotalL.Size = new System.Drawing.Size(277, 23);
            this.SubtotalL.TabIndex = 4;
            this.SubtotalL.Text = "<SUBTOTAL>";
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDGV.EnableHeadersVisualStyles = false;
            this.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ItemsDGV.Location = new System.Drawing.Point(56, 135);
            this.ItemsDGV.Margin = new System.Windows.Forms.Padding(0);
            this.ItemsDGV.Name = "ItemsDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDGV.Size = new System.Drawing.Size(502, 292);
            this.ItemsDGV.TabIndex = 3;
            // 
            // AddB
            // 
            this.AddB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddB.Location = new System.Drawing.Point(504, 4);
            this.AddB.Margin = new System.Windows.Forms.Padding(0);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(24, 23);
            this.AddB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddB.Symbol = "";
            this.AddB.TabIndex = 1;
            // 
            // TotalL
            // 
            // 
            // 
            // 
            this.TotalL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TotalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.Location = new System.Drawing.Point(56, 466);
            this.TotalL.Margin = new System.Windows.Forms.Padding(0);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(502, 23);
            this.TotalL.TabIndex = 6;
            this.TotalL.Text = "<TOTAL>";
            // 
            // VATL
            // 
            // 
            // 
            // 
            this.VATL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.VATL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VATL.ForeColor = System.Drawing.Color.DimGray;
            this.VATL.Location = new System.Drawing.Point(393, 435);
            this.VATL.Margin = new System.Windows.Forms.Padding(0);
            this.VATL.Name = "VATL";
            this.VATL.Size = new System.Drawing.Size(165, 23);
            this.VATL.TabIndex = 5;
            this.VATL.Text = "<VAT>";
            // 
            // ItemSeachResultDGV
            // 
            this.ItemSeachResultDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemSeachResultDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemSeachResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemSeachResultDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemSeachResultDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ItemSeachResultDGV.EnableHeadersVisualStyles = false;
            this.ItemSeachResultDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ItemSeachResultDGV.Location = new System.Drawing.Point(56, 35);
            this.ItemSeachResultDGV.Margin = new System.Windows.Forms.Padding(0);
            this.ItemSeachResultDGV.Name = "ItemSeachResultDGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemSeachResultDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ItemSeachResultDGV.Size = new System.Drawing.Size(502, 92);
            this.ItemSeachResultDGV.TabIndex = 2;
            this.ItemSeachResultDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemSeachResultDGV_CellDoubleClick);
            // 
            // ItemSearchTB
            // 
            this.ItemSearchTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ItemSearchTB.Border.Class = "TextBoxBorder";
            this.ItemSearchTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemSearchTB.DisabledBackColor = System.Drawing.Color.White;
            this.ItemSearchTB.ForeColor = System.Drawing.Color.Black;
            this.ItemSearchTB.Location = new System.Drawing.Point(56, 4);
            this.ItemSearchTB.Margin = new System.Windows.Forms.Padding(0);
            this.ItemSearchTB.Name = "ItemSearchTB";
            this.ItemSearchTB.PreventEnterBeep = true;
            this.ItemSearchTB.Size = new System.Drawing.Size(440, 20);
            this.ItemSearchTB.TabIndex = 0;
            this.ItemSearchTB.WatermarkText = "Enter Product ID or Product Name";
            this.ItemSearchTB.TextChanged += new System.EventHandler(this.ItemSearchTB_TextChanged);
            // 
            // ItemSearchLCI
            // 
            this.ItemSearchLCI.Control = this.ItemSearchTB;
            this.ItemSearchLCI.Height = 28;
            this.ItemSearchLCI.MinSize = new System.Drawing.Size(120, 0);
            this.ItemSearchLCI.Name = "ItemSearchLCI";
            this.ItemSearchLCI.Text = "Search:";
            this.ItemSearchLCI.Width = 500;
            // 
            // AddLCI
            // 
            this.AddLCI.Control = this.AddB;
            this.AddLCI.Height = 31;
            this.AddLCI.MinSize = new System.Drawing.Size(32, 20);
            this.AddLCI.Name = "AddLCI";
            this.AddLCI.Width = 31;
            // 
            // ItemSearchResultLCI
            // 
            this.ItemSearchResultLCI.Control = this.ItemSeachResultDGV;
            this.ItemSearchResultLCI.Height = 100;
            this.ItemSearchResultLCI.MinSize = new System.Drawing.Size(64, 18);
            this.ItemSearchResultLCI.Name = "ItemSearchResultLCI";
            this.ItemSearchResultLCI.Text = "Result:";
            this.ItemSearchResultLCI.Width = 100;
            this.ItemSearchResultLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // ItemsLCI
            // 
            this.ItemsLCI.Control = this.ItemsDGV;
            this.ItemsLCI.Height = 300;
            this.ItemsLCI.MinSize = new System.Drawing.Size(64, 18);
            this.ItemsLCI.Name = "ItemsLCI";
            this.ItemsLCI.Text = "Items:";
            this.ItemsLCI.Width = 100;
            this.ItemsLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SubtotalLCI
            // 
            this.SubtotalLCI.Control = this.SubtotalL;
            this.SubtotalLCI.Height = 31;
            this.SubtotalLCI.MinSize = new System.Drawing.Size(64, 18);
            this.SubtotalLCI.Name = "SubtotalLCI";
            this.SubtotalLCI.Text = "Subtotal:";
            this.SubtotalLCI.Width = 60;
            this.SubtotalLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.VATL;
            this.layoutControlItem2.Height = 31;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "VAT:";
            this.layoutControlItem2.Width = 40;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // TotalLCI
            // 
            this.TotalLCI.Control = this.TotalL;
            this.TotalLCI.Height = 31;
            this.TotalLCI.MinSize = new System.Drawing.Size(64, 18);
            this.TotalLCI.Name = "TotalLCI";
            this.TotalLCI.Text = "Total:";
            this.TotalLCI.Width = 100;
            this.TotalLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            this.SalesLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSeachResultDGV)).EndInit();
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
        private DevComponents.DotNetBar.ButtonX AddB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem AddLCI;
        private DevComponents.DotNetBar.Controls.DataGridViewX ItemsDGV;
        private DevComponents.DotNetBar.Layout.LayoutControlItem ItemsLCI;
        private DevComponents.DotNetBar.LabelX SubtotalL;
        private DevComponents.DotNetBar.LabelX TotalL;
        private DevComponents.DotNetBar.Layout.LayoutControlItem SubtotalLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem TotalLCI;
        private DevComponents.DotNetBar.LabelX VATL;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Controls.DataGridViewX ItemSeachResultDGV;
        private DevComponents.DotNetBar.Controls.TextBoxX ItemSearchTB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem ItemSearchLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem ItemSearchResultLCI;
    }
}