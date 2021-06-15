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
    public partial class AdminForm : Form
    {
        private Form activateForm;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childform, object sender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labeltitle.Text = childform.Text;
        }
        private void btnproduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void btnworker_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormWorkers(), sender);
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders(), sender);
        }
    }
}
