using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class WeatherDataForm : Form
    {
        private string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False";

        public WeatherDataForm()
        {
            InitializeComponent();
        }

        private void WeatherDataForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP (1000) [id], [analysis_id], [temperature], [humidity], [precipitation], [wind_speed], [weather_notes] FROM weather_data";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверяем, что введен корректный идентификатор анализа
            int analysisId;
            if (int.TryParse(txtAnalysisId.Text, out analysisId))
            {
                // Открываем соединение с базой данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Запрос для проверки, существует ли такой analysis_id в таблице soil_analysis
                    string checkQuery = "SELECT COUNT(1) FROM soil_analysis WHERE id = @AnalysisId";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        // Добавляем параметр для запроса
                        checkCommand.Parameters.AddWithValue("@AnalysisId", analysisId);

                        // Открываем соединение
                        connection.Open();

                        // Выполняем запрос и получаем количество совпадений
                        int count = (int)checkCommand.ExecuteScalar();

                        // Если записи с таким analysis_id нет в таблице soil_analysis
                        if (count == 0)
                        {
                            MessageBox.Show("Указанный Analysis ID не существует в таблице soil_analysis.");
                            return;  // Выходим из метода, не выполняя вставку
                        }
                    }

                    // Если analysis_id существует, выполняем вставку данных в таблицу weather_data
                    string query = @"
            INSERT INTO weather_data 
            ([analysis_id], [temperature], [humidity], [precipitation], [wind_speed], [weather_notes])
            VALUES 
            (@AnalysisId, @Temperature, @Humidity, @Precipitation, @WindSpeed, @WeatherNotes)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавляем параметры для вставки данных
                        command.Parameters.AddWithValue("@AnalysisId", txtAnalysisId.Text);
                        command.Parameters.AddWithValue("@Temperature", txtTemperature.Text);
                        command.Parameters.AddWithValue("@Humidity", txtHumidity.Text);
                        command.Parameters.AddWithValue("@Precipitation", txtPrecipitation.Text);
                        command.Parameters.AddWithValue("@WindSpeed", txtWindSpeed.Text);
                        command.Parameters.AddWithValue("@WeatherNotes", txtWeatherNotes.Text);

                        // Выполняем вставку данных
                        command.ExecuteNonQuery();
                    }

                    // Сообщение об успешном сохранении данных
                    MessageBox.Show("Данные успешно сохранены!");
                    LoadData();  // Перезагружаем данные в DataGridView
                }
            }
            else
            {
                // Если введен некорректный идентификатор
                MessageBox.Show("Введите корректный идентификатор анализа.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var id = selectedRow.Cells["id"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM weather_data WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные успешно удалены!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }
    }
}
