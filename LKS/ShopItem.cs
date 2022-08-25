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
    public partial class ShopItem : UserControl
    {
        private product product;
        private ShopForm parentForm;
        public ShopItem(product product, ShopForm parentForm)
        {
            InitializeComponent();
            this.product = product;
            this.parentForm = parentForm;
        }

        private void ShopItem_Load(object sender, EventArgs e)
        {
            //productImage.Image = Image.FromFile(Application.StartupPath + "\\images\\products\\11_yakult.jpg");
            labelName.Text = product.name;
            labelPrice.Text = product.price.ToString();
            labelStock.Text = product.stock.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            parentForm.Hide();
            new AddToCartForm()
            {
                product = new CartModel()
                {
                    ProductID = product.id,
                    ProductQty = 1
                }
            }.Show();
        }
    }
}
