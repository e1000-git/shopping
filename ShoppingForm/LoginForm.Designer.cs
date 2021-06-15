
namespace ShoppingForm
{
    partial class LoginForm
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpsswrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(140, 230);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(217, 65);
            this.btnlogin.TabIndex = 17;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpsswrd
            // 
            this.txtpsswrd.BackColor = System.Drawing.Color.Goldenrod;
            this.txtpsswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpsswrd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpsswrd.Location = new System.Drawing.Point(140, 146);
            this.txtpsswrd.Name = "txtpsswrd";
            this.txtpsswrd.Size = new System.Drawing.Size(217, 27);
            this.txtpsswrd.TabIndex = 14;
            this.txtpsswrd.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(199, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Goldenrod;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.Location = new System.Drawing.Point(140, 66);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(217, 27);
            this.txtemail.TabIndex = 12;
            this.txtemail.Text = "murad@gmail.com";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.Goldenrod;
            this.Email.Location = new System.Drawing.Point(217, 32);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 28);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(145, 189);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(101, 28);
            this.lblerror.TabIndex = 18;
            this.lblerror.Text = "Password";
            this.lblerror.Visible = false;
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadmin.ForeColor = System.Drawing.Color.White;
            this.btnadmin.Location = new System.Drawing.Point(140, 315);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(217, 65);
            this.btnadmin.TabIndex = 19;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpsswrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.Email);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpsswrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnadmin;
    }
}