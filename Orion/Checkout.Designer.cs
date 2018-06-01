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
            this.CheckoutPaymentTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CheckoutCancelB = new DevComponents.DotNetBar.ButtonX();
            this.CheckoutConfirmB = new DevComponents.DotNetBar.ButtonX();
            this.CheckoutInvoiceNoL = new DevComponents.DotNetBar.LabelX();
            this.CheckoutChangeL = new DevComponents.DotNetBar.LabelX();
            this.CheckoutPriceL = new DevComponents.DotNetBar.LabelX();
            this.CheckoutInvoiceNoLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutPaymentLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutPriceLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutChangeLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutCancelLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutConfirmLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SelectedH = new DevComponents.DotNetBar.Validator.Highlighter();
            this.layoutGroup1 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.CheckoutPaymentCurrencySB = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.CheckoutPaymentCurrencyLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckoutLC
            // 
            this.CheckoutLC.BackColor = System.Drawing.Color.White;
            this.CheckoutLC.Controls.Add(this.CheckoutPaymentCurrencySB);
            this.CheckoutLC.Controls.Add(this.CheckoutPaymentTB);
            this.CheckoutLC.Controls.Add(this.CheckoutCancelB);
            this.CheckoutLC.Controls.Add(this.CheckoutConfirmB);
            this.CheckoutLC.Controls.Add(this.CheckoutInvoiceNoL);
            this.CheckoutLC.Controls.Add(this.CheckoutChangeL);
            this.CheckoutLC.Controls.Add(this.CheckoutPriceL);
            this.CheckoutLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutLC.ForeColor = System.Drawing.Color.Black;
            this.CheckoutLC.Location = new System.Drawing.Point(0, 0);
            this.CheckoutLC.Name = "CheckoutLC";
            // 
            // 
            // 
            this.CheckoutLC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.CheckoutInvoiceNoLCI,
            this.layoutGroup1});
            this.CheckoutLC.Size = new System.Drawing.Size(384, 241);
            this.CheckoutLC.TabIndex = 0;
            // 
            // CheckoutPaymentTB
            // 
            this.CheckoutPaymentTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutPaymentTB.Border.Class = "TextBoxBorder";
            this.CheckoutPaymentTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutPaymentTB.DisabledBackColor = System.Drawing.Color.White;
            this.CheckoutPaymentTB.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutPaymentTB.ForeColor = System.Drawing.Color.Black;
            this.SelectedH.SetHighlightOnFocus(this.CheckoutPaymentTB, true);
            this.CheckoutPaymentTB.Location = new System.Drawing.Point(108, 53);
            this.CheckoutPaymentTB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutPaymentTB.Name = "CheckoutPaymentTB";
            this.CheckoutPaymentTB.PreventEnterBeep = true;
            this.CheckoutPaymentTB.Size = new System.Drawing.Size(268, 43);
            this.CheckoutPaymentTB.TabIndex = 2;
            this.CheckoutPaymentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CheckoutPaymentTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckoutPaymentTB_KeyDown);
            // 
            // CheckoutCancelB
            // 
            this.CheckoutCancelB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CheckoutCancelB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CheckoutCancelB.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.CheckoutCancelB.Location = new System.Drawing.Point(8, 195);
            this.CheckoutCancelB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutCancelB.Name = "CheckoutCancelB";
            this.CheckoutCancelB.Size = new System.Drawing.Size(104, 42);
            this.CheckoutCancelB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutCancelB.Symbol = "";
            this.CheckoutCancelB.TabIndex = 5;
            this.CheckoutCancelB.Text = "Cancel";
            this.CheckoutCancelB.Click += new System.EventHandler(this.CheckoutCancelB_Click);
            // 
            // CheckoutConfirmB
            // 
            this.CheckoutConfirmB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CheckoutConfirmB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CheckoutConfirmB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CheckoutConfirmB.Location = new System.Drawing.Point(120, 195);
            this.CheckoutConfirmB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutConfirmB.Name = "CheckoutConfirmB";
            this.CheckoutConfirmB.Size = new System.Drawing.Size(256, 42);
            this.CheckoutConfirmB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutConfirmB.Symbol = "";
            this.CheckoutConfirmB.TabIndex = 6;
            this.CheckoutConfirmB.Text = "Confirm Checkout";
            // 
            // CheckoutInvoiceNoL
            // 
            this.CheckoutInvoiceNoL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutInvoiceNoL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutInvoiceNoL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutInvoiceNoL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutInvoiceNoL.Location = new System.Drawing.Point(67, 4);
            this.CheckoutInvoiceNoL.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutInvoiceNoL.Name = "CheckoutInvoiceNoL";
            this.CheckoutInvoiceNoL.Size = new System.Drawing.Size(313, 37);
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
            this.CheckoutChangeL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutChangeL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutChangeL.Location = new System.Drawing.Point(61, 150);
            this.CheckoutChangeL.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutChangeL.Name = "CheckoutChangeL";
            this.CheckoutChangeL.Size = new System.Drawing.Size(315, 37);
            this.CheckoutChangeL.Symbol = "Rp";
            this.CheckoutChangeL.TabIndex = 4;
            this.CheckoutChangeL.Text = "<CHANGE>";
            this.CheckoutChangeL.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // CheckoutPriceL
            // 
            this.CheckoutPriceL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutPriceL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutPriceL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutPriceL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutPriceL.Location = new System.Drawing.Point(61, 105);
            this.CheckoutPriceL.Margin = new System.Windows.Forms.Padding(0);
            this.CheckoutPriceL.Name = "CheckoutPriceL";
            this.CheckoutPriceL.Size = new System.Drawing.Size(315, 37);
            this.CheckoutPriceL.Symbol = "Rp";
            this.CheckoutPriceL.TabIndex = 3;
            this.CheckoutPriceL.Text = "<PRICE>";
            this.CheckoutPriceL.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // CheckoutInvoiceNoLCI
            // 
            this.CheckoutInvoiceNoLCI.Control = this.CheckoutInvoiceNoL;
            this.CheckoutInvoiceNoLCI.Height = 45;
            this.CheckoutInvoiceNoLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutInvoiceNoLCI.Name = "CheckoutInvoiceNoLCI";
            this.CheckoutInvoiceNoLCI.Text = "Invoice No:";
            this.CheckoutInvoiceNoLCI.Width = 100;
            this.CheckoutInvoiceNoLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutPaymentLCI
            // 
            this.CheckoutPaymentLCI.Control = this.CheckoutPaymentTB;
            this.CheckoutPaymentLCI.Height = 52;
            this.CheckoutPaymentLCI.MinSize = new System.Drawing.Size(120, 0);
            this.CheckoutPaymentLCI.Name = "CheckoutPaymentLCI";
            this.CheckoutPaymentLCI.Width = 100;
            this.CheckoutPaymentLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutPriceLCI
            // 
            this.CheckoutPriceLCI.Control = this.CheckoutPriceL;
            this.CheckoutPriceLCI.Height = 45;
            this.CheckoutPriceLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutPriceLCI.Name = "CheckoutPriceLCI";
            this.CheckoutPriceLCI.Text = "Price:";
            this.CheckoutPriceLCI.Width = 100;
            this.CheckoutPriceLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutChangeLCI
            // 
            this.CheckoutChangeLCI.Control = this.CheckoutChangeL;
            this.CheckoutChangeLCI.Height = 45;
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
            // layoutGroup1
            // 
            this.layoutGroup1.Height = 55;
            this.layoutGroup1.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.CheckoutPaymentCurrencyLCI,
            this.CheckoutPaymentLCI,
            this.CheckoutPriceLCI,
            this.CheckoutChangeLCI,
            this.CheckoutCancelLCI,
            this.CheckoutConfirmLCI});
            this.layoutGroup1.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup1.Name = "layoutGroup1";
            this.layoutGroup1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup1.Width = 100;
            this.layoutGroup1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutPaymentCurrencySB
            // 
            // 
            // 
            // 
            this.CheckoutPaymentCurrencySB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutPaymentCurrencySB.Location = new System.Drawing.Point(61, 53);
            this.CheckoutPaymentCurrencySB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutPaymentCurrencySB.Name = "CheckoutPaymentCurrencySB";
            this.CheckoutPaymentCurrencySB.Size = new System.Drawing.Size(39, 44);
            this.CheckoutPaymentCurrencySB.Symbol = "Rp";
            this.CheckoutPaymentCurrencySB.SymbolSize = 18F;
            this.CheckoutPaymentCurrencySB.TabIndex = 1;
            // 
            // CheckoutPaymentCurrencyLCI
            // 
            this.CheckoutPaymentCurrencyLCI.Control = this.CheckoutPaymentCurrencySB;
            this.CheckoutPaymentCurrencyLCI.Height = 31;
            this.CheckoutPaymentCurrencyLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutPaymentCurrencyLCI.Name = "CheckoutPaymentCurrencyLCI";
            this.CheckoutPaymentCurrencyLCI.Text = "Payment:";
            this.CheckoutPaymentCurrencyLCI.Width = 100;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.CheckoutLC);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutInvoiceNoLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutPriceLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutChangeLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutCancelLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutConfirmLCI;
        private DevComponents.DotNetBar.Controls.TextBoxX CheckoutPaymentTB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutPaymentLCI;
        private DevComponents.DotNetBar.Validator.Highlighter SelectedH;
        private DevComponents.DotNetBar.Controls.SymbolBox CheckoutPaymentCurrencySB;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutPaymentCurrencyLCI;
    }
}