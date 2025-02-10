namespace WinFormsApp4._5
{
    partial class FertilizerRecommendationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRecommendation;
        private System.Windows.Forms.Button btnGenerateRecommendations;

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
            txtRecommendation = new TextBox();
            btnGenerateRecommendations = new Button();
            SuspendLayout();
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(12, 12);
            txtRecommendation.Multiline = true;
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.ScrollBars = ScrollBars.Vertical;
            txtRecommendation.Size = new Size(760, 250);
            txtRecommendation.TabIndex = 0;
            txtRecommendation.TextChanged += txtRecommendation_TextChanged;
            // 
            // btnGenerateRecommendations
            // 
            btnGenerateRecommendations.Location = new Point(12, 280);
            btnGenerateRecommendations.Name = "btnGenerateRecommendations";
            btnGenerateRecommendations.Size = new Size(200, 40);
            btnGenerateRecommendations.TabIndex = 1;
            btnGenerateRecommendations.Text = "Сделать рекомендации";
            btnGenerateRecommendations.UseVisualStyleBackColor = true;
            btnGenerateRecommendations.Click += btnGenerateRecommendations_Click;
            // 
            // FertilizerRecommendationsForm
            // 
            ClientSize = new Size(784, 361);
            Controls.Add(btnGenerateRecommendations);
            Controls.Add(txtRecommendation);
            Name = "FertilizerRecommendationsForm";
            Text = "Рекомендации";
            Load += RecommendationsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
