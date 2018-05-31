namespace Orion {
    partial class Checkout {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.CheckoutLC = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.CheckoutCancelB = new DevComponents.DotNetBar.ButtonX();
            this.CheckoutConfirmB = new DevComponents.DotNetBar.ButtonX();
            this.CheckoutInvoiceNoL = new DevComponents.DotNetBar.LabelX();
            this.CheckoutChangeL = new DevComponents.DotNetBar.LabelX();
            this.CheckoutPriceL = new DevComponents.DotNetBar.LabelX();
            this.CheckoutPaymentMTB = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.CheckoutInvoiceNoLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutPaymentLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutPriceLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutChangeLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutCancelLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutConfirmLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckoutLC
            // 
            this.CheckoutLC.BackColor = System.Drawing.Color.White;
            this.CheckoutLC.Controls.Add(this.CheckoutCancelB);
            this.CheckoutLC.Controls.Add(this.CheckoutConfirmB);
            this.CheckoutLC.Controls.Add(this.CheckoutInvoiceNoL);
            this.CheckoutLC.Controls.Add(this.CheckoutChangeL);
            this.CheckoutLC.Controls.Add(this.CheckoutPriceL);
            this.CheckoutLC.Controls.Add(this.CheckoutPaymentMTB);
            this.CheckoutLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutLC.ForeColor = System.Drawing.Color.Black;
            this.CheckoutLC.Location = new System.Drawing.Point(0, 0);
            this.CheckoutLC.Name = "CheckoutLC";
            // 
            // 
            // 
            this.CheckoutLC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.CheckoutInvoiceNoLCI,
            this.CheckoutPaymentLCI,
            this.CheckoutPriceLCI,
            this.CheckoutChangeLCI,
            this.CheckoutCancelLCI,
            this.CheckoutConfirmLCI});
            this.CheckoutLC.Size = new System.Drawing.Size(384, 261);
            this.CheckoutLC.TabIndex = 0;
            // 
            // CheckoutCancelB
            // 
            this.CheckoutCancelB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CheckoutCancelB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CheckoutCancelB.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.CheckoutCancelB.Location = new System.Drawing.Point(4, 209);
            this.CheckoutCancelB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutCancelB.Name = "CheckoutCancelB";
            this.CheckoutCancelB.Size = new System.Drawing.Size(107, 42);
            this.CheckoutCancelB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutCancelB.Symbol = "";
            this.CheckoutCancelB.TabIndex = 4;
            this.CheckoutCancelB.Text = "Cancel";
            this.CheckoutCancelB.Click += new System.EventHandler(this.CheckoutCancelB_Click);
            // 
            // CheckoutConfirmB
            // 
            this.CheckoutConfirmB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CheckoutConfirmB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CheckoutConfirmB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CheckoutConfirmB.Location = new System.Drawing.Point(119, 209);
            this.CheckoutConfirmB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutConfirmB.Name = "CheckoutConfirmB";
            this.CheckoutConfirmB.Size = new System.Drawing.Size(261, 42);
            this.CheckoutConfirmB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutConfirmB.Symbol = "";
            this.CheckoutConfirmB.TabIndex = 5;
            this.CheckoutConfirmB.Text = "Confirm Checkout";
            // 
            // CheckoutInvoiceNoL
            // 
            this.CheckoutInvoiceNoL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutInvoiceNoL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutInvoiceNoL.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.CheckoutInvoiceNoL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutInvoiceNoL.Location = new System.Drawing.Point(67, 4);
            this.CheckoutInvoiceNoL.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutInvoiceNoL.Name = "CheckoutInvoiceNoL";
            this.CheckoutInvoiceNoL.Size = new System.Drawing.Size(313, 42);
            this.CheckoutInvoiceNoL.TabIndex = 0;
            this.CheckoutInvoiceNoL.Text = "<INVOICE NO>";
            // 
            // CheckoutChangeL
            // 
            this.CheckoutChangeL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutChangeL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutChangeL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.CheckoutChangeL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutChangeL.Location = new System.Drawing.Point(67, 133);
            this.CheckoutChangeL.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutChangeL.Name = "CheckoutChangeL";
            this.CheckoutChangeL.Size = new System.Drawing.Size(313, 42);
            this.CheckoutChangeL.TabIndex = 3;
            this.CheckoutChangeL.Text = "<CHANGE>";
            // 
            // CheckoutPriceL
            // 
            this.CheckoutPriceL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutPriceL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutPriceL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.CheckoutPriceL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutPriceL.Location = new System.Drawing.Point(67, 83);
            this.CheckoutPriceL.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutPriceL.Name = "CheckoutPriceL";
            this.CheckoutPriceL.Size = new System.Drawing.Size(313, 42);
            this.CheckoutPriceL.TabIndex = 2;
            this.CheckoutPriceL.Text = "<PRICE>";
            // 
            // CheckoutPaymentMTB
            // 
            this.CheckoutPaymentMTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutPaymentMTB.BackgroundStyle.Class = "TextBoxBorder";
            this.CheckoutPaymentMTB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutPaymentMTB.ButtonClear.Visible = true;
            this.CheckoutPaymentMTB.DisabledBackColor = System.Drawing.Color.White;
            this.CheckoutPaymentMTB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutPaymentMTB.ForeColor = System.Drawing.Color.Black;
            this.CheckoutPaymentMTB.Location = new System.Drawing.Point(67, 54);
            this.CheckoutPaymentMTB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutPaymentMTB.Mask = "Rp ###.###.##0,00";
            this.CheckoutPaymentMTB.Name = "CheckoutPaymentMTB";
            this.CheckoutPaymentMTB.Size = new System.Drawing.Size(313, 47);
            this.CheckoutPaymentMTB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutPaymentMTB.TabIndex = 1;
            this.CheckoutPaymentMTB.Text = "";
            // 
            // CheckoutInvoiceNoLCI
            // 
            this.CheckoutInvoiceNoLCI.Control = this.CheckoutInvoiceNoL;
            this.CheckoutInvoiceNoLCI.Height = 50;
            this.CheckoutInvoiceNoLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutInvoiceNoLCI.Name = "CheckoutInvoiceNoLCI";
            this.CheckoutInvoiceNoLCI.Text = "Invoice No:";
            this.CheckoutInvoiceNoLCI.Width = 100;
            this.CheckoutInvoiceNoLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutPaymentLCI
            // 
            this.CheckoutPaymentLCI.Control = this.CheckoutPaymentMTB;
            this.CheckoutPaymentLCI.Height = 55;
            this.CheckoutPaymentLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutPaymentLCI.Name = "CheckoutPaymentLCI";
            this.CheckoutPaymentLCI.Text = "Payment:";
            this.CheckoutPaymentLCI.Width = 100;
            this.CheckoutPaymentLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutPriceLCI
            // 
            this.CheckoutPriceLCI.Control = this.CheckoutPriceL;
            this.CheckoutPriceLCI.Height = 50;
            this.CheckoutPriceLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutPriceLCI.Name = "CheckoutPriceLCI";
            this.CheckoutPriceLCI.Text = "Price:";
            this.CheckoutPriceLCI.Width = 100;
            this.CheckoutPriceLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutChangeLCI
            // 
            this.CheckoutChangeLCI.Control = this.CheckoutChangeL;
            this.CheckoutChangeLCI.Height = 50;
            this.CheckoutChangeLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutChangeLCI.Name = "CheckoutChangeLCI";
            this.CheckoutChangeLCI.Text = "Change:";
            this.CheckoutChangeLCI.Width = 100;
            this.CheckoutChangeLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutCancelLCI
            // 
            this.CheckoutCancelLCI.Control = this.CheckoutCancelB;
            this.CheckoutCancelLCI.Height = 50;
            this.CheckoutCancelLCI.MinSize = new System.Drawing.Size(32, 20);
            this.CheckoutCancelLCI.Name = "CheckoutCancelLCI";
            this.CheckoutCancelLCI.Width = 30;
            this.CheckoutCancelLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutConfirmLCI
            // 
            this.CheckoutConfirmLCI.Control = this.CheckoutConfirmB;
            this.CheckoutConfirmLCI.Height = 31;
            this.CheckoutConfirmLCI.MinSize = new System.Drawing.Size(32, 20);
            this.CheckoutConfirmLCI.Name = "CheckoutConfirmLCI";
            this.CheckoutConfirmLCI.Width = 70;
            this.CheckoutConfirmLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.CheckoutLC);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Checkout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout | Orion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Checkout_FormClosed);
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.CheckoutLC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Layout.LayoutControl CheckoutLC;
        private DevComponents.DotNetBar.ButtonX CheckoutCancelB;
        private DevComponents.DotNetBar.ButtonX CheckoutConfirmB;
        private DevComponents.DotNetBar.LabelX CheckoutInvoiceNoL;
        private DevComponents.DotNetBar.LabelX CheckoutChangeL;
        private DevComponents.DotNetBar.LabelX CheckoutPriceL;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv CheckoutPaymentMTB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutInvoiceNoLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutPaymentLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutPriceLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutChangeLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutCancelLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutConfirmLCI;
    }
}