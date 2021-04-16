
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
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.performedDateTimeLabel = new System.Windows.Forms.Label();
            this.performedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testCodeLabel = new System.Windows.Forms.Label();
            this.testCodeTextBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.normalLabel = new System.Windows.Forms.Label();
            this.normalComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(227, 70);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDataGridView.Size = new System.Drawing.Size(717, 150);
            this.patientDataGridView.TabIndex = 0;
            this.patientDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientDataGridViewCellMouseClick);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(227, 255);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(41, 13);
            this.patientNameLabel.TabIndex = 1;
            this.patientNameLabel.Text = "label1";
            this.patientNameLabel.Visible = false;
            // 
            // orderDateTimeLabel
            // 
            this.orderDateTimeLabel.AutoSize = true;
            this.orderDateTimeLabel.Location = new System.Drawing.Point(227, 321);
            this.orderDateTimeLabel.Name = "orderDateTimeLabel";
            this.orderDateTimeLabel.Size = new System.Drawing.Size(142, 13);
            this.orderDateTimeLabel.TabIndex = 2;
            this.orderDateTimeLabel.Text = "Lab Test Ordered DateTime:";
            this.orderDateTimeLabel.Visible = false;
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Enabled = false;
            this.orderDateTimePicker.Location = new System.Drawing.Point(385, 321);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateTimePicker.TabIndex = 3;
            this.orderDateTimePicker.Visible = false;
            // 
            // performedDateTimeLabel
            // 
            this.performedDateTimeLabel.AutoSize = true;
            this.performedDateTimeLabel.Location = new System.Drawing.Point(227, 402);
            this.performedDateTimeLabel.Name = "performedDateTimeLabel";
            this.performedDateTimeLabel.Size = new System.Drawing.Size(152, 13);
            this.performedDateTimeLabel.TabIndex = 4;
            this.performedDateTimeLabel.Text = "Lab Test Performed DateTime:";
            this.performedDateTimeLabel.Visible = false;
            // 
            // performedDateTimePicker
            // 
            this.performedDateTimePicker.Location = new System.Drawing.Point(385, 400);
            this.performedDateTimePicker.Name = "performedDateTimePicker";
            this.performedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.performedDateTimePicker.TabIndex = 5;
            this.performedDateTimePicker.Visible = false;
            // 
            // testCodeLabel
            // 
            this.testCodeLabel.AutoSize = true;
            this.testCodeLabel.Location = new System.Drawing.Point(230, 484);
            this.testCodeLabel.Name = "testCodeLabel";
            this.testCodeLabel.Size = new System.Drawing.Size(59, 13);
            this.testCodeLabel.TabIndex = 6;
            this.testCodeLabel.Text = "Test Code:";
            this.testCodeLabel.Visible = false;
            // 
            // testCodeTextBox
            // 
            this.testCodeTextBox.Location = new System.Drawing.Point(385, 484);
            this.testCodeTextBox.Name = "testCodeTextBox";
            this.testCodeTextBox.ReadOnly = true;
            this.testCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.testCodeTextBox.TabIndex = 7;
            this.testCodeTextBox.Visible = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(657, 321);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 8;
            this.resultsLabel.Text = "Results:";
            this.resultsLabel.Visible = false;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(721, 318);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(235, 102);
            this.resultsTextBox.TabIndex = 9;
            this.resultsTextBox.Visible = false;
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(660, 483);
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
            this.normalComboBox.Location = new System.Drawing.Point(721, 480);
            this.normalComboBox.Name = "normalComboBox";
            this.normalComboBox.Size = new System.Drawing.Size(67, 21);
            this.normalComboBox.TabIndex = 11;
            this.normalComboBox.Visible = false;
            // 
            // EnterTestResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.normalComboBox);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.testCodeTextBox);
            this.Controls.Add(this.testCodeLabel);
            this.Controls.Add(this.performedDateTimePicker);
            this.Controls.Add(this.performedDateTimeLabel);
            this.Controls.Add(this.orderDateTimePicker);
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
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
        private System.Windows.Forms.Label performedDateTimeLabel;
        private System.Windows.Forms.DateTimePicker performedDateTimePicker;
        private System.Windows.Forms.Label testCodeLabel;
        private System.Windows.Forms.TextBox testCodeTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.ComboBox normalComboBox;
    }
}
