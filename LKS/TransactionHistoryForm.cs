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
    public partial class TransactionHistoryForm : Form
    {

        private LKSEntities db = new LKSEntities();
        private CustomerController customerController = new CustomerController();
        public TransactionHistoryForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            var customerID = customerController.GetAppData().LoginCustomerID;
            var query = db.orders.Where(col => customerID == col.id_customer).ToList();
            for(int i = 0; i < query.Count; i++)
            {
                var cartHistory = new TransactionHistoryItem(query[i])
                {
                    Dock = DockStyle.Top,
                };
                panelItem.Controls.Add(cartHistory);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
