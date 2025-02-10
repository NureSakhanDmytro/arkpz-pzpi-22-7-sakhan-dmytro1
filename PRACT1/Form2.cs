using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Actions to perform when the form loads
        }

        // Registration button handler
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False";
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();  // Role selection

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO users (username, password_hash, role) VALUES (@username, @password, @role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", GetHashedPassword(password));
                    command.Parameters.AddWithValue("@role", role);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Реєстрація успішна!");
                    this.Hide(); // Hide the form after successful registration
                    Form1 loginForm = new Form1();  // Go back to login form
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при підключенні до бази даних: " + ex.Message);
                }
            }
        }

        // Password hashing method
        private string GetHashedPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // Show/Hide password button handler
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';  // Show the text
                btnShowPassword.Text = "🙈"; // Change icon to "Hide"
            }
            else
            {
                txtPassword.PasswordChar = '*';  // Hide password
                btnShowPassword.Text = "👁️"; // Change icon to "Show"
            }
        }
    }
}
