using ShoppingForm.Helper;
using ShoppingForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingForm
{
    public partial class LoginForm : Form
    {
        shoppingContext db = new shoppingContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpsswrd.Text;
            string[] myarr2 = new string[] { email, password };
            if (Utilities.IsEmpty(myarr2))
            {
                Worker selectedworker = db.Workers.FirstOrDefault(x=>x.Email==email);
                if (selectedworker != null)
                {
                    if (selectedworker.Password == Utilities.HashMe(password))
                    {
                        lblerror.Visible = false;
                        WorkerForm wd = new WorkerForm(selectedworker);
                        wd.ShowDialog();
                    }
                    else
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "Password is not correct!";
                    }
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Email is not correct!";
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Please fill all the fields!";
            }
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            ad.ShowDialog();
        }
    }
}
