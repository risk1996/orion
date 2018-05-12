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
            this.MenuMTP = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.ContainerIC = new DevComponents.DotNetBar.ItemContainer();
            this.SalesMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.RestockMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ProductsMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.EmployeesMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ReportMTI = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.TopBar = new DevComponents.DotNetBar.Bar();
            this.LocationLI = new DevComponents.DotNetBar.LabelItem();
            this.SettingsBI = new DevComponents.DotNetBar.ButtonItem();
            this.AboutBI = new DevComponents.DotNetBar.ButtonItem();
            this.MinimizeBI = new DevComponents.DotNetBar.ButtonItem();
            this.MaximizeBI = new DevComponents.DotNetBar.ButtonItem();
            this.ExitBI = new DevComponents.DotNetBar.ButtonItem();
            this.MainMSB = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.StatusLI = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
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
            // SettingsBI
            // 
            this.SettingsBI.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.SettingsBI.Name = "SettingsBI";
            this.SettingsBI.Symbol = "";
            this.SettingsBI.SymbolColor = System.Drawing.Color.Black;
            // 
            // AboutBI
            // 
            this.AboutBI.Name = "AboutBI";
            this.AboutBI.Symbol = "";
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
            this.MainMSB.Location = new System.Drawing.Point(5, 537);
            this.MainMSB.Name = "MainMSB";
            this.MainMSB.Size = new System.Drawing.Size(774, 22);
            this.MainMSB.TabIndex = 3;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // StatusLI
            // 
            this.StatusLI.Name = "StatusLI";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MenuMTP);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.MainMSB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(784, 561);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main | Orion";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
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
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelItem StatusLI;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
    }
}