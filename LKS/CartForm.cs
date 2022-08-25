using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    public partial class CartForm : Form
    {

        private CustomerController customerController = new CustomerController();
        private LKSEntities db = new LKSEntities();
        private int total = 0;
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            PopulateCartItem();
        }

        private void PopulateCartItem()
        {
            var customerData = customerController.GetAppData();
            int subTotal = 0;
            for(int i = 0; i < customerData.CartList.Count; i++)
            {
                
                var CartItem = new CartItem(customerData.CartList[i])
                {
                    Dock = DockStyle.Top
                };
                CartItem.BringToFront();

                var productID = customerData.CartList[i].ProductID;
                var product = db.products.Where(col => col.id == productID).First();
                subTotal = customerData.CartList[i].ProductQty * Convert.ToInt32(product.price);
                
                panelCartList.Controls.Add(CartItem);
            }
            int fee = Convert.ToInt32(subTotal * 0.05);
            total = subTotal + fee;
            labelSubTotal.Text = subTotal.ToString();
            labelFee.Text = fee.ToString();
            labelTotal.Text = total.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var customerCart = customerController.GetAppData().CartList;
            var customerID = customerController.GetAppData().LoginCustomerID;
            if (customerCart.Count > 0)
            {
                for(int i = 0; i < customerCart.Count; i++)
                {
                    db.orders.Add(new order
                    {
                        id_customer = customerID,
                        id_product = customerCart[i].ProductID,
                        order_date = DateTime.Now,
                        order_qty = customerCart[i].ProductQty.ToString(),
                    });
                    db.SaveChanges();
                }

                customerController.ClarAllCart();
                PopulateCartItem();

                var alphaNum = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                var paymentCode = "";

                while (paymentCode.Length < 12)
                {
                    var randomIndex = new Random().Next(0, alphaNum.Length);
                    var randomAlphaNum = alphaNum[randomIndex];

                    if (!paymentCode.Contains(randomAlphaNum))
                    {
                        paymentCode += randomAlphaNum;
                    }
                }

                this.Hide();
                new NotifForm(paymentCode).Show();
            }
        }
    }
}
