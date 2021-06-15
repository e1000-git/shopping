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

namespace ShoppingForm.Forms
{
    public partial class FormWorkers : Form
    {
        shoppingContext db = new shoppingContext();
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void FillDataGrid()
        {
            dtworkerlist.DataSource = db.Workers.Select(x => new
            {
                x.Id,
                x.Fullname,
                x.Email,
                x.Password
            }).ToList();
        }
        private void FormWorkers_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
    }
}
