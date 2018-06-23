namespace Orion {
    partial class Calc {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.Calculator = new DevComponents.Editors.Calculator();
            this.StyleSM = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculator.Location = new System.Drawing.Point(0, 0);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(190, 211);
            // 
            // StyleSM
            // 
            this.StyleSM.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.StyleSM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 205);
            this.Controls.Add(this.Calculator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator | Orion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.Calculator Calculator;
        private DevComponents.DotNetBar.StyleManager StyleSM;
    }
}