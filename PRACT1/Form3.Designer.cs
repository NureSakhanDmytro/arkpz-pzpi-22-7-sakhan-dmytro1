namespace WinFormsApp4._5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            soilAnalysisMenuItem = new ToolStripMenuItem();
            weatherDataMenuItem = new ToolStripMenuItem();
            plantingSeasonsMenuItem = new ToolStripMenuItem();
            рекоментаціїToolStripMenuItem = new ToolStripMenuItem();
            администруванняToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            админКуточокToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(19, 19);
            menuStrip.Items.AddRange(new ToolStripItem[] { soilAnalysisMenuItem, weatherDataMenuItem, plantingSeasonsMenuItem, рекоментаціїToolStripMenuItem, администруванняToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(810, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // soilAnalysisMenuItem
            // 
            soilAnalysisMenuItem.Name = "soilAnalysisMenuItem";
            soilAnalysisMenuItem.Size = new Size(117, 24);
            soilAnalysisMenuItem.Text = "Аналіз ґрунту";
            soilAnalysisMenuItem.Click += SoilAnalysisMenuItem_Click;
            // 
            // weatherDataMenuItem
            // 
            weatherDataMenuItem.Name = "weatherDataMenuItem";
            weatherDataMenuItem.Size = new Size(166, 24);
            weatherDataMenuItem.Text = "Метеорологічні дані";
            weatherDataMenuItem.Click += weatherDataMenuItem_Click;
            // 
            // plantingSeasonsMenuItem
            // 
            plantingSeasonsMenuItem.Name = "plantingSeasonsMenuItem";
            plantingSeasonsMenuItem.Size = new Size(134, 24);
            plantingSeasonsMenuItem.Text = "Сезони висадки";
            plantingSeasonsMenuItem.Click += plantingSeasonsMenuItem_Click;
            // 
            // рекоментаціїToolStripMenuItem
            // 
            рекоментаціїToolStripMenuItem.Name = "рекоментаціїToolStripMenuItem";
            рекоментаціїToolStripMenuItem.Size = new Size(116, 24);
            рекоментаціїToolStripMenuItem.Text = "Рекомендації";
            рекоментаціїToolStripMenuItem.Click += рекоментаціїToolStripMenuItem_Click;
            // 
            // администруванняToolStripMenuItem
            // 
            администруванняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { админКуточокToolStripMenuItem });
            администруванняToolStripMenuItem.Name = "администруванняToolStripMenuItem";
            администруванняToolStripMenuItem.Size = new Size(140, 24);
            администруванняToolStripMenuItem.Text = "Адміністрування";
            администруванняToolStripMenuItem.Click += AdminToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 47);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 1;
            label1.Text = "Ласкаво просимо до програми!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-3, 110);
            label2.Name = "label2";
            label2.Size = new Size(713, 20);
            label2.TabIndex = 2;
            label2.Text = "1)У цій програмі ви зможете додати свої дані про ґрунт і отримати рекомендації наприкінці роботи";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-3, 160);
            label3.Name = "label3";
            label3.Size = new Size(427, 20);
            label3.TabIndex = 3;
            label3.Text = "2)Перед використанням заповніть необхідні дані всіх полів";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-3, 209);
            label4.Name = "label4";
            label4.Size = new Size(502, 20);
            label4.TabIndex = 4;
            label4.Text = "3)Дотримуйтесь рекомендацій для досягнення найкращих результатів";
            // 
            // админКуточокToolStripMenuItem
            // 
            админКуточокToolStripMenuItem.Name = "админКуточокToolStripMenuItem";
            админКуточокToolStripMenuItem.Size = new Size(217, 26);
            админКуточокToolStripMenuItem.Text = "Админ куточок";
            админКуточокToolStripMenuItem.Click += админКуточокToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 400);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SoilAnalysisMenuItem_Click(object sender, EventArgs e)
        {
            // Открыть форму для аналізу ґрунту
            SoilAnalysisForm soilForm = new SoilAnalysisForm();
            soilForm.Show();
        }

        private void weatherDataMenuItem_Click(object sender, EventArgs e)
        {
            // Открыть форму для роботи з метеорологічними даними
            WeatherDataForm weatherForm = new WeatherDataForm();
            weatherForm.Show();
        }

        private void рекоментаціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FertilizerRecommendationsForm recommendationsForm = new FertilizerRecommendationsForm();
            recommendationsForm.Show();
        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plantingSeasonsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soilAnalysisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherDataMenuItem;
        private ToolStripMenuItem рекоментаціїToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem администруванняToolStripMenuItem;
        private ToolStripMenuItem админКуточокToolStripMenuItem;
    }
}