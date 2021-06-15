
namespace ShoppingForm
{
    partial class RegisterForm
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtpsswrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconpsswrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrgstr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullName";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Goldenrod;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(133, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(217, 27);
            this.txtname.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Goldenrod;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.Location = new System.Drawing.Point(133, 134);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(217, 27);
            this.txtemail.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.Goldenrod;
            this.Email.Location = new System.Drawing.Point(210, 100);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 28);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // txtpsswrd
            // 
            this.txtpsswrd.BackColor = System.Drawing.Color.Goldenrod;
            this.txtpsswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpsswrd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpsswrd.Location = new System.Drawing.Point(133, 214);
            this.txtpsswrd.Name = "txtpsswrd";
            this.txtpsswrd.Size = new System.Drawing.Size(217, 27);
            this.txtpsswrd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(192, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtconpsswrd
            // 
            this.txtconpsswrd.BackColor = System.Drawing.Color.Goldenrod;
            this.txtconpsswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconpsswrd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtconpsswrd.Location = new System.Drawing.Point(133, 294);
            this.txtconpsswrd.Name = "txtconpsswrd";
            this.txtconpsswrd.Size = new System.Drawing.Size(217, 27);
            this.txtconpsswrd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(151, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // btnrgstr
            // 
            this.btnrgstr.BackColor = System.Drawing.Color.Goldenrod;
            this.btnrgstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrgstr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrgstr.ForeColor = System.Drawing.Color.White;
            this.btnrgstr.Location = new System.Drawing.Point(133, 363);
            this.btnrgstr.Name = "btnrgstr";
            this.btnrgstr.Size = new System.Drawing.Size(217, 65);
            this.btnrgstr.TabIndex = 8;
            this.btnrgstr.Text = "Register";
            this.btnrgstr.UseVisualStyleBackColor = false;
            this.btnrgstr.Click += new System.EventHandler(this.btnrgstr_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 486);
            this.Controls.Add(this.btnrgstr);
            this.Controls.Add(this.txtconpsswrd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpsswrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtpsswrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconpsswrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrgstr;
    }
}