
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
            this.ApptPanel = new System.Windows.Forms.Panel();
            this.Minus30Button = new System.Windows.Forms.Button();
            this.Plus30Button = new System.Windows.Forms.Button();
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
            // ApptPanel
            // 
            this.ApptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApptPanel.Controls.Add(this.Minus30Button);
            this.ApptPanel.Controls.Add(this.Plus30Button);
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
            this.ApptPanel.Location = new System.Drawing.Point(21, 71);
            this.ApptPanel.Name = "ApptPanel";
            this.ApptPanel.Size = new System.Drawing.Size(1168, 456);
            this.ApptPanel.TabIndex = 4;
            // 
            // Minus30Button
            // 
            this.Minus30Button.Location = new System.Drawing.Point(201, 132);
            this.Minus30Button.Name = "Minus30Button";
            this.Minus30Button.Size = new System.Drawing.Size(54, 23);
            this.Minus30Button.TabIndex = 12;
            this.Minus30Button.Text = "-30";
            this.Minus30Button.UseVisualStyleBackColor = true;
            this.Minus30Button.Click += new System.EventHandler(this.Minus30Button_Click);
            // 
            // Plus30Button
            // 
            this.Plus30Button.Location = new System.Drawing.Point(201, 103);
            this.Plus30Button.Name = "Plus30Button";
            this.Plus30Button.Size = new System.Drawing.Size(54, 23);
            this.Plus30Button.TabIndex = 11;
            this.Plus30Button.Text = "+30";
            this.Plus30Button.UseVisualStyleBackColor = true;
            this.Plus30Button.Click += new System.EventHandler(this.Plus30_Click);
            // 
            // CreateApptButton
            // 
            this.CreateApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateApptButton.Location = new System.Drawing.Point(903, 356);
            this.CreateApptButton.Name = "CreateApptButton";
            this.CreateApptButton.Size = new System.Drawing.Size(173, 44);
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
            this.ApptTimePicker.CustomFormat = "hh:mm tt";
            this.ApptTimePicker.Enabled = false;
            this.ApptTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptTimePicker.Location = new System.Drawing.Point(120, 121);
            this.ApptTimePicker.Name = "ApptTimePicker";
            this.ApptTimePicker.Size = new System.Drawing.Size(75, 20);
            this.ApptTimePicker.TabIndex = 7;
            this.ApptTimePicker.Value = new System.DateTime(2021, 3, 22, 12, 0, 0, 0);
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
            this.ApptDatePicker.Size = new System.Drawing.Size(185, 20);
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
            this.NewApptLabel.Location = new System.Drawing.Point(36, 61);
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
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "AppointmentBookingUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.EnabledChanged += new System.EventHandler(this.ClearApptList);
            this.ApptPanel.ResumeLayout(false);
            this.ApptPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientApptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button CreateApptButton;
        private System.Windows.Forms.Button Minus30Button;
        private System.Windows.Forms.Button Plus30Button;
    }
}
