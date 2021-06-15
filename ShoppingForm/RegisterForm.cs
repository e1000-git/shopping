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
    public partial class RegisterForm : Form
    {
        shoppingContext db = new shoppingContext();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnrgstr_Click(object sender, EventArgs e)
        {
            string fullname = txtname.Text;
            string email = txtemail.Text;
            string password = txtpsswrd.Text;
            string confirmpass = txtconpsswrd.Text;
            string[] myarr1 = new string[] { fullname, email, password, confirmpass };
            if (Utilities.IsEmpty(myarr1))
            {
                if(password == confirmpass)
                {
                    Worker myworker = new Worker();
                    myworker.Fullname = fullname;
                    myworker.Email = email;
                    myworker.Password = Utilities.HashMe(password);
                    db.Workers.Add(myworker);
                    db.SaveChanges();
                    MessageBox.Show("Worker was created successfully!");
                }
                else
                {
                    MessageBox.Show("Confirm password is not true!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!");
            }
        }
    }
}
