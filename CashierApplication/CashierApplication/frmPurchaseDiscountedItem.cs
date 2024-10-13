using CashierApplication.ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            string itemTxt = itemTxtBx.Text;
            double priceNum = Convert.ToDouble(this.priceTxtBx.Text);
            int quantityNum = Convert.ToInt32(this.quantityTxtBx.Text);
            double discountNum = Convert.ToDouble(this.discountTxtBx.Text);

            DiscountedItem discountedItem = new DiscountedItem(itemTxt, priceNum, quantityNum, discountNum);

            string totalPrice = discountedItem.getTotalPrice().ToString();
            totalAmountValueTxt.Text = totalPrice;

            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string itemTxt = itemTxtBx.Text;
            double priceNum = Convert.ToDouble(this.priceTxtBx.Text);
            int quantityNum = Convert.ToInt32(this.quantityTxtBx.Text);
            double discountNum = Convert.ToDouble(this.discountTxtBx.Text);

            DiscountedItem discountedItem = new DiscountedItem(itemTxt, priceNum, quantityNum, discountNum);

            double paymentReceivedNum = Convert.ToDouble(this.paymentReceivedTxtBx.Text);
            discountedItem.setPayment(paymentReceivedNum);
            string change = discountedItem.getChange().ToString();
            changeValueTxt.Text = change;
        }
    }
    namespace ItemNamespace {
        abstract class Item {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            private double total_price;
            public Item(string name, double price, int quantity)
            {
                this.item_name = name;
                this.item_quantity = quantity;
                this.total_price = price;
            }
            public double getTotalPrice() { 
                return this.total_price;
            }
            public abstract void setPayment(double amount);
        }
        class DiscountedItem:Item {
            private double item_discount;
            private double discounted_price;

            private double payment_amount;
            private double change;

            public DiscountedItem(string name, double price, int quantity, double discount):base(name,price,quantity) { 
                this.item_name = name;
                this.item_price = price;
                this.item_quantity = quantity;
                this.item_discount = discount;

                this.discounted_price = (item_price-(item_price* (item_discount*0.01)))*quantity;
                
            }
            public double getTotalPrice() {
                return this.discounted_price;
            }
            public override void setPayment(double amount)
            {
                this.payment_amount = amount;
            }
            public double getChange() {
                this.change = this.payment_amount - this.discounted_price;
                return this.change;
            }
        }
    }
}
