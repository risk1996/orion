namespace Orion {
    partial class ChangePass {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.IconSB = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.UsernameL = new DevComponents.DotNetBar.LabelX();
            this.OldPasswordTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NewPasswordTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ConfirmPasswordTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.OKB = new DevComponents.DotNetBar.ButtonX();
            this.CancelB = new DevComponents.DotNetBar.ButtonX();
            this.InfoL = new DevComponents.DotNetBar.LabelX();
            this.SelectedH = new DevComponents.DotNetBar.Validator.Highlighter();
            this.StyleSM = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // IconSB
            // 
            // 
            // 
            // 
            this.IconSB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IconSB.Location = new System.Drawing.Point(12, 12);
            this.IconSB.Name = "IconSB";
            this.IconSB.Size = new System.Drawing.Size(75, 65);
            this.IconSB.Symbol = "";
            this.IconSB.TabIndex = 0;
            this.IconSB.Text = "symbolBox1";
            // 
            // UsernameL
            // 
            // 
            // 
            // 
            this.UsernameL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UsernameL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameL.Location = new System.Drawing.Point(93, 12);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(179, 32);
            this.UsernameL.TabIndex = 1;
            this.UsernameL.Text = "<USERNAME>";
            // 
            // OldPasswordTB
            // 
            this.OldPasswordTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.OldPasswordTB.Border.Class = "TextBoxBorder";
            this.OldPasswordTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.OldPasswordTB.DisabledBackColor = System.Drawing.Color.White;
            this.OldPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.OldPasswordTB, true);
            this.OldPasswordTB.Location = new System.Drawing.Point(12, 92);
            this.OldPasswordTB.Name = "OldPasswordTB";
            this.OldPasswordTB.PasswordChar = '●';
            this.OldPasswordTB.PreventEnterBeep = true;
            this.OldPasswordTB.Size = new System.Drawing.Size(260, 22);
            this.OldPasswordTB.TabIndex = 2;
            this.OldPasswordTB.WatermarkText = "Old Password";
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.NewPasswordTB.Border.Class = "TextBoxBorder";
            this.NewPasswordTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NewPasswordTB.DisabledBackColor = System.Drawing.Color.White;
            this.NewPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.NewPasswordTB, true);
            this.NewPasswordTB.Location = new System.Drawing.Point(12, 120);
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.PasswordChar = '●';
            this.NewPasswordTB.PreventEnterBeep = true;
            this.NewPasswordTB.Size = new System.Drawing.Size(260, 22);
            this.NewPasswordTB.TabIndex = 3;
            this.NewPasswordTB.WatermarkText = "New Password";
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ConfirmPasswordTB.Border.Class = "TextBoxBorder";
            this.ConfirmPasswordTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ConfirmPasswordTB.DisabledBackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.ConfirmPasswordTB, true);
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(12, 148);
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.PasswordChar = '●';
            this.ConfirmPasswordTB.PreventEnterBeep = true;
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(260, 22);
            this.ConfirmPasswordTB.TabIndex = 4;
            this.ConfirmPasswordTB.WatermarkText = "Confirm New Password";
            // 
            // OKB
            // 
            this.OKB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OKB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OKB.Location = new System.Drawing.Point(197, 176);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(75, 23);
            this.OKB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OKB.TabIndex = 5;
            this.OKB.Text = "OK";
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // CancelB
            // 
            this.CancelB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CancelB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelB.Location = new System.Drawing.Point(12, 176);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CancelB.TabIndex = 6;
            this.CancelB.Text = "Cancel";
            // 
            // InfoL
            // 
            // 
            // 
            // 
            this.InfoL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.InfoL.Location = new System.Drawing.Point(93, 43);
            this.InfoL.Name = "InfoL";
            this.InfoL.Size = new System.Drawing.Size(179, 43);
            this.InfoL.TabIndex = 7;
            this.InfoL.Text = "<INFORMATION>";
            // 
            // SelectedH
            // 
            this.SelectedH.ContainerControl = this;
            // 
            // StyleSM
            // 
            this.StyleSM.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.InfoL);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.ConfirmPasswordTB);
            this.Controls.Add(this.NewPasswordTB);
            this.Controls.Add(this.OldPasswordTB);
            this.Controls.Add(this.UsernameL);
            this.Controls.Add(this.IconSB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password | Orion";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SymbolBox IconSB;
        private DevComponents.DotNetBar.LabelX UsernameL;
        private DevComponents.DotNetBar.Controls.TextBoxX OldPasswordTB;
        private DevComponents.DotNetBar.Controls.TextBoxX NewPasswordTB;
        private DevComponents.DotNetBar.Controls.TextBoxX ConfirmPasswordTB;
        private DevComponents.DotNetBar.ButtonX OKB;
        private DevComponents.DotNetBar.ButtonX CancelB;
        private DevComponents.DotNetBar.LabelX InfoL;
        private DevComponents.DotNetBar.Validator.Highlighter SelectedH;
        private DevComponents.DotNetBar.StyleManager StyleSM;
    }
}