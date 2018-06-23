namespace Orion {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginB = new DevComponents.DotNetBar.ButtonX();
            this.UsernameTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PasswordTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SelectedH = new DevComponents.DotNetBar.Validator.Highlighter();
            this.RememberCB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ProgressCP = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.LogoRI = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LoginB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SelectedH.SetHighlightOnFocus(this.LoginB, true);
            this.LoginB.Location = new System.Drawing.Point(197, 97);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(75, 23);
            this.LoginB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LoginB.Symbol = "";
            this.LoginB.SymbolSize = 10F;
            this.LoginB.TabIndex = 3;
            this.LoginB.Text = "Login";
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UsernameTB.Border.Class = "TextBoxBorder";
            this.UsernameTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UsernameTB.DisabledBackColor = System.Drawing.Color.White;
            this.UsernameTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.UsernameTB, true);
            this.UsernameTB.Location = new System.Drawing.Point(76, 12);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PreventEnterBeep = true;
            this.UsernameTB.Size = new System.Drawing.Size(196, 22);
            this.UsernameTB.TabIndex = 0;
            this.UsernameTB.WatermarkText = "Username";
            this.UsernameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTB_KeyDown);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PasswordTB.Border.Class = "TextBoxBorder";
            this.PasswordTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PasswordTB.DisabledBackColor = System.Drawing.Color.White;
            this.PasswordTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.PasswordTB, true);
            this.PasswordTB.Location = new System.Drawing.Point(76, 40);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.PreventEnterBeep = true;
            this.PasswordTB.Size = new System.Drawing.Size(196, 22);
            this.PasswordTB.TabIndex = 1;
            this.PasswordTB.WatermarkText = "Password";
            this.PasswordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTB_KeyDown);
            // 
            // SelectedH
            // 
            this.SelectedH.ContainerControl = this;
            this.SelectedH.CustomHighlightColors = new System.Drawing.Color[0];
            // 
            // RememberCB
            // 
            this.RememberCB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.RememberCB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RememberCB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.RememberCB, true);
            this.RememberCB.Location = new System.Drawing.Point(76, 68);
            this.RememberCB.Name = "RememberCB";
            this.RememberCB.Size = new System.Drawing.Size(203, 23);
            this.RememberCB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RememberCB.TabIndex = 2;
            this.RememberCB.Text = "Remember Username";
            // 
            // ProgressCP
            // 
            this.ProgressCP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ProgressCP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ProgressCP.Location = new System.Drawing.Point(168, 97);
            this.ProgressCP.Name = "ProgressCP";
            this.ProgressCP.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.ProgressCP.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.ProgressCP.Size = new System.Drawing.Size(23, 23);
            this.ProgressCP.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.ProgressCP.TabIndex = 6;
            this.ProgressCP.TabStop = false;
            this.ProgressCP.Visible = false;
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
            this.LogoRI.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.ProgressCP);
            this.Controls.Add(this.LogoRI);
            this.Controls.Add(this.RememberCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.LoginB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Orion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX LoginB;
        private DevComponents.DotNetBar.Controls.TextBoxX UsernameTB;
        private DevComponents.DotNetBar.Controls.TextBoxX PasswordTB;
        private DevComponents.DotNetBar.Validator.Highlighter SelectedH;
        private DevComponents.DotNetBar.Controls.CheckBoxX RememberCB;
        private DevComponents.DotNetBar.Controls.ReflectionImage LogoRI;
        private DevComponents.DotNetBar.Controls.CircularProgress ProgressCP;
    }
}