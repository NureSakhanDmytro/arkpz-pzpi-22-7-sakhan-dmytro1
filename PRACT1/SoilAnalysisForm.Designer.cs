namespace WinFormsApp4._5
{
    partial class SoilAnalysisForm
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
            txtUserId = new TextBox();
            datePicker = new DateTimePicker();
            txtLocation = new TextBox();
            txtPH = new TextBox();
            txtNitrogen = new TextBox();
            txtPotassium = new TextBox();
            txtPhosphorus = new TextBox();
            txtMoisture = new TextBox();
            txtDensity = new TextBox();
            txtCrop = new TextBox();
            labelUserId = new Label();
            labelAnalysisDate = new Label();
            labelLocation = new Label();
            labelPH = new Label();
            labelNitrogen = new Label();
            labelPotassium = new Label();
            labelPhosphorus = new Label();
            labelMoisture = new Label();
            labelDensity = new Label();
            labelCrop = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(760, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(668, 244);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранити";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(540, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(129, 97);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(100, 26);
            txtUserId.TabIndex = 4;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(149, 21);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 26);
            datePicker.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(129, 131);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 26);
            txtLocation.TabIndex = 5;
            // 
            // txtPH
            // 
            txtPH.Location = new Point(129, 161);
            txtPH.Name = "txtPH";
            txtPH.Size = new Size(100, 26);
            txtPH.TabIndex = 6;
            // 
            // txtNitrogen
            // 
            txtNitrogen.Location = new Point(129, 191);
            txtNitrogen.Name = "txtNitrogen";
            txtNitrogen.Size = new Size(100, 26);
            txtNitrogen.TabIndex = 7;
            // 
            // txtPotassium
            // 
            txtPotassium.Location = new Point(129, 221);
            txtPotassium.Name = "txtPotassium";
            txtPotassium.Size = new Size(100, 26);
            txtPotassium.TabIndex = 8;
            // 
            // txtPhosphorus
            // 
            txtPhosphorus.Location = new Point(421, 98);
            txtPhosphorus.Name = "txtPhosphorus";
            txtPhosphorus.Size = new Size(100, 26);
            txtPhosphorus.TabIndex = 9;
            // 
            // txtMoisture
            // 
            txtMoisture.Location = new Point(421, 128);
            txtMoisture.Name = "txtMoisture";
            txtMoisture.Size = new Size(100, 26);
            txtMoisture.TabIndex = 10;
            // 
            // txtDensity
            // 
            txtDensity.Location = new Point(421, 158);
            txtDensity.Name = "txtDensity";
            txtDensity.Size = new Size(100, 26);
            txtDensity.TabIndex = 11;
            // 
            // txtCrop
            // 
            txtCrop.Location = new Point(421, 188);
            txtCrop.Name = "txtCrop";
            txtCrop.Size = new Size(100, 26);
            txtCrop.TabIndex = 12;
            // 
            // labelUserId
            // 
            labelUserId.Location = new Point(29, 97);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(100, 23);
            labelUserId.TabIndex = 13;
            labelUserId.Text = "User ID:";
            labelUserId.Click += labelUserId_Click;
            // 
            // labelAnalysisDate
            // 
            labelAnalysisDate.Location = new Point(29, 27);
            labelAnalysisDate.Name = "labelAnalysisDate";
            labelAnalysisDate.Size = new Size(100, 23);
            labelAnalysisDate.TabIndex = 14;
            labelAnalysisDate.Text = "Дата:";
            // 
            // labelLocation
            // 
            labelLocation.Location = new Point(29, 131);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(100, 23);
            labelLocation.TabIndex = 15;
            labelLocation.Text = "Локація:";
            // 
            // labelPH
            // 
            labelPH.Location = new Point(29, 161);
            labelPH.Name = "labelPH";
            labelPH.Size = new Size(100, 23);
            labelPH.TabIndex = 16;
            labelPH.Text = "pH:";
            // 
            // labelNitrogen
            // 
            labelNitrogen.Location = new Point(29, 191);
            labelNitrogen.Name = "labelNitrogen";
            labelNitrogen.Size = new Size(100, 23);
            labelNitrogen.TabIndex = 17;
            labelNitrogen.Text = "Нітроген:";
            // 
            // labelPotassium
            // 
            labelPotassium.Location = new Point(29, 221);
            labelPotassium.Name = "labelPotassium";
            labelPotassium.Size = new Size(100, 23);
            labelPotassium.TabIndex = 18;
            labelPotassium.Text = "Калій:";
            // 
            // labelPhosphorus
            // 
            labelPhosphorus.Location = new Point(321, 98);
            labelPhosphorus.Name = "labelPhosphorus";
            labelPhosphorus.Size = new Size(100, 23);
            labelPhosphorus.TabIndex = 19;
            labelPhosphorus.Text = "Фосфор:";
            // 
            // labelMoisture
            // 
            labelMoisture.Location = new Point(321, 128);
            labelMoisture.Name = "labelMoisture";
            labelMoisture.Size = new Size(100, 23);
            labelMoisture.TabIndex = 20;
            labelMoisture.Text = "Волога:";
            // 
            // labelDensity
            // 
            labelDensity.Location = new Point(321, 158);
            labelDensity.Name = "labelDensity";
            labelDensity.Size = new Size(100, 23);
            labelDensity.TabIndex = 21;
            labelDensity.Text = "Щільність:";
            // 
            // labelCrop
            // 
            labelCrop.Location = new Point(321, 188);
            labelCrop.Name = "labelCrop";
            labelCrop.Size = new Size(100, 23);
            labelCrop.TabIndex = 22;
            labelCrop.Text = "Семена:";
            // 
            // SoilAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 496);
            Controls.Add(datePicker);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(txtUserId);
            Controls.Add(txtLocation);
            Controls.Add(txtPH);
            Controls.Add(txtNitrogen);
            Controls.Add(txtPotassium);
            Controls.Add(txtPhosphorus);
            Controls.Add(txtMoisture);
            Controls.Add(txtDensity);
            Controls.Add(txtCrop);
            Controls.Add(labelUserId);
            Controls.Add(labelAnalysisDate);
            Controls.Add(labelLocation);
            Controls.Add(labelPH);
            Controls.Add(labelNitrogen);
            Controls.Add(labelPotassium);
            Controls.Add(labelPhosphorus);
            Controls.Add(labelMoisture);
            Controls.Add(labelDensity);
            Controls.Add(labelCrop);
            Name = "SoilAnalysisForm";
            Text = "Soil Analysis Form";
            Load += SoilAnalysisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtNitrogen;
        private System.Windows.Forms.TextBox txtPotassium;
        private System.Windows.Forms.TextBox txtPhosphorus;
        private System.Windows.Forms.TextBox txtMoisture;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.TextBox txtCrop;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelAnalysisDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelPH;
        private System.Windows.Forms.Label labelNitrogen;
        private System.Windows.Forms.Label labelPotassium;
        private System.Windows.Forms.Label labelPhosphorus;
        private System.Windows.Forms.Label labelMoisture;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.Label labelCrop;
    }
}
