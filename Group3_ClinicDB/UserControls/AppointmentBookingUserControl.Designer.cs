
namespace Group3_ClinicDB.UserControls
{
    partial class AppointmentBookingUserControl
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
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientNameTextbox = new System.Windows.Forms.TextBox();
            this.PatientIDLabel = new System.Windows.Forms.Label();
            this.PatientIDTextbox = new System.Windows.Forms.TextBox();
            this.ApptPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateApptButton = new System.Windows.Forms.Button();
            this.PatientApptListLabel = new System.Windows.Forms.Label();
            this.PatientApptList = new System.Windows.Forms.DataGridView();
            this.ApptTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ReasonRichText = new System.Windows.Forms.RichTextBox();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.ApptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NewApptLabel = new System.Windows.Forms.Label();
            this.ApptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientApptList)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(19, 34);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(101, 18);
            this.PatientNameLabel.TabIndex = 0;
            this.PatientNameLabel.Text = "Patient Name:";
            // 
            // PatientNameTextbox
            // 
            this.PatientNameTextbox.Location = new System.Drawing.Point(126, 32);
            this.PatientNameTextbox.Name = "PatientNameTextbox";
            this.PatientNameTextbox.ReadOnly = true;
            this.PatientNameTextbox.Size = new System.Drawing.Size(333, 20);
            this.PatientNameTextbox.TabIndex = 1;
            // 
            // PatientIDLabel
            // 
            this.PatientIDLabel.AutoSize = true;
            this.PatientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDLabel.Location = new System.Drawing.Point(19, 68);
            this.PatientIDLabel.Name = "PatientIDLabel";
            this.PatientIDLabel.Size = new System.Drawing.Size(79, 18);
            this.PatientIDLabel.TabIndex = 2;
            this.PatientIDLabel.Text = "Patient ID: ";
            // 
            // PatientIDTextbox
            // 
            this.PatientIDTextbox.Location = new System.Drawing.Point(126, 66);
            this.PatientIDTextbox.Name = "PatientIDTextbox";
            this.PatientIDTextbox.ReadOnly = true;
            this.PatientIDTextbox.Size = new System.Drawing.Size(107, 20);
            this.PatientIDTextbox.TabIndex = 3;
            // 
            // ApptPanel
            // 
            this.ApptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApptPanel.Controls.Add(this.ClearButton);
            this.ApptPanel.Controls.Add(this.CreateApptButton);
            this.ApptPanel.Controls.Add(this.PatientApptListLabel);
            this.ApptPanel.Controls.Add(this.PatientApptList);
            this.ApptPanel.Controls.Add(this.ApptTimePicker);
            this.ApptPanel.Controls.Add(this.TimeLabel);
            this.ApptPanel.Controls.Add(this.ReasonRichText);
            this.ApptPanel.Controls.Add(this.ReasonLabel);
            this.ApptPanel.Controls.Add(this.DoctorComboBox);
            this.ApptPanel.Controls.Add(this.DoctorNameLabel);
            this.ApptPanel.Controls.Add(this.ApptDatePicker);
            this.ApptPanel.Controls.Add(this.DateLabel);
            this.ApptPanel.Location = new System.Drawing.Point(22, 138);
            this.ApptPanel.Name = "ApptPanel";
            this.ApptPanel.Size = new System.Drawing.Size(1168, 456);
            this.ApptPanel.TabIndex = 4;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(955, 368);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(180, 32);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // CreateApptButton
            // 
            this.CreateApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateApptButton.Location = new System.Drawing.Point(752, 368);
            this.CreateApptButton.Name = "CreateApptButton";
            this.CreateApptButton.Size = new System.Drawing.Size(180, 32);
            this.CreateApptButton.TabIndex = 10;
            this.CreateApptButton.Text = "Create Appointment";
            this.CreateApptButton.UseVisualStyleBackColor = true;
            this.CreateApptButton.Click += new System.EventHandler(this.CreateApptButton_Click);
            // 
            // PatientApptListLabel
            // 
            this.PatientApptListLabel.AutoSize = true;
            this.PatientApptListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientApptListLabel.Location = new System.Drawing.Point(501, 14);
            this.PatientApptListLabel.Name = "PatientApptListLabel";
            this.PatientApptListLabel.Size = new System.Drawing.Size(102, 18);
            this.PatientApptListLabel.TabIndex = 9;
            this.PatientApptListLabel.Text = "Appointments:";
            // 
            // PatientApptList
            // 
            this.PatientApptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientApptList.Location = new System.Drawing.Point(504, 55);
            this.PatientApptList.Name = "PatientApptList";
            this.PatientApptList.Size = new System.Drawing.Size(631, 184);
            this.PatientApptList.TabIndex = 8;
            // 
            // ApptTimePicker
            // 
            this.ApptTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ApptTimePicker.Location = new System.Drawing.Point(120, 121);
            this.ApptTimePicker.Name = "ApptTimePicker";
            this.ApptTimePicker.Size = new System.Drawing.Size(107, 20);
            this.ApptTimePicker.TabIndex = 7;
            this.ApptTimePicker.Value = new System.DateTime(2021, 3, 21, 19, 27, 0, 0);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(43, 121);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 18);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "Time: ";
            // 
            // ReasonRichText
            // 
            this.ReasonRichText.Location = new System.Drawing.Point(120, 262);
            this.ReasonRichText.Name = "ReasonRichText";
            this.ReasonRichText.Size = new System.Drawing.Size(573, 138);
            this.ReasonRichText.TabIndex = 5;
            this.ReasonRichText.Text = "";
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonLabel.Location = new System.Drawing.Point(43, 261);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(68, 18);
            this.ReasonLabel.TabIndex = 4;
            this.ReasonLabel.Text = "Reason: ";
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(120, 190);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(243, 21);
            this.DoctorComboBox.TabIndex = 3;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLabel.Location = new System.Drawing.Point(43, 190);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(62, 18);
            this.DoctorNameLabel.TabIndex = 2;
            this.DoctorNameLabel.Text = "Doctor: ";
            // 
            // ApptDatePicker
            // 
            this.ApptDatePicker.Location = new System.Drawing.Point(120, 55);
            this.ApptDatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.ApptDatePicker.Name = "ApptDatePicker";
            this.ApptDatePicker.Size = new System.Drawing.Size(243, 20);
            this.ApptDatePicker.TabIndex = 1;
            this.ApptDatePicker.Value = new System.DateTime(2021, 3, 21, 19, 39, 45, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(43, 57);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(43, 18);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date:";
            // 
            // NewApptLabel
            // 
            this.NewApptLabel.AutoSize = true;
            this.NewApptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewApptLabel.Location = new System.Drawing.Point(37, 128);
            this.NewApptLabel.Name = "NewApptLabel";
            this.NewApptLabel.Size = new System.Drawing.Size(163, 26);
            this.NewApptLabel.TabIndex = 5;
            this.NewApptLabel.Text = "New Appointment";
            // 
            // AppointmentBookingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewApptLabel);
            this.Controls.Add(this.ApptPanel);
            this.Controls.Add(this.PatientIDTextbox);
            this.Controls.Add(this.PatientIDLabel);
            this.Controls.Add(this.PatientNameTextbox);
            this.Controls.Add(this.PatientNameLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "AppointmentBookingUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.ApptPanel.ResumeLayout(false);
            this.ApptPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientApptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.TextBox PatientNameTextbox;
        private System.Windows.Forms.Label PatientIDLabel;
        private System.Windows.Forms.TextBox PatientIDTextbox;
        private System.Windows.Forms.Panel ApptPanel;
        private System.Windows.Forms.RichTextBox ReasonRichText;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.DateTimePicker ApptDatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NewApptLabel;
        private System.Windows.Forms.DateTimePicker ApptTimePicker;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DataGridView PatientApptList;
        private System.Windows.Forms.Label PatientApptListLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CreateApptButton;
    }
}
