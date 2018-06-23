namespace Orion {
    partial class Settings {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ColorSchemeCCC = new DevComponents.DotNetBar.ColorPickers.ColorCombControl();
            this.ColorSchemeL = new DevComponents.DotNetBar.LabelX();
            this.OKB = new DevComponents.DotNetBar.ButtonX();
            this.ResetB = new DevComponents.DotNetBar.ButtonX();
            this.ColorL = new DevComponents.DotNetBar.Controls.Line();
            this.HexL = new DevComponents.DotNetBar.LabelX();
            this.StyleSM = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // ColorSchemeCCC
            // 
            this.ColorSchemeCCC.Location = new System.Drawing.Point(12, 41);
            this.ColorSchemeCCC.Name = "ColorSchemeCCC";
            this.ColorSchemeCCC.Size = new System.Drawing.Size(260, 280);
            this.ColorSchemeCCC.TabIndex = 0;
            this.ColorSchemeCCC.SelectedColorChanged += new System.EventHandler(this.ColorSchemeCCC_SelectedColorChanged);
            // 
            // ColorSchemeL
            // 
            // 
            // 
            // 
            this.ColorSchemeL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColorSchemeL.Location = new System.Drawing.Point(12, 12);
            this.ColorSchemeL.Name = "ColorSchemeL";
            this.ColorSchemeL.Size = new System.Drawing.Size(179, 23);
            this.ColorSchemeL.TabIndex = 1;
            this.ColorSchemeL.Text = "Orion Color Scheme:";
            // 
            // OKB
            // 
            this.OKB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OKB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OKB.Location = new System.Drawing.Point(197, 327);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(75, 23);
            this.OKB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OKB.TabIndex = 2;
            this.OKB.Text = "OK";
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // ResetB
            // 
            this.ResetB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ResetB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ResetB.Location = new System.Drawing.Point(12, 327);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(75, 23);
            this.ResetB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ResetB.TabIndex = 3;
            this.ResetB.Text = "Reset";
            this.ResetB.Click += new System.EventHandler(this.ResetB_Click);
            // 
            // ColorL
            // 
            this.ColorL.ForeColor = System.Drawing.Color.Black;
            this.ColorL.Location = new System.Drawing.Point(197, 12);
            this.ColorL.Name = "ColorL";
            this.ColorL.Size = new System.Drawing.Size(23, 23);
            this.ColorL.TabIndex = 4;
            this.ColorL.Thickness = 50;
            // 
            // HexL
            // 
            // 
            // 
            // 
            this.HexL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HexL.Location = new System.Drawing.Point(226, 12);
            this.HexL.Name = "HexL";
            this.HexL.Size = new System.Drawing.Size(46, 23);
            this.HexL.TabIndex = 5;
            this.HexL.Text = "000000";
            // 
            // StyleSM
            // 
            this.StyleSM.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.HexL);
            this.Controls.Add(this.ColorL);
            this.Controls.Add(this.ResetB);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.ColorSchemeL);
            this.Controls.Add(this.ColorSchemeCCC);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings | Orion";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ColorPickers.ColorCombControl ColorSchemeCCC;
        private DevComponents.DotNetBar.LabelX ColorSchemeL;
        private DevComponents.DotNetBar.ButtonX OKB;
        private DevComponents.DotNetBar.ButtonX ResetB;
        private DevComponents.DotNetBar.Controls.Line ColorL;
        private DevComponents.DotNetBar.LabelX HexL;
        private DevComponents.DotNetBar.StyleManager StyleSM;
    }
}