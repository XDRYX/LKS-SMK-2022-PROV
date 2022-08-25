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
    public partial class LoginForm : Form
    {

        private CustomerController customerController = new CustomerController();
        private LKSEntities db = new LKSEntities();
        public LoginForm()
        {
            InitializeComponent();
            customerController.CreateCustomerDataFile();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnCustomerLogin();
        }

        public void OnCustomerLogin()
        {
            if(txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please input your email or passowrd");
                return;
            }
            var query = db.customers.Where(col => (txtEmail.Text == col.email || txtEmail.Text == col.phone) && txtPass.Text == col.password);
            if (query != null)
            {
                customerController.CustomerLogin(query.First().id_customer);
                this.Hide();
                new MainForm().Show();
            } else
            {
                MessageBox.Show("User credential not found");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
