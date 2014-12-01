namespace WindowsFormsApplication4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(206, 246);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(143, 154);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 1;
            this.email.Text = "Email:";
            // 
            // email1
            // 
            this.email1.Location = new System.Drawing.Point(181, 151);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(171, 20);
            this.email1.TabIndex = 0;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(125, 194);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 5;
            this.password.Text = "Password:";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(137, 33);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(242, 18);
            this.header.TabIndex = 6;
            this.header.Text = "Delhi Technological University";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept.Location = new System.Drawing.Point(137, 60);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(242, 18);
            this.dept.TabIndex = 7;
            this.dept.Text = "Department of Applied Mathematics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "© Copyright 2014";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "To be used only for Departmental purpose";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(181, 191);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '•';
            this.pass.Size = new System.Drawing.Size(171, 20);
            this.pass.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 99);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(358, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.header);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
    }
}

