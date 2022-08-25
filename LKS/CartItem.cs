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
    public partial class CartItem : UserControl
    {
        private LKSEntities db = new LKSEntities();
        private CustomerController customerController = new CustomerController();
        private CartModel cartItem;

        public CartItem(CartModel cartData)
        {
            InitializeComponent();
            cartItem = cartData;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            var product = db.products.Where(col => col.id == cartItem.ProductID).ToList()[0];

            // set image
            labelName.Text = product.name;
            labelPrice.Text = product.price.ToString();
            labelQty.Text = customerController.GetAppData().CartList.Where(col => col.ProductID == cartItem.ProductID).First().ProductQty.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddToCartForm()
            {
                product = cartItem,
            }.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure remove this item from cart?", "Remove from cart", MessageBoxButtons.YesNo);
            if(confirmation == DialogResult.Yes)
            {
                customerController.RemoveFromCart(cartItem.ProductID);
            }
        }
    }
}
