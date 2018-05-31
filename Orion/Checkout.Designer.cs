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
            this.CheckoutInputAmountMTB = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.CheckoutCancelLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutConfirmLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutInvoiceNoLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutChangeLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutPriceLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.CheckoutInputAmmountLCI = new DevComponents.DotNetBar.Layout.LayoutControlItem();
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
            this.CheckoutLC.Controls.Add(this.CheckoutInputAmountMTB);
            this.CheckoutLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutLC.ForeColor = System.Drawing.Color.Black;
            this.CheckoutLC.Location = new System.Drawing.Point(0, 0);
            this.CheckoutLC.Name = "CheckoutLC";
            // 
            // 
            // 
            this.CheckoutLC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.CheckoutInvoiceNoLCI,
            this.CheckoutInputAmmountLCI,
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
            this.CheckoutCancelB.Location = new System.Drawing.Point(4, 126);
            this.CheckoutCancelB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutCancelB.Name = "CheckoutCancelB";
            this.CheckoutCancelB.Size = new System.Drawing.Size(184, 23);
            this.CheckoutCancelB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutCancelB.TabIndex = 4;
            this.CheckoutCancelB.Text = "Cancel";
            // 
            // CheckoutConfirmB
            // 
            this.CheckoutConfirmB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CheckoutConfirmB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CheckoutConfirmB.Location = new System.Drawing.Point(196, 126);
            this.CheckoutConfirmB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutConfirmB.Name = "CheckoutConfirmB";
            this.CheckoutConfirmB.Size = new System.Drawing.Size(184, 23);
            this.CheckoutConfirmB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.CheckoutInvoiceNoL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutInvoiceNoL.Location = new System.Drawing.Point(70, 4);
            this.CheckoutInvoiceNoL.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutInvoiceNoL.Name = "CheckoutInvoiceNoL";
            this.CheckoutInvoiceNoL.Size = new System.Drawing.Size(310, 23);
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
            this.CheckoutChangeL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutChangeL.Location = new System.Drawing.Point(70, 95);
            this.CheckoutChangeL.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutChangeL.Name = "CheckoutChangeL";
            this.CheckoutChangeL.Size = new System.Drawing.Size(310, 23);
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
            this.CheckoutPriceL.ForeColor = System.Drawing.Color.Black;
            this.CheckoutPriceL.Location = new System.Drawing.Point(70, 64);
            this.CheckoutPriceL.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutPriceL.Name = "CheckoutPriceL";
            this.CheckoutPriceL.Size = new System.Drawing.Size(310, 23);
            this.CheckoutPriceL.TabIndex = 2;
            this.CheckoutPriceL.Text = "<PRICE>";
            // 
            // CheckoutInputAmountMTB
            // 
            this.CheckoutInputAmountMTB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CheckoutInputAmountMTB.BackgroundStyle.Class = "TextBoxBorder";
            this.CheckoutInputAmountMTB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckoutInputAmountMTB.ButtonClear.Visible = true;
            this.CheckoutInputAmountMTB.DisabledBackColor = System.Drawing.Color.White;
            this.CheckoutInputAmountMTB.ForeColor = System.Drawing.Color.Black;
            this.CheckoutInputAmountMTB.Location = new System.Drawing.Point(70, 35);
            this.CheckoutInputAmountMTB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.CheckoutInputAmountMTB.Name = "CheckoutInputAmountMTB";
            this.CheckoutInputAmountMTB.Size = new System.Drawing.Size(310, 21);
            this.CheckoutInputAmountMTB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckoutInputAmountMTB.TabIndex = 1;
            this.CheckoutInputAmountMTB.Text = "";
            // 
            // CheckoutCancelLCI
            // 
            this.CheckoutCancelLCI.Control = this.CheckoutCancelB;
            this.CheckoutCancelLCI.Height = 31;
            this.CheckoutCancelLCI.MinSize = new System.Drawing.Size(32, 20);
            this.CheckoutCancelLCI.Name = "CheckoutCancelLCI";
            this.CheckoutCancelLCI.Width = 50;
            this.CheckoutCancelLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutConfirmLCI
            // 
            this.CheckoutConfirmLCI.Control = this.CheckoutConfirmB;
            this.CheckoutConfirmLCI.Height = 31;
            this.CheckoutConfirmLCI.MinSize = new System.Drawing.Size(32, 20);
            this.CheckoutConfirmLCI.Name = "CheckoutConfirmLCI";
            this.CheckoutConfirmLCI.Width = 50;
            this.CheckoutConfirmLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutInvoiceNoLCI
            // 
            this.CheckoutInvoiceNoLCI.Control = this.CheckoutInvoiceNoL;
            this.CheckoutInvoiceNoLCI.Height = 31;
            this.CheckoutInvoiceNoLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutInvoiceNoLCI.Name = "CheckoutInvoiceNoLCI";
            this.CheckoutInvoiceNoLCI.Text = "Invoice No.:";
            this.CheckoutInvoiceNoLCI.Width = 100;
            this.CheckoutInvoiceNoLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutChangeLCI
            // 
            this.CheckoutChangeLCI.Control = this.CheckoutChangeL;
            this.CheckoutChangeLCI.Height = 31;
            this.CheckoutChangeLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutChangeLCI.Name = "CheckoutChangeLCI";
            this.CheckoutChangeLCI.Text = "Change:";
            this.CheckoutChangeLCI.Width = 100;
            this.CheckoutChangeLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutPriceLCI
            // 
            this.CheckoutPriceLCI.Control = this.CheckoutPriceL;
            this.CheckoutPriceLCI.Height = 31;
            this.CheckoutPriceLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutPriceLCI.Name = "CheckoutPriceLCI";
            this.CheckoutPriceLCI.Text = "Price:";
            this.CheckoutPriceLCI.Width = 100;
            this.CheckoutPriceLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // CheckoutInputAmmountLCI
            // 
            this.CheckoutInputAmmountLCI.Control = this.CheckoutInputAmountMTB;
            this.CheckoutInputAmmountLCI.Height = 29;
            this.CheckoutInputAmmountLCI.MinSize = new System.Drawing.Size(64, 18);
            this.CheckoutInputAmmountLCI.Name = "CheckoutInputAmmountLCI";
            this.CheckoutInputAmmountLCI.Text = "Label:";
            this.CheckoutInputAmmountLCI.Width = 100;
            this.CheckoutInputAmmountLCI.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.CheckoutLC);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checkout";
            this.Text = "Checkout | Orion";
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
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv CheckoutInputAmountMTB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutInvoiceNoLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutInputAmmountLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutPriceLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutChangeLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutCancelLCI;
        private DevComponents.DotNetBar.Layout.LayoutControlItem CheckoutConfirmLCI;
    }
}