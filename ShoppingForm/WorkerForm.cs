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
    public partial class WorkerForm : Form
    {
        shoppingContext db = new shoppingContext();
        Product selectedProduct;
        Worker activeWorker;
        Order selectedOrder;
        public WorkerForm(Worker worker)
        {
            activeWorker = worker;
            InitializeComponent();
        }
        public void FillCategoryCombo()
        {
            cmbcategories.Items.AddRange(db.Categories.Select(x => x.Name).ToArray());
        }
        private void FillDataGrid()
        {
            dtgselllist.DataSource = db.Orders.Where(x => x.WorkerId == activeWorker.Id).Select(x => new
            {
                x.ProductId,
                x.Product.Name,
                x.Product.Price,
                x.Count,
                x.TotalPrice,
                x.PurchaseDate
            }).ToList();
            dtgselllist.Columns[0].Visible = false;
        }
        private void ClearData()
        {
            cmbproduct.Text = "";
            nmrcount.Value = 1;
            lblPrice.Text = "";
            cmbcategories.Text = "";
        }
        private void WorkerForm_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = "Welcome " + activeWorker.Fullname;
            FillCategoryCombo();
            FillDataGrid();

        }

        private void cmbcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbproduct.Text = "";
            nmrcount.Value = 1;
            lblPrice.Text = "";
            cmbproduct.Items.Clear();
            int categoryId = db.Categories.FirstOrDefault(x => x.Name == cmbcategories.Text).Id;
            cmbproduct.Items.AddRange(db.Products.Where(x => x.CategoryId == categoryId)
                .Select(x => x.Name).ToArray());
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmrcount.Value = 1;
            selectedProduct = db.Products.FirstOrDefault(x => x.Name == cmbproduct.Text);
            lblPrice.Text = selectedProduct.Price + " Azn";
            lblPrice.Visible = true;
            btnsell.Enabled = true;
        }

        private void nmrcount_ValueChanged(object sender, EventArgs e)
        {
            nmrcount.Maximum = selectedProduct.Quantity;
            lblPrice.Text = (decimal)(selectedProduct.Price * nmrcount.Value) + " Azn";
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            Order ord = new Order()
            {
                WorkerId = activeWorker.Id,
                ProductId = selectedProduct.Id,
                PurchaseDate = DateTime.Now,
                Count = (int)nmrcount.Value,
                TotalPrice = selectedProduct.Price * nmrcount.Value
            };
            db.Orders.Add(ord);
            db.SaveChanges();
            MessageBox.Show("Product was sold successfully!");
            ClearData();
            FillDataGrid();
        }

        private void dtgselllist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int productID = (int) dtgselllist.Rows[e.RowIndex].Cells[0].Value;
            selectedProduct = db.Products.FirstOrDefault(x => x.Id == productID);
            selectedOrder = db.Orders.FirstOrDefault(x => x.ProductId == selectedProduct.Id);
            cmbcategories.Text = db.Categories.FirstOrDefault(x => x.Id == selectedProduct.CategoryId).Name;
            cmbproduct.Text = selectedProduct.Name;
            nmrcount.Value = selectedOrder.Count;
            lblPrice.Text = selectedOrder.TotalPrice.ToString();
            ShowChangebtn("change");
            btnedit.Enabled = true;
            btndelete.Enabled = true;

        }
        public void ShowChangebtn(string txt)
        {
            if (txt == "change")
            {
                btnsell.Visible = false;
                btnedit.Visible = true;
                btndelete.Visible = true;
            }
            else
            {
                btnsell.Visible = true;
                btnedit.Visible = false;
                btndelete.Visible = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            selectedOrder.ProductId = selectedProduct.Id;
            //selectedOrder.ProductId = db.Products.FirstOrDefault(x=>x.Name==cmbproduct.Text).Id;
            selectedOrder.WorkerId = activeWorker.Id;
            selectedOrder.Count = (int)nmrcount.Value;
            selectedOrder.TotalPrice = selectedProduct.Price * nmrcount.Value;
            db.Orders.Update(selectedOrder);
            db.SaveChanges();
            FillDataGrid();
            ClearData();
            ShowChangebtn("no");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ShowChangebtn("no");
            db.Orders.RemoveRange(selectedOrder);
            db.SaveChanges();
            FillDataGrid();
            ClearData();
        }
    }
}
