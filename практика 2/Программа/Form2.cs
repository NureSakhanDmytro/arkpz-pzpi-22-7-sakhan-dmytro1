using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=JOPS;Initial Catalog=test;Integrated Security=True;Encrypt=False";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Логика загрузки формы
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtNewLogin.Text.Trim();
            string password = txtNewPassword.Text.Trim();

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

                    string query = "INSERT INTO register (login_user, password_user) VALUES (@login, @password)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNewLogin.Clear();
                            txtNewPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка регистрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Логика для показа/скрытия пароля
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                btnShowPassword.Text = "🙈";  // Изменение текста кнопки
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "👁️";  // Изменение текста кнопки
            }
        }
    }
}
