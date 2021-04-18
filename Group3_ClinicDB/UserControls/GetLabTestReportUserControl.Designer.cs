
namespace Group3_ClinicDB.UserControls
{
    partial class GetLabTestReportUserControl
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
            this.LabTestPerformedReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.GetReportButton = new System.Windows.Forms.Button();
            this.DatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabTestPerformedReport
            // 
            this.LabTestPerformedReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabTestPerformedReport.Location = new System.Drawing.Point(0, 146);
            this.LabTestPerformedReport.Name = "LabTestPerformedReport";
            this.LabTestPerformedReport.ServerReport.BearerToken = null;
            this.LabTestPerformedReport.ShowToolBar = false;
            this.LabTestPerformedReport.Size = new System.Drawing.Size(1215, 469);
            this.LabTestPerformedReport.TabIndex = 0;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(58, 45);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(99, 20);
            this.StartDatePicker.TabIndex = 1;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndTimePicker.Location = new System.Drawing.Point(262, 45);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(99, 20);
            this.EndTimePicker.TabIndex = 2;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(55, 27);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(75, 15);
            this.StartDateLabel.TabIndex = 3;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(259, 27);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(70, 15);
            this.EndDateLabel.TabIndex = 4;
            this.EndDateLabel.Text = "End Date:";
            // 
            // DatePanel
            // 
            this.DatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatePanel.Controls.Add(this.EndDateLabel);
            this.DatePanel.Controls.Add(this.StartDatePicker);
            this.DatePanel.Controls.Add(this.StartDateLabel);
            this.DatePanel.Controls.Add(this.EndTimePicker);
            this.DatePanel.Location = new System.Drawing.Point(14, 20);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(420, 100);
            this.DatePanel.TabIndex = 5;
            // 
            // GetReportButton
            // 
            this.GetReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetReportButton.Location = new System.Drawing.Point(491, 35);
            this.GetReportButton.Name = "GetReportButton";
            this.GetReportButton.Size = new System.Drawing.Size(138, 65);
            this.GetReportButton.TabIndex = 6;
            this.GetReportButton.Text = "Get Report";
            this.GetReportButton.UseVisualStyleBackColor = true;
            // 
            // GetLabTestReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GetReportButton);
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.LabTestPerformedReport);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "GetLabTestReportUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer LabTestPerformedReport;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.Button GetReportButton;
    }
}
