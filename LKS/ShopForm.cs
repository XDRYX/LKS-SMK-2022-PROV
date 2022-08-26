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
    public partial class ShopForm : Form
    {

        private CustomerController customerController = new CustomerController();
        private LKSEntities db = new LKSEntities();
        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            PopuloateProduct();
        }

        private void PopuloateProduct()
        {
            panelProd.Controls.Clear();
            var query = db.products.ToList();
            if(txtSearch.Text != null)
            {
                query = query.Where(col => col.name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }
            if(txtPriceStart.Text != "" && txtPriceEnd.Text != "")
            {
                query = query.Where(col => col.price >= Convert.ToInt32(txtPriceStart.Text) && col.price <= Convert.ToInt32(txtPriceEnd.Text)).ToList();
            }

            for(int i = query.Count -1; i >= 0; i--)
            {
                var itemProduct = query[i];
                var ShopItemComponent = new ShopItem(itemProduct, this)
                {
                    Dock = DockStyle.Top
                };
                ShopItemComponent.BringToFront();
                panelProd.Controls.Add(ShopItemComponent);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PopuloateProduct();
        }

        private void txtPriceStart_SelectedItemChanged(object sender, EventArgs e)
        {
            PopuloateProduct();
        }

        private void txtPriceEnd_SelectedItemChanged(object sender, EventArgs e)
        {
            PopuloateProduct();
        }
    }
}
