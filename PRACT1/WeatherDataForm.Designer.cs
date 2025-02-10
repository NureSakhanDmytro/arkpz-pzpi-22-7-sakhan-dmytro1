namespace WinFormsApp4._5
{
    partial class WeatherDataForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            txtAnalysisId = new TextBox();
            txtTemperature = new TextBox();
            txtHumidity = new TextBox();
            txtPrecipitation = new TextBox();
            txtWindSpeed = new TextBox();
            txtWeatherNotes = new TextBox();
            labelAnalysisId = new Label();
            labelTemperature = new Label();
            labelHumidity = new Label();
            labelPrecipitation = new Label();
            labelWindSpeed = new Label();
            labelWeatherNotes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(760, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(668, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(540, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtAnalysisId
            // 
            txtAnalysisId.Location = new Point(147, 17);
            txtAnalysisId.Name = "txtAnalysisId";
            txtAnalysisId.Size = new Size(100, 26);
            txtAnalysisId.TabIndex = 0;
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(147, 47);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(100, 26);
            txtTemperature.TabIndex = 1;
            // 
            // txtHumidity
            // 
            txtHumidity.Location = new Point(147, 77);
            txtHumidity.Name = "txtHumidity";
            txtHumidity.Size = new Size(100, 26);
            txtHumidity.TabIndex = 2;
            // 
            // txtPrecipitation
            // 
            txtPrecipitation.Location = new Point(147, 107);
            txtPrecipitation.Name = "txtPrecipitation";
            txtPrecipitation.Size = new Size(100, 26);
            txtPrecipitation.TabIndex = 3;
            // 
            // txtWindSpeed
            // 
            txtWindSpeed.Location = new Point(147, 137);
            txtWindSpeed.Name = "txtWindSpeed";
            txtWindSpeed.Size = new Size(100, 26);
            txtWindSpeed.TabIndex = 4;
            // 
            // txtWeatherNotes
            // 
            txtWeatherNotes.Location = new Point(461, 20);
            txtWeatherNotes.Name = "txtWeatherNotes";
            txtWeatherNotes.Size = new Size(100, 26);
            txtWeatherNotes.TabIndex = 5;
            // 
            // labelAnalysisId
            // 
            labelAnalysisId.Location = new Point(20, 20);
            labelAnalysisId.Name = "labelAnalysisId";
            labelAnalysisId.Size = new Size(100, 23);
            labelAnalysisId.TabIndex = 6;
            labelAnalysisId.Text = "ID аналізу:";
            // 
            // labelTemperature
            // 
            labelTemperature.Location = new Point(20, 50);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(105, 23);
            labelTemperature.TabIndex = 7;
            labelTemperature.Text = "Температура:";
            // 
            // labelHumidity
            // 
            labelHumidity.Location = new Point(20, 80);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(100, 23);
            labelHumidity.TabIndex = 8;
            labelHumidity.Text = "Вологість:";
            // 
            // labelPrecipitation
            // 
            labelPrecipitation.Location = new Point(20, 110);
            labelPrecipitation.Name = "labelPrecipitation";
            labelPrecipitation.Size = new Size(100, 23);
            labelPrecipitation.TabIndex = 9;
            labelPrecipitation.Text = "Опади:";
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.Location = new Point(20, 140);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(124, 23);
            labelWindSpeed.TabIndex = 10;
            labelWindSpeed.Text = "Швидкість вітру:";
            // 
            // labelWeatherNotes
            // 
            labelWeatherNotes.Location = new Point(300, 20);
            labelWeatherNotes.Name = "labelWeatherNotes";
            labelWeatherNotes.Size = new Size(169, 23);
            labelWeatherNotes.TabIndex = 11;
            labelWeatherNotes.Text = "Примітки про погоду:";
            // 
            // WeatherDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(txtAnalysisId);
            Controls.Add(txtTemperature);
            Controls.Add(txtHumidity);
            Controls.Add(txtPrecipitation);
            Controls.Add(txtWindSpeed);
            Controls.Add(txtWeatherNotes);
            Controls.Add(labelAnalysisId);
            Controls.Add(labelTemperature);
            Controls.Add(labelHumidity);
            Controls.Add(labelPrecipitation);
            Controls.Add(labelWindSpeed);
            Controls.Add(labelWeatherNotes);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "WeatherDataForm";
            Text = "Форма погодних даних";
            Load += WeatherDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAnalysisId;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtPrecipitation;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.TextBox txtWeatherNotes;
        private System.Windows.Forms.Label labelAnalysisId;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelPrecipitation;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelWeatherNotes;
    }
}
