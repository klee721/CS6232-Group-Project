
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
            this.LabTestPerformedReportGrid = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.GetReportButton = new System.Windows.Forms.Button();
            this.DatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabTestPerformedReportGrid
            // 
            this.LabTestPerformedReportGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabTestPerformedReportGrid.Location = new System.Drawing.Point(0, 245);
            this.LabTestPerformedReportGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabTestPerformedReportGrid.Name = "LabTestPerformedReportGrid";
            this.LabTestPerformedReportGrid.ServerReport.BearerToken = null;
            this.LabTestPerformedReportGrid.ShowToolBar = false;
            this.LabTestPerformedReportGrid.Size = new System.Drawing.Size(1822, 701);
            this.LabTestPerformedReportGrid.TabIndex = 0;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(87, 69);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(146, 26);
            this.StartDatePicker.TabIndex = 1;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(393, 69);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(146, 26);
            this.EndDatePicker.TabIndex = 2;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(82, 42);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(75, 15);
            this.StartDateLabel.TabIndex = 3;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(388, 42);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.DatePanel.Controls.Add(this.EndDatePicker);
            this.DatePanel.Location = new System.Drawing.Point(21, 31);
            this.DatePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(629, 153);
            this.DatePanel.TabIndex = 5;
            // 
            // GetReportButton
            // 
            this.GetReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetReportButton.Location = new System.Drawing.Point(736, 54);
            this.GetReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetReportButton.Name = "GetReportButton";
            this.GetReportButton.Size = new System.Drawing.Size(207, 100);
            this.GetReportButton.TabIndex = 6;
            this.GetReportButton.Text = "Get Report";
            this.GetReportButton.UseVisualStyleBackColor = true;
            // 
            // GetLabTestReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GetReportButton);
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.LabTestPerformedReportGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1822, 946);
            this.MinimumSize = new System.Drawing.Size(1822, 946);
            this.Name = "GetLabTestReportUserControl";
            this.Size = new System.Drawing.Size(1822, 946);
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer LabTestPerformedReportGrid;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.Button GetReportButton;
    }
}
