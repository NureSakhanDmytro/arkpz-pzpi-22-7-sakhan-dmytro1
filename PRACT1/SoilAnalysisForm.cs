using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WinFormsApp4._5
{
    public partial class SoilAnalysisForm : Form
    {
        private string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False";

        public SoilAnalysisForm()
        {
            InitializeComponent();
        }

        private void SoilAnalysisForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP (1000) [id], [user_id], [analysis_date], [location], [ph], [nitrogen], [potassium], [phosphorus], [moisture], [density], [crop] FROM soil_analysis";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO soil_analysis 
                ([user_id], [analysis_date], [location], [ph], [nitrogen], [potassium], [phosphorus], [moisture], [density], [crop])
                VALUES 
                (@UserId, @AnalysisDate, @Location, @PH, @Nitrogen, @Potassium, @Phosphorus, @Moisture, @Density, @Crop)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", txtUserId.Text);
                    command.Parameters.AddWithValue("@AnalysisDate", datePicker.Value);
                    command.Parameters.AddWithValue("@Location", txtLocation.Text);
                    command.Parameters.AddWithValue("@PH", txtPH.Text);
                    command.Parameters.AddWithValue("@Nitrogen", txtNitrogen.Text);
                    command.Parameters.AddWithValue("@Potassium", txtPotassium.Text);
                    command.Parameters.AddWithValue("@Phosphorus", txtPhosphorus.Text);
                    command.Parameters.AddWithValue("@Moisture", txtMoisture.Text);
                    command.Parameters.AddWithValue("@Density", txtDensity.Text);
                    command.Parameters.AddWithValue("@Crop", txtCrop.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Данные успешно сохранены!");
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var id = selectedRow.Cells["id"].Value.ToString(); // Предполагается, что столбец с ID называется "id"

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM soil_analysis WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные успешно удалены!");
                LoadData(); // Обновляем данные на форме
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

        private void labelUserId_Click(object sender, EventArgs e)
        {

        }
    }
}
