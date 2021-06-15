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

namespace ShoppingForm.Forms
{
    public partial class FormProducts : Form
    {
        shoppingContext db = new shoppingContext();

        public FormProducts()
        {
            InitializeComponent();
        }

        private void FillDataGrid()
        {
            dtgproductlist.DataSource = db.Products.Select(x => new
            {
                x.Id,
                x.Name,
                Category=x.Category.Name,
                x.Quantity,
                x.Price,
                x.ProductionDate
            }).ToList();
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void dtgproductlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string categoryname = cmbcategories.Text;
            string productname = cmbproduct.Text;
            int quantity = (int)nmrcount.Value;
            decimal price = nmrprice.Value;
            string[] myarr1 = new string[] { categoryname, productname };
            if (Utilities.IsEmpty(myarr1))
            {

                Product product = new Product();
                product.Name = productname;
                product.Quantity = quantity;
                product.Price = price;
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Product was created successfully!");
              
            }
            else
            {
                MessageBox.Show("Please fill all the fields!");
            }
        }
    }
}
