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
    public partial class TransactionHistoryItem : UserControl
    {
        private LKSEntities db = new LKSEntities();
        public order historyList;
        public TransactionHistoryItem(order orderData)
        {
            InitializeComponent();
            historyList = orderData;
        }

        private void TransactionHistoryItem_Load(object sender, EventArgs e)
        {
            var product = db.products.Where(col => col.id == historyList.id_product).ToList().First();
            labelName.Text = product.name;
            labelPrice.Text = product.price.ToString();
            labelQty.Text = historyList.order_qty.ToString();
        }
    }
}
