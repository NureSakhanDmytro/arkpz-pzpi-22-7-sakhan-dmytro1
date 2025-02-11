namespace WinFormsApp4
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowPassword;  // Кнопка для показа пароля

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
            txtNewLogin = new TextBox();
            txtNewPassword = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // txtNewLogin
            // 
            txtNewLogin.Location = new Point(300, 150);
            txtNewLogin.Name = "txtNewLogin";
            txtNewLogin.Size = new Size(200, 26);
            txtNewLogin.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(300, 200);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(200, 26);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(300, 250);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 30);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Зарегистрировать";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(300, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowPassword);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewLogin);
            Name = "Form2";
            Text = "Регистрация";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
