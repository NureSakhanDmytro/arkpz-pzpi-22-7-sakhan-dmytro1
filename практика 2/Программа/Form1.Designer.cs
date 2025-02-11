namespace WinFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnShowPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(300, 150);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 26);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 26);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(300, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(300, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 30);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(506, 195);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(38, 35);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.Text = "👁️";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Name = "Form1";
            Text = "Вход";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
