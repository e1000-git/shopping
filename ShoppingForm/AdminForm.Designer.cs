
namespace ShoppingForm
{
    partial class AdminForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnworker = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.panelMenu.Controls.Add(this.btnorder);
            this.panelMenu.Controls.Add(this.btnworker);
            this.panelMenu.Controls.Add(this.btnproduct);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnorder
            // 
            this.btnorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnorder.Location = new System.Drawing.Point(0, 170);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(200, 50);
            this.btnorder.TabIndex = 3;
            this.btnorder.Text = "Orders";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnworker
            // 
            this.btnworker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnworker.FlatAppearance.BorderSize = 0;
            this.btnworker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnworker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnworker.Location = new System.Drawing.Point(0, 120);
            this.btnworker.Name = "btnworker";
            this.btnworker.Size = new System.Drawing.Size(200, 50);
            this.btnworker.TabIndex = 2;
            this.btnworker.Text = "Workers";
            this.btnworker.UseVisualStyleBackColor = true;
            this.btnworker.Click += new System.EventHandler(this.btnworker_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnproduct.Location = new System.Drawing.Point(0, 70);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(200, 50);
            this.btnproduct.TabIndex = 1;
            this.btnproduct.Text = "Products";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.Goldenrod;
            this.paneltitlebar.Controls.Add(this.labeltitle);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(200, 0);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(600, 70);
            this.paneltitlebar.TabIndex = 1;
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltitle.Location = new System.Drawing.Point(250, 21);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(72, 28);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(600, 380);
            this.panelDesktop.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panelMenu.ResumeLayout(false);
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnworker;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Panel panelDesktop;
    }
}