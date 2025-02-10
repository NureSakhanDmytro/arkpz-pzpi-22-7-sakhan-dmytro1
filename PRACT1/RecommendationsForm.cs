using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class FertilizerRecommendationsForm : Form
    {
        // Строка подключения к базе данных
        private string connectionString = "Data Source=JOPS;Initial Catalog=Проект_Земля;Integrated Security=True;Encrypt=False";

        public FertilizerRecommendationsForm()
        {
            InitializeComponent();
        }

        private void RecommendationsForm_Load(object sender, EventArgs e)
        {
            // Здесь можно инициализировать другие компоненты, если нужно
        }

        private void btnGenerateRecommendations_Click(object sender, EventArgs e)
        {
            // Строка для хранения всех рекомендаций
            StringBuilder recommendations = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 1. Рекомендации для Soil Analysis (Анализ почвы)
                string soilQuery = @"
                    SELECT location, pH, nitrogen, potassium, phosphorus, moisture, density
                    FROM soil_analysis";
                SqlCommand soilCommand = new SqlCommand(soilQuery, connection);
                SqlDataReader soilReader = soilCommand.ExecuteReader();

                while (soilReader.Read())
                {
                    string location = soilReader.GetString(0);
                    double pH = soilReader.GetDouble(1);  // Используем GetDouble
                    double nitrogen = soilReader.GetDouble(2);  // Используем GetDouble
                    double potassium = soilReader.GetDouble(3);  // Используем GetDouble
                    double phosphorus = soilReader.GetDouble(4);  // Используем GetDouble
                    double moisture = soilReader.GetDouble(5);  // Используем GetDouble
                    double density = soilReader.GetDouble(6);  // Используем GetDouble

                    recommendations.AppendLine($"Рекомендации для анализа почвы в локации {location}:");

                    // pH
                    if (pH < 5.5)
                    {
                        recommendations.AppendLine("pH почвы слишком низкий, рекомендуется добавить известь.");
                    }
                    else if (pH > 7.5)
                    {
                        recommendations.AppendLine("pH почвы слишком высокий, рекомендуется добавить серу.");
                    }
                    else
                    {
                        recommendations.AppendLine("pH почвы в норме.");
                    }

                    // Нитроген
                    if (nitrogen < 50)
                    {
                        recommendations.AppendLine("Рекомендуется добавить азотные удобрения.");
                    }
                    else
                    {
                        recommendations.AppendLine("Уровень азота в норме.");
                    }

                    // Калій
                    if (potassium < 100)
                    {
                        recommendations.AppendLine("Рекомендуется добавить калийные удобрения.");
                    }
                    else
                    {
                        recommendations.AppendLine("Уровень калия в норме.");
                    }

                    // Фосфор
                    if (phosphorus < 5)
                    {
                        recommendations.AppendLine("Рекомендуется добавить фосфорные удобрения.");
                    }
                    else
                    {
                        recommendations.AppendLine("Уровень фосфора в почве в норме.");
                    }

                    // Влажность почвы
                    if (moisture > 7)
                    {
                        recommendations.AppendLine("Предупреждение: Влажность слишком высокая! Рекомендуется понизить уровень влаги.");
                    }
                    else if (moisture < 2)
                    {
                        recommendations.AppendLine("Предупреждение: Влажность слишком низкая! Рекомендуется увеличить полив.");
                    }
                    else
                    {
                        recommendations.AppendLine("Влажность почвы в норме.");
                    }

                    // Щільність
                    if (density > 1.5)
                    {
                        recommendations.AppendLine("Предупреждение: Плотность почвы слишком высокая! Рекомендуется обработка почвы для улучшения аэрации.");
                    }
                    else
                    {
                        recommendations.AppendLine("Плотность почвы в норме.");
                    }
                }
                soilReader.Close();

                // 2. Рекомендации для Weather Data (Метеорологические данные)
                string weatherQuery = @"
                    SELECT temperature, humidity, precipitation, wind_speed
                    FROM weather_data";
                SqlCommand weatherCommand = new SqlCommand(weatherQuery, connection);
                SqlDataReader weatherReader = weatherCommand.ExecuteReader();

                while (weatherReader.Read())
                {
                    double temperature = weatherReader.GetDouble(0);  // Используем GetDouble
                    double humidity = weatherReader.GetDouble(1);     // Используем GetDouble
                    double precipitation = weatherReader.GetDouble(2); // Используем GetDouble
                    double windSpeed = weatherReader.GetDouble(3);     // Используем GetDouble

                    recommendations.AppendLine("Рекомендации для метеоусловий:");

                    // Температура
                    if (temperature < 10)
                    {
                        recommendations.AppendLine("Предупреждение: Температура слишком низкая! Рекомендуется защитить растения.");
                    }
                    else if (temperature > 30)
                    {
                        recommendations.AppendLine("Предупреждение: Температура слишком высокая! Рекомендуется защита от солнечных ожогов.");
                    }
                    else
                    {
                        recommendations.AppendLine("Температура в норме.");
                    }

                    // Влажность воздуха
                    if (humidity > 70)
                    {
                        recommendations.AppendLine("Предупреждение: Высокая влажность воздуха! Рекомендуется проветривание.");
                    }
                    else
                    {
                        recommendations.AppendLine("Влажность воздуха в норме.");
                    }

                    // Осадки
                    if (precipitation > 50)
                    {
                        recommendations.AppendLine("Предупреждение: Высокие осадки! Рекомендуется предотвратить затопление растений.");
                    }
                    else
                    {
                        recommendations.AppendLine("Осадки в норме.");
                    }

                    // Скорость ветра
                    if (windSpeed > 15)
                    {
                        recommendations.AppendLine("Предупреждение: Высокая скорость ветра! Рекомендуется защита растений от ветра.");
                    }
                    else
                    {
                        recommendations.AppendLine("Скорость ветра в норме.");
                    }
                }
                weatherReader.Close();

                // 3. Рекомендации для Planting Seasons (Сезоны посева)
                string plantingQuery = @"
                    SELECT season, crop
                    FROM planting_seasons";
                SqlCommand plantingCommand = new SqlCommand(plantingQuery, connection);
                SqlDataReader plantingReader = plantingCommand.ExecuteReader();

                while (plantingReader.Read())
                {
                    string season = plantingReader.GetString(0);
                    string crop = plantingReader.GetString(1);

                    recommendations.AppendLine($"Рекомендации для сезона {season} и культуры {crop}:");

                    // Пример: для весны можем рекомендовать удобрения, а для зимы - защиту от холода
                    if (season.ToLower().Contains("весна"))
                    {
                        recommendations.AppendLine("Рекомендуется провести подкормку удобрениями.");
                    }
                    else if (season.ToLower().Contains("зима"))
                    {
                        recommendations.AppendLine("Необходимо защитить растения от холодов.");
                    }
                    else
                    {
                        recommendations.AppendLine("Сезон в норме, не требуется дополнительных действий.");
                    }

                    // Рекомендации по культуре
                    if (crop.ToLower().Contains("Соя"))
                    {
                        recommendations.AppendLine("Для Сои рекомендуется использовать азотные удобрения.");
                    }
                    else if (crop.ToLower().Contains("Кукурудза"))
                    {
                        recommendations.AppendLine("Для картофеля рекомендуется обработка от вредителей.");
                    }
                    else
                    {
                        recommendations.AppendLine($"Для культуры {crop} не требуются дополнительные рекомендации.");
                    }
                }
                plantingReader.Close();
            }

            // Выводим финальные рекомендации в TextBox или RichTextBox
            txtRecommendation.Text = recommendations.ToString();
        }

        private void txtRecommendation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
