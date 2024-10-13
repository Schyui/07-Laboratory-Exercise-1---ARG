namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemTxt = new System.Windows.Forms.Label();
            this.itemTxtBx = new System.Windows.Forms.TextBox();
            this.discountTxtBx = new System.Windows.Forms.TextBox();
            this.priceTxtBx = new System.Windows.Forms.TextBox();
            this.quantityTxtBx = new System.Windows.Forms.TextBox();
            this.paymentReceivedTxtBx = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.computeBtn = new System.Windows.Forms.Button();
            this.priceTxt = new System.Windows.Forms.Label();
            this.totalAmountTxt = new System.Windows.Forms.Label();
            this.totalAmountValueTxt = new System.Windows.Forms.Label();
            this.paymentReceivedTxt = new System.Windows.Forms.Label();
            this.changeTxt = new System.Windows.Forms.Label();
            this.changeValueTxt = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemTxt
            // 
            this.itemTxt.AutoSize = true;
            this.itemTxt.Location = new System.Drawing.Point(12, 9);
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(30, 13);
            this.itemTxt.TabIndex = 0;
            this.itemTxt.Text = "Item:";
            // 
            // itemTxtBx
            // 
            this.itemTxtBx.Location = new System.Drawing.Point(12, 25);
            this.itemTxtBx.Name = "itemTxtBx";
            this.itemTxtBx.Size = new System.Drawing.Size(139, 20);
            this.itemTxtBx.TabIndex = 1;
            // 
            // discountTxtBx
            // 
            this.discountTxtBx.Location = new System.Drawing.Point(160, 25);
            this.discountTxtBx.Name = "discountTxtBx";
            this.discountTxtBx.Size = new System.Drawing.Size(100, 20);
            this.discountTxtBx.TabIndex = 2;
            // 
            // priceTxtBx
            // 
            this.priceTxtBx.Location = new System.Drawing.Point(53, 51);
            this.priceTxtBx.Name = "priceTxtBx";
            this.priceTxtBx.Size = new System.Drawing.Size(98, 20);
            this.priceTxtBx.TabIndex = 3;
            // 
            // quantityTxtBx
            // 
            this.quantityTxtBx.Location = new System.Drawing.Point(214, 51);
            this.quantityTxtBx.Name = "quantityTxtBx";
            this.quantityTxtBx.Size = new System.Drawing.Size(46, 20);
            this.quantityTxtBx.TabIndex = 4;
            this.quantityTxtBx.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // paymentReceivedTxtBx
            // 
            this.paymentReceivedTxtBx.Location = new System.Drawing.Point(114, 138);
            this.paymentReceivedTxtBx.Name = "paymentReceivedTxtBx";
            this.paymentReceivedTxtBx.Size = new System.Drawing.Size(78, 20);
            this.paymentReceivedTxtBx.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(198, 136);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(62, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(104, 77);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(75, 23);
            this.computeBtn.TabIndex = 7;
            this.computeBtn.Text = "Compute";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.AutoSize = true;
            this.priceTxt.Location = new System.Drawing.Point(12, 54);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(34, 13);
            this.priceTxt.TabIndex = 8;
            this.priceTxt.Text = "Price:";
            // 
            // totalAmountTxt
            // 
            this.totalAmountTxt.AutoSize = true;
            this.totalAmountTxt.Location = new System.Drawing.Point(40, 110);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.Size = new System.Drawing.Size(72, 13);
            this.totalAmountTxt.TabIndex = 9;
            this.totalAmountTxt.Text = "Total amount:";
            // 
            // totalAmountValueTxt
            // 
            this.totalAmountValueTxt.AutoSize = true;
            this.totalAmountValueTxt.Location = new System.Drawing.Point(111, 110);
            this.totalAmountValueTxt.Name = "totalAmountValueTxt";
            this.totalAmountValueTxt.Size = new System.Drawing.Size(0, 13);
            this.totalAmountValueTxt.TabIndex = 10;
            // 
            // paymentReceivedTxt
            // 
            this.paymentReceivedTxt.AutoSize = true;
            this.paymentReceivedTxt.Location = new System.Drawing.Point(12, 141);
            this.paymentReceivedTxt.Name = "paymentReceivedTxt";
            this.paymentReceivedTxt.Size = new System.Drawing.Size(100, 13);
            this.paymentReceivedTxt.TabIndex = 11;
            this.paymentReceivedTxt.Text = "Payment Received:";
            // 
            // changeTxt
            // 
            this.changeTxt.AutoSize = true;
            this.changeTxt.Location = new System.Drawing.Point(65, 164);
            this.changeTxt.Name = "changeTxt";
            this.changeTxt.Size = new System.Drawing.Size(47, 13);
            this.changeTxt.TabIndex = 12;
            this.changeTxt.Text = "Change:";
            this.changeTxt.Click += new System.EventHandler(this.label6_Click);
            // 
            // changeValueTxt
            // 
            this.changeValueTxt.AutoSize = true;
            this.changeValueTxt.Location = new System.Drawing.Point(118, 164);
            this.changeValueTxt.Name = "changeValueTxt";
            this.changeValueTxt.Size = new System.Drawing.Size(0, 13);
            this.changeValueTxt.TabIndex = 13;
            // 
            // discountTxt
            // 
            this.discountTxt.AutoSize = true;
            this.discountTxt.Location = new System.Drawing.Point(157, 9);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(69, 13);
            this.discountTxt.TabIndex = 14;
            this.discountTxt.Text = "Discount (%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantity:";
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 211);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.changeValueTxt);
            this.Controls.Add(this.changeTxt);
            this.Controls.Add(this.paymentReceivedTxt);
            this.Controls.Add(this.totalAmountValueTxt);
            this.Controls.Add(this.totalAmountTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.paymentReceivedTxtBx);
            this.Controls.Add(this.quantityTxtBx);
            this.Controls.Add(this.priceTxtBx);
            this.Controls.Add(this.discountTxtBx);
            this.Controls.Add(this.itemTxtBx);
            this.Controls.Add(this.itemTxt);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Purchase Discounted Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemTxt;
        private System.Windows.Forms.TextBox itemTxtBx;
        private System.Windows.Forms.TextBox discountTxtBx;
        private System.Windows.Forms.TextBox priceTxtBx;
        private System.Windows.Forms.TextBox quantityTxtBx;
        private System.Windows.Forms.TextBox paymentReceivedTxtBx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.Label totalAmountTxt;
        private System.Windows.Forms.Label totalAmountValueTxt;
        private System.Windows.Forms.Label paymentReceivedTxt;
        private System.Windows.Forms.Label changeTxt;
        private System.Windows.Forms.Label changeValueTxt;
        private System.Windows.Forms.Label discountTxt;
        private System.Windows.Forms.Label label9;
    }
}

