using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=JOPS;Initial Catalog=test;Integrated Security=True;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Логика загрузки формы
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Поля логина и пароля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(1) FROM register WHERE login_user = @login AND password_user = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        int userExists = (int)command.ExecuteScalar();

                        if (userExists > 0)
                        {
                            // Успешный вход
                            MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Переход к Form3 (например)
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();  // Скрыть Form1
        }

        // Логика для показа/скрытия пароля
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowPassword.Text = "🙈";  // Изменение текста кнопки
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "👁️";  // Изменение текста кнопки
            }
        }
    }
}
