using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class PlantingSeasonsForm : Form
    {
        private string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False"; // Ваша строка подключения

        public PlantingSeasonsForm()
        {
            InitializeComponent();
        }

        private void PlantingSeasonsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Загрузка даних в DataGridView
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM planting_seasons";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
        }

        // Обработчик кнопки "Зберегти" — обновление данных в БД
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Выберите строку для редактирования.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE planting_seasons SET crop = @crop, season = @season, notes = @notes WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idTextBox.Text);
                command.Parameters.AddWithValue("@crop", cropTextBox.Text);
                command.Parameters.AddWithValue("@season", seasonComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@notes", notesTextBox.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Данные обновлены.");
            LoadData(); // Перезагружаем данные в DataGridView
        }

        // Обработчик кнопки "Видалити" — удаление строки из БД
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM planting_seasons WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idTextBox.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Данные удалены.");
            LoadData(); // Перезагружаем данные в DataGridView
        }

        // Обработчик кнопки "Добавити" — добавление новой строки в БД
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cropTextBox.Text) || string.IsNullOrEmpty(seasonComboBox.SelectedItem?.ToString()) || string.IsNullOrEmpty(notesTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO planting_seasons (crop, season, notes) VALUES (@crop, @season, @notes)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@crop", cropTextBox.Text);
                command.Parameters.AddWithValue("@season", seasonComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@notes", notesTextBox.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Дані добавленні.");
            LoadData(); // Перезагружаем данные в DataGridView
        }

        // Обновление полей при изменении выбранной строки в DataGridView
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                idTextBox.Text = dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();
                cropTextBox.Text = dataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                seasonComboBox.SelectedItem = dataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString();
                notesTextBox.Text = dataGridView.Rows[selectedRowIndex].Cells[3].Value.ToString();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
