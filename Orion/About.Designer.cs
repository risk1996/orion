namespace Orion {
    partial class About {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.LogoRI = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.TitleL = new DevComponents.DotNetBar.LabelX();
            this.DevelopersL = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.CloseB = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // LogoRI
            // 
            this.LogoRI.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.LogoRI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LogoRI.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.LogoRI.ForeColor = System.Drawing.Color.Black;
            this.LogoRI.Image = ((System.Drawing.Image)(resources.GetObject("LogoRI.Image")));
            this.LogoRI.Location = new System.Drawing.Point(12, 12);
            this.LogoRI.Name = "LogoRI";
            this.LogoRI.Size = new System.Drawing.Size(58, 108);
            this.LogoRI.TabIndex = 6;
            // 
            // TitleL
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TitleL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.Location = new System.Drawing.Point(76, 12);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(196, 23);
            this.TitleL.TabIndex = 7;
            this.TitleL.Text = "Orion <i>Point-Of-Sales</i>";
            // 
            // DevelopersL
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DevelopersL.Location = new System.Drawing.Point(76, 41);
            this.DevelopersL.Name = "DevelopersL";
            this.DevelopersL.Size = new System.Drawing.Size(196, 79);
            this.DevelopersL.TabIndex = 8;
            this.DevelopersL.Text = "Purpose:<br/>\r\n<b>CE 642 Visual Programming Project</b><br/>\r\nDevelopers:<br/>\r\n<" +
    "b>- William Darian (000 000 10691)</b><br/>\r\n<b>- Nathaneil Marvin (000 000 1024" +
    "1)</b>";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 126);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(260, 94);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = resources.GetString("labelX1.Text");
            // 
            // CloseB
            // 
            this.CloseB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CloseB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CloseB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseB.Location = new System.Drawing.Point(197, 226);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(75, 23);
            this.CloseB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CloseB.TabIndex = 10;
            this.CloseB.Text = "Close";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.DevelopersL);
            this.Controls.Add(this.TitleL);
            this.Controls.Add(this.LogoRI);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orion | About";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage LogoRI;
        private DevComponents.DotNetBar.LabelX TitleL;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX DevelopersL;
        private DevComponents.DotNetBar.ButtonX CloseB;
    }
}