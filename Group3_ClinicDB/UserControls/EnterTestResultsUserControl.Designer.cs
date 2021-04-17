
namespace Group3_ClinicDB.UserControls
{
    partial class EnterTestResultsUserControl
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
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.orderDateTimeLabel = new System.Windows.Forms.Label();
            this.testCodeLabel = new System.Windows.Forms.Label();
            this.testCodeTextBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.normalLabel = new System.Windows.Forms.Label();
            this.normalComboBox = new System.Windows.Forms.ComboBox();
            this.testResultsButton = new System.Windows.Forms.Button();
            this.resultsErrorLabel = new System.Windows.Forms.Label();
            this.performedDateTimeLabel = new System.Windows.Forms.Label();
            this.fullOrderedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.fullPerformedDateTimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(228, 36);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDataGridView.Size = new System.Drawing.Size(717, 174);
            this.patientDataGridView.TabIndex = 0;
            this.patientDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientDataGridViewCellMouseClick);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(228, 233);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(41, 13);
            this.patientNameLabel.TabIndex = 1;
            this.patientNameLabel.Text = "label1";
            this.patientNameLabel.Visible = false;
            // 
            // orderDateTimeLabel
            // 
            this.orderDateTimeLabel.AutoSize = true;
            this.orderDateTimeLabel.Location = new System.Drawing.Point(228, 287);
            this.orderDateTimeLabel.Name = "orderDateTimeLabel";
            this.orderDateTimeLabel.Size = new System.Drawing.Size(142, 13);
            this.orderDateTimeLabel.TabIndex = 2;
            this.orderDateTimeLabel.Text = "Lab Test Ordered DateTime:";
            this.orderDateTimeLabel.Visible = false;
            // 
            // testCodeLabel
            // 
            this.testCodeLabel.AutoSize = true;
            this.testCodeLabel.Location = new System.Drawing.Point(228, 377);
            this.testCodeLabel.Name = "testCodeLabel";
            this.testCodeLabel.Size = new System.Drawing.Size(59, 13);
            this.testCodeLabel.TabIndex = 6;
            this.testCodeLabel.Text = "Test Code:";
            this.testCodeLabel.Visible = false;
            // 
            // testCodeTextBox
            // 
            this.testCodeTextBox.Location = new System.Drawing.Point(396, 377);
            this.testCodeTextBox.Name = "testCodeTextBox";
            this.testCodeTextBox.ReadOnly = true;
            this.testCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.testCodeTextBox.TabIndex = 7;
            this.testCodeTextBox.Visible = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(643, 287);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 8;
            this.resultsLabel.Text = "Results:";
            this.resultsLabel.Visible = false;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(707, 284);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(235, 138);
            this.resultsTextBox.TabIndex = 9;
            this.resultsTextBox.Visible = false;
            this.resultsTextBox.TextChanged += new System.EventHandler(this.ResultsTextBoxTextChanged);
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(231, 432);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(49, 13);
            this.normalLabel.TabIndex = 10;
            this.normalLabel.Text = "Normal?:";
            this.normalLabel.Visible = false;
            // 
            // normalComboBox
            // 
            this.normalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.normalComboBox.FormattingEnabled = true;
            this.normalComboBox.Location = new System.Drawing.Point(396, 424);
            this.normalComboBox.Name = "normalComboBox";
            this.normalComboBox.Size = new System.Drawing.Size(127, 21);
            this.normalComboBox.TabIndex = 11;
            this.normalComboBox.Visible = false;
            // 
            // testResultsButton
            // 
            this.testResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testResultsButton.Location = new System.Drawing.Point(707, 448);
            this.testResultsButton.Name = "testResultsButton";
            this.testResultsButton.Size = new System.Drawing.Size(235, 40);
            this.testResultsButton.TabIndex = 12;
            this.testResultsButton.Text = "Enter Results";
            this.testResultsButton.UseVisualStyleBackColor = true;
            this.testResultsButton.Visible = false;
            this.testResultsButton.Click += new System.EventHandler(this.TestResultsButtonClick);
            // 
            // resultsErrorLabel
            // 
            this.resultsErrorLabel.AutoSize = true;
            this.resultsErrorLabel.Location = new System.Drawing.Point(704, 491);
            this.resultsErrorLabel.Name = "resultsErrorLabel";
            this.resultsErrorLabel.Size = new System.Drawing.Size(144, 13);
            this.resultsErrorLabel.TabIndex = 13;
            this.resultsErrorLabel.Text = "Results entered successfully!";
            this.resultsErrorLabel.Visible = false;
            // 
            // performedDateTimeLabel
            // 
            this.performedDateTimeLabel.AutoSize = true;
            this.performedDateTimeLabel.Location = new System.Drawing.Point(228, 333);
            this.performedDateTimeLabel.Name = "performedDateTimeLabel";
            this.performedDateTimeLabel.Size = new System.Drawing.Size(155, 13);
            this.performedDateTimeLabel.TabIndex = 15;
            this.performedDateTimeLabel.Text = "Lab Test Performed Date Time:";
            // 
            // fullOrderedDateTimeTextBox
            // 
            this.fullOrderedDateTimeTextBox.Location = new System.Drawing.Point(396, 284);
            this.fullOrderedDateTimeTextBox.Name = "fullOrderedDateTimeTextBox";
            this.fullOrderedDateTimeTextBox.ReadOnly = true;
            this.fullOrderedDateTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullOrderedDateTimeTextBox.TabIndex = 17;
            this.fullOrderedDateTimeTextBox.Visible = false;
            // 
            // fullPerformedDateTimeTextBox
            // 
            this.fullPerformedDateTimeTextBox.Location = new System.Drawing.Point(396, 333);
            this.fullPerformedDateTimeTextBox.Name = "fullPerformedDateTimeTextBox";
            this.fullPerformedDateTimeTextBox.ReadOnly = true;
            this.fullPerformedDateTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullPerformedDateTimeTextBox.TabIndex = 18;
            this.fullPerformedDateTimeTextBox.Visible = false;
            // 
            // EnterTestResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fullPerformedDateTimeTextBox);
            this.Controls.Add(this.fullOrderedDateTimeTextBox);
            this.Controls.Add(this.performedDateTimeLabel);
            this.Controls.Add(this.resultsErrorLabel);
            this.Controls.Add(this.testResultsButton);
            this.Controls.Add(this.normalComboBox);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.testCodeTextBox);
            this.Controls.Add(this.testCodeLabel);
            this.Controls.Add(this.orderDateTimeLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientDataGridView);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "EnterTestResultsUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.Load += new System.EventHandler(this.EnterTestResultsUserControlLoad);
            this.VisibleChanged += new System.EventHandler(this.EnterTestResultsUserControlVisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label orderDateTimeLabel;
        private System.Windows.Forms.Label testCodeLabel;
        private System.Windows.Forms.TextBox testCodeTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.ComboBox normalComboBox;
        private System.Windows.Forms.Button testResultsButton;
        private System.Windows.Forms.Label resultsErrorLabel;
        private System.Windows.Forms.Label performedDateTimeLabel;
        private System.Windows.Forms.TextBox fullOrderedDateTimeTextBox;
        private System.Windows.Forms.TextBox fullPerformedDateTimeTextBox;
    }
}
