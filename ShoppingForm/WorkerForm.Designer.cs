
namespace ShoppingForm
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcategories = new System.Windows.Forms.ComboBox();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrcount = new System.Windows.Forms.NumericUpDown();
            this.btnsell = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dtgselllist = new System.Windows.Forms.DataGridView();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgselllist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // cmbcategories
            // 
            this.cmbcategories.FormattingEnabled = true;
            this.cmbcategories.Location = new System.Drawing.Point(28, 60);
            this.cmbcategories.Name = "cmbcategories";
            this.cmbcategories.Size = new System.Drawing.Size(159, 23);
            this.cmbcategories.TabIndex = 1;
            this.cmbcategories.SelectedIndexChanged += new System.EventHandler(this.cmbcategories_SelectedIndexChanged);
            // 
            // cmbproduct
            // 
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(28, 144);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(159, 23);
            this.cmbproduct.TabIndex = 3;
            this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count";
            // 
            // nmrcount
            // 
            this.nmrcount.Location = new System.Drawing.Point(28, 231);
            this.nmrcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcount.Name = "nmrcount";
            this.nmrcount.Size = new System.Drawing.Size(159, 23);
            this.nmrcount.TabIndex = 6;
            this.nmrcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcount.ValueChanged += new System.EventHandler(this.nmrcount_ValueChanged);
            // 
            // btnsell
            // 
            this.btnsell.BackColor = System.Drawing.Color.Goldenrod;
            this.btnsell.Enabled = false;
            this.btnsell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsell.ForeColor = System.Drawing.Color.White;
            this.btnsell.Location = new System.Drawing.Point(28, 358);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(159, 46);
            this.btnsell.TabIndex = 7;
            this.btnsell.Text = "Sell";
            this.btnsell.UseVisualStyleBackColor = false;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPrice.Location = new System.Drawing.Point(28, 279);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 21);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Count";
            this.lblPrice.Visible = false;
            // 
            // dtgselllist
            // 
            this.dtgselllist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgselllist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgselllist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgselllist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgselllist.Location = new System.Drawing.Point(231, 90);
            this.dtgselllist.Name = "dtgselllist";
            this.dtgselllist.RowTemplate.Height = 25;
            this.dtgselllist.Size = new System.Drawing.Size(615, 314);
            this.dtgselllist.TabIndex = 9;
            this.dtgselllist.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgselllist_RowHeaderMouseDoubleClick);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.SystemColors.Control;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblwelcome.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblwelcome.Location = new System.Drawing.Point(380, 29);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(82, 21);
            this.lblwelcome.TabIndex = 10;
            this.lblwelcome.Text = "Welcome";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnedit.Enabled = false;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(28, 380);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(91, 46);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Visible = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btndelete.Enabled = false;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(125, 380);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 46);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 510);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.dtgselllist);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnsell);
            this.Controls.Add(this.nmrcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbcategories);
            this.Controls.Add(this.label1);
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgselllist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcategories;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrcount;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridView dtgselllist;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
    }
}