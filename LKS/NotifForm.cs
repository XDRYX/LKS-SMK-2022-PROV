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
    public partial class NotifForm : Form
    {
        private string paymentCode = "";
        public NotifForm(string paymentCode)
        {
            InitializeComponent();
           paymentCode = paymentCode;
            labelPaymentCode.Text = paymentCode;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TransactionHistoryForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
