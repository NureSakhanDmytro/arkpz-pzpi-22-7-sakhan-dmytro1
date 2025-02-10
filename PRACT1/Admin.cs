using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class AdminLoginForm : Form
    {
        private string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False";

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                if (CheckAdminAccess(username, password))
                {
                    MessageBox.Show("Добро пожаловать, администратор!");
                    админКуточок adminForm = new админКуточок();
                    adminForm.Show(); // Здесь используется созданный экземпляр adminForm
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private bool CheckAdminAccess(string username, string password)
        {
            string hashedPassword = HashPassword(password); // Хэшируем введённый пароль
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password_hash = @password AND role = 'admin'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
