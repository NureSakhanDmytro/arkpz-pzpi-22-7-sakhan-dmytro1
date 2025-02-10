using System;
using System.Windows.Forms;

namespace WinFormsApp4._5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Создаем MenuStrip и пункты меню
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem plantingSeasonsMenuItem = new ToolStripMenuItem("Сезони висадки");
            ToolStripMenuItem soilAnalysisMenuItem = new ToolStripMenuItem("Аналіз ґрунту");
            ToolStripMenuItem weatherDataMenuItem = new ToolStripMenuItem("Метеорологічні дані");

            menuStrip.Items.Add(plantingSeasonsMenuItem);
            menuStrip.Items.Add(soilAnalysisMenuItem);
            menuStrip.Items.Add(weatherDataMenuItem);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            // Добавление обработчиков для пунктов меню
            soilAnalysisMenuItem.Click += (sender, e) =>
            {
                SoilAnalysisForm soilForm = new SoilAnalysisForm();
                soilForm.Show();
            };

            weatherDataMenuItem.Click += (sender, e) =>
            {
                WeatherDataForm weatherForm = new WeatherDataForm();
                weatherForm.Show();
            };

            plantingSeasonsMenuItem.Click += (sender, e) =>
            {
                PlantingSeasonsForm plantingForm = new PlantingSeasonsForm();
                plantingForm.Show();
            };

            рекоментаціїToolStripMenuItem.Click += (sender, e) =>
            {
                FertilizerRecommendationsForm plantplantingForm = new FertilizerRecommendationsForm();



            };






        }

        private void plantingSeasonsMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик пункта меню для "Сезони висадки"
            PlantingSeasonsForm plantingForm = new PlantingSeasonsForm();
            plantingForm.Show();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLoginForm admin = new AdminLoginForm();
            admin.Show(); // Вызовите метод Show для экземпляра admin
        }

        private void админКуточокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            админКуточок админКуточок = new админКуточок();
            админКуточок.Show();
        }
    }
}
