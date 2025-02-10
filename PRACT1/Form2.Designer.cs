namespace WinFormsApp4._5
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

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
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnShowPassword = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(116, 59);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(128, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Ім'я користувача:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(250, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 26);
            txtUsername.TabIndex = 0;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(466, 98);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(40, 36);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.Text = "👁️";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(250, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 26);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(179, 106);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Пароль:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(199, 153);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(45, 20);
            lblRole.TabIndex = 8;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Адміністратор", "Користувач" });
            cmbRole.Location = new Point(250, 150);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 27);
            cmbRole.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(250, 205);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 30);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 300);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnShowPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Form2";
            Text = "Реєстрація";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnShowPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnRegister;
    }
}
