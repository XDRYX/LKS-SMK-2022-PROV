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
    public partial class AddToCartForm : Form
    {
        private CustomerController customerController = new CustomerController();
        private LKSEntities db = new LKSEntities();
        public CartModel product;
        public AddToCartForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopForm().Show();
        }

        private void btnDecerment_Click(object sender, EventArgs e)
        {
            if(product.ProductQty >= 1)
            {
                product.ProductQty--;
                labelCount.Text = product.ProductQty.ToString();
            }
        }

        private void btnIncerment_Click(object sender, EventArgs e)
        {
            product.ProductQty++;
            labelCount.Text = product.ProductQty.ToString();
        }

        private void AddToCartForm_Load(object sender, EventArgs e)
        {
            var query = db.products.Where(col => col.id == product.ProductID).ToArray();
            labelName.Text = query[0].name;
            labelDesc.Text = query[0].description;
            labelPrice.Text = query[0].price.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var customerData = customerController.GetAppData();
            var customerCart = customerController.GetAppData().CartList.Where(col => col.ProductID == product.ProductID).Select(col => col.ProductQty).ToArray();
            var quantitySekarang = 0;

            // apabila cart customerData lebih besar dari 0 maka kuantitas nya di set dari kunatitas CustomerData
            if(customerCart.Length > 0)
            {
                quantitySekarang = customerCart[0];
            }

            var stock = db.products.Where(col => col.id == product.ProductID).Select(col => col.stock).First();
            // tamabhkan quantity sekarang dengan kuantiti di Customer Data dan kurangi dengan stock, 
            // jika stock lebih besar daripada 0/ jika stock tersedia
            if (stock - (product.ProductQty + quantitySekarang) >= 0)
            {
                if (quantitySekarang == 0)
                {
                    customerData.CartList.Add(new CartModel()
                    {
                        ProductID = product.ProductID,
                        ProductQty = product.ProductQty
                    });
                } else
                {
                    var query = customerData.CartList.Where(col => col.ProductID == product.ProductID).First();
                    query.ProductQty = quantitySekarang + product.ProductQty;
                }
                customerController.SaveData(customerData);

                // return to ShopForm
                this.Hide();
                new ShopForm().Show();
            } else
            {
                // jika stock habis
                MessageBox.Show("Stock barang habis");
            }
        }
    }
}
