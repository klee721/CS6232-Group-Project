
namespace Group3_ClinicDB.UserControls
{
    partial class SearchTestResultsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTestTitleLabel = new System.Windows.Forms.Label();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.visitIdRadioButton = new System.Windows.Forms.RadioButton();
            this.visitIdButton = new System.Windows.Forms.Button();
            this.visitIdResetButton = new System.Windows.Forms.Button();
            this.visitIdLabel = new System.Windows.Forms.Label();
            this.visitIdTextBox = new System.Windows.Forms.TextBox();
            this.visitIdErrorLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTestTitleLabel
            // 
            this.searchTestTitleLabel.AutoSize = true;
            this.searchTestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTestTitleLabel.Location = new System.Drawing.Point(223, 229);
            this.searchTestTitleLabel.Name = "searchTestTitleLabel";
            this.searchTestTitleLabel.Size = new System.Drawing.Size(143, 22);
            this.searchTestTitleLabel.TabIndex = 0;
            this.searchTestTitleLabel.Text = "Performed Tests";
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(224, 263);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.Size = new System.Drawing.Size(717, 278);
            this.patientDataGridView.TabIndex = 1;
            // 
            // visitIdRadioButton
            // 
            this.visitIdRadioButton.AutoSize = true;
            this.visitIdRadioButton.Checked = true;
            this.visitIdRadioButton.Location = new System.Drawing.Point(224, 83);
            this.visitIdRadioButton.Name = "visitIdRadioButton";
            this.visitIdRadioButton.Size = new System.Drawing.Size(112, 17);
            this.visitIdRadioButton.TabIndex = 2;
            this.visitIdRadioButton.TabStop = true;
            this.visitIdRadioButton.Text = "Search by Visit ID:";
            this.visitIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // visitIdButton
            // 
            this.visitIdButton.Enabled = false;
            this.visitIdButton.Location = new System.Drawing.Point(224, 178);
            this.visitIdButton.Name = "visitIdButton";
            this.visitIdButton.Size = new System.Drawing.Size(75, 23);
            this.visitIdButton.TabIndex = 3;
            this.visitIdButton.Text = "Search";
            this.visitIdButton.UseVisualStyleBackColor = true;
            // 
            // visitIdResetButton
            // 
            this.visitIdResetButton.Enabled = false;
            this.visitIdResetButton.Location = new System.Drawing.Point(329, 178);
            this.visitIdResetButton.Name = "visitIdResetButton";
            this.visitIdResetButton.Size = new System.Drawing.Size(75, 23);
            this.visitIdResetButton.TabIndex = 4;
            this.visitIdResetButton.Text = "Reset";
            this.visitIdResetButton.UseVisualStyleBackColor = true;
            // 
            // visitIdLabel
            // 
            this.visitIdLabel.AutoSize = true;
            this.visitIdLabel.Location = new System.Drawing.Point(224, 117);
            this.visitIdLabel.Name = "visitIdLabel";
            this.visitIdLabel.Size = new System.Drawing.Size(43, 13);
            this.visitIdLabel.TabIndex = 5;
            this.visitIdLabel.Text = "Visit ID:";
            // 
            // visitIdTextBox
            // 
            this.visitIdTextBox.Location = new System.Drawing.Point(274, 117);
            this.visitIdTextBox.Name = "visitIdTextBox";
            this.visitIdTextBox.ReadOnly = true;
            this.visitIdTextBox.Size = new System.Drawing.Size(130, 20);
            this.visitIdTextBox.TabIndex = 6;
            this.visitIdTextBox.TextChanged += new System.EventHandler(this.VisitIdTextBoxTextChanged);
            // 
            // visitIdErrorLabel
            // 
            this.visitIdErrorLabel.AutoSize = true;
            this.visitIdErrorLabel.Location = new System.Drawing.Point(224, 150);
            this.visitIdErrorLabel.Name = "visitIdErrorLabel";
            this.visitIdErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.visitIdErrorLabel.TabIndex = 7;
            this.visitIdErrorLabel.Text = "label1";
            this.visitIdErrorLabel.Visible = false;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(224, 42);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(45, 13);
            this.patientNameLabel.TabIndex = 8;
            this.patientNameLabel.Text = "search";
            // 
            // SearchTestResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.visitIdErrorLabel);
            this.Controls.Add(this.visitIdTextBox);
            this.Controls.Add(this.visitIdLabel);
            this.Controls.Add(this.visitIdResetButton);
            this.Controls.Add(this.visitIdButton);
            this.Controls.Add(this.visitIdRadioButton);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.searchTestTitleLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "SearchTestResultsUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.Load += new System.EventHandler(this.SearchTestResultsUserControlLoad);
            this.VisibleChanged += new System.EventHandler(this.SearchTestResultsUserControlVisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTestTitleLabel;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.RadioButton visitIdRadioButton;
        private System.Windows.Forms.Button visitIdButton;
        private System.Windows.Forms.Button visitIdResetButton;
        private System.Windows.Forms.Label visitIdLabel;
        private System.Windows.Forms.TextBox visitIdTextBox;
        private System.Windows.Forms.Label visitIdErrorLabel;
        private System.Windows.Forms.Label patientNameLabel;
    }
}
