using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any necessary actions when the form loads
        }

        // Login button handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False";
            string username = txtUsername.Text;  // Username
            string password = txtPassword.Text;  // Password

            // Validate if username and password are provided
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть ім'я користувача та пароль.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to check user data from the database
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password_hash = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", GetHashedPassword(password)); // Hash the password for comparison

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Вхід успішний!");
                        // Open the main form of the application
                        Form3 mainForm = new Form3();  // Main application form
                        mainForm.Show();
                        this.Hide(); // Hide the current form
                    }
                    else
                    {
                        MessageBox.Show("Невірне ім'я користувача або пароль.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при підключенні до бази даних: " + ex.Message);
                }
            }
        }

        // Register button handler
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();  // Registration form
            registerForm.Show();
            this.Hide(); // Hide the current form
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
