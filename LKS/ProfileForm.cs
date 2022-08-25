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
    public partial class ProfileForm : Form
    {

        private CustomerController customerController = new CustomerController();
        private LKSEntities db = new LKSEntities();
        private int customerID;

        public ProfileForm()
        {
            InitializeComponent();
            txtFN.Enabled = false;
            txtNumberPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtPin.Enabled = false;
            txtAddress.Enabled = false;
            txtLN.Enabled = false;

            btnSaveName.Visible = false;
            btnSaveLN.Visible = false;
            btnSavePin.Visible = false;
            btnSavEmail.Visible = false;
            btnSaveAddress.Visible = false;
            btnSavePhone.Visible = false;

            labelErrName.Visible = false;
            labelErrLN.Visible = false;
            labelErrEmail.Visible = false;
            labelErrPIN.Visible = false;
            labelErrPhone.Visible = false;

            customerID = customerController.GetAppData().LoginCustomerID;
            var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>().First<customer>();
            txtFN.Text = query.first_name;
            txtLN.Text = query.last_name;
            txtNumberPhone.Text = query.phone;
            txtEmail.Text = query.email;
            txtPin.Text = query.password;
            txtAddress.Text = query.address;


        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            txtFN.Enabled = true;
            btnEditName.Visible = false;
            btnSaveName.Visible = true;
        }

        private void btnEditPin_Click(object sender, EventArgs e)
        {
            txtPin.Enabled = true;
            btnEditPin.Visible = false;
            btnSavePin.Visible = true;
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
            btnSaveAddress.Visible = true;
            btnEditAddress.Visible = false;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            if (txtFN.Text != "")
            {
                var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>()
                    .First<customer>();
                query.first_name = txtFN.Text;
                db.SaveChanges();
                btnSaveName.Visible = false;
                btnEditName.Visible = true;
                txtFN.Enabled = false;
            }
            else
            {
                labelErrName.Visible = true;
                labelErrName.Text = "Please input first name";
            }
        }

        private void btnSavePin_Click(object sender, EventArgs e)
        {
            if (txtPin.Text != "")
            {
                var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>()
                    .First<customer>();
                query.password = txtPin.Text;
                db.SaveChanges();
                btnSavePin.Visible = false;
                btnEditPin.Visible = true;
                txtPin.Enabled = false;
            }
            else
            {
                labelErrPIN.Visible = true;
                labelErrPIN.Text = "Please input password";
            }
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>()
                    .First<customer>();
            query.address = txtAddress.Text;
            db.SaveChanges();
            btnSaveAddress.Visible = false;
            btnEditAddress.Visible = true;
            txtAddress.Enabled = false;
        }

        private void btnEditLN_Click(object sender, EventArgs e)
        {
            btnEditLN.Visible = false;
            btnSaveLN.Visible = true;
            txtLN.Enabled = true;
        }

        private void btnSaveLN_Click(object sender, EventArgs e)
        {
            if (txtLN.Text != "")
            {
                var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>()
                    .First<customer>();
                query.last_name = txtLN.Text;
                db.SaveChanges();
                btnEditLN.Visible = true;
                btnSaveLN.Visible = false;
                txtLN.Enabled = false;
            } else
            {
                labelErrLN.Visible = true;
                labelErrLN.Text = "Please input last name";
            }
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            btnEditPhone.Visible = false;
            btnSavePhone.Visible = true;
            txtNumberPhone.Enabled = true;
        }

        private void btnSavePhone_Click(object sender, EventArgs e)
        {
            if(txtNumberPhone.Text != "")
            {
                var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>()
                    .First<customer>();
                query.phone = txtNumberPhone.Text;
                db.SaveChanges();
                btnEditPhone.Visible = true;
                btnSavePhone.Visible = false;
                txtNumberPhone.Enabled = false;
            } else
            {
                labelErrPhone.Visible = true;
                labelErrPhone.Text = "Please input Phone number";
            }
            
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            btnEditEmail.Visible = false;
            btnSavEmail.Visible = true;
            txtEmail.Enabled = true;
        }

        private void btnSavEmail_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "")
            {
                var query = db.customers.Where(col => customerID == col.id_customer).ToList<customer>()
                    .First<customer>();
                query.email = txtEmail.Text;
                db.SaveChanges();
                btnEditEmail.Visible = true;
                btnSavEmail.Visible = false;
                txtEmail.Enabled = false;
            } else
            {
                labelErrEmail.Visible = true;
                labelErrEmail.Text = "Please input email";
            }
        }
    }
}
