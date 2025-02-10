namespace WinFormsApp4._5
{
    partial class PlantingSeasonsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox cropTextBox;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox idTextBox;  // Додаємо поле для id
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label idLabel;  // Додаємо мітку для id
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            cropTextBox = new TextBox();
            seasonComboBox = new ComboBox();
            notesTextBox = new TextBox();
            idTextBox = new TextBox();
            saveButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            cropLabel = new Label();
            seasonLabel = new Label();
            notesLabel = new Label();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 172);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 49;
            dataGridView.Size = new Size(760, 250);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // cropTextBox
            // 
            cropTextBox.Location = new Point(97, 36);
            cropTextBox.Name = "cropTextBox";
            cropTextBox.Size = new Size(200, 26);
            cropTextBox.TabIndex = 2;
            // 
            // seasonComboBox
            // 
            seasonComboBox.FormattingEnabled = true;
            seasonComboBox.Items.AddRange(new object[] { "Весна", "Літо", "Осінь", "Зима" });
            seasonComboBox.Location = new Point(97, 76);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(200, 27);
            seasonComboBox.TabIndex = 3;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(97, 116);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(200, 26);
            notesTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(553, 503);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(200, 26);
            idTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(774, 498);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 34);
            saveButton.TabIndex = 5;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(317, 36);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 34);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(317, 76);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 36);
            addButton.TabIndex = 7;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cropLabel
            // 
            cropLabel.AutoSize = true;
            cropLabel.Location = new Point(17, 36);
            cropLabel.Name = "cropLabel";
            cropLabel.Size = new Size(74, 20);
            cropLabel.TabIndex = 8;
            cropLabel.Text = "Культура:";
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Location = new Point(17, 76);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(54, 20);
            seasonLabel.TabIndex = 9;
            seasonLabel.Text = "Сезон:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(17, 116);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(78, 20);
            notesLabel.TabIndex = 10;
            notesLabel.Text = "Примітки:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(473, 503);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 11;
            idLabel.Text = "ID:";
            // 
            // PlantingSeasonsForm
            // 
            ClientSize = new Size(792, 441);
            Controls.Add(notesLabel);
            Controls.Add(seasonLabel);
            Controls.Add(cropLabel);
            Controls.Add(idLabel);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(notesTextBox);
            Controls.Add(seasonComboBox);
            Controls.Add(cropTextBox);
            Controls.Add(idTextBox);
            Controls.Add(dataGridView);
            Name = "PlantingSeasonsForm";
            Text = "Сезони Вирощування";
            Load += PlantingSeasonsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
