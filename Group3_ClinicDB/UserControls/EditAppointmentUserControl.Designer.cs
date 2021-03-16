
namespace Group3_ClinicDB.UserControls
{
    partial class EditAppointmentUserControl
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
            this.PatientIDTextbox = new System.Windows.Forms.TextBox();
            this.PatientIDLabel = new System.Windows.Forms.Label();
            this.PatientNameTextbox = new System.Windows.Forms.TextBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.ApptSelectLabel = new System.Windows.Forms.Label();
            this.ApptSelectComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ApptTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonRichText = new System.Windows.Forms.RichTextBox();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientIDTextbox
            // 
            this.PatientIDTextbox.Location = new System.Drawing.Point(126, 55);
            this.PatientIDTextbox.Name = "PatientIDTextbox";
            this.PatientIDTextbox.ReadOnly = true;
            this.PatientIDTextbox.Size = new System.Drawing.Size(107, 20);
            this.PatientIDTextbox.TabIndex = 7;
            // 
            // PatientIDLabel
            // 
            this.PatientIDLabel.AutoSize = true;
            this.PatientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDLabel.Location = new System.Drawing.Point(19, 57);
            this.PatientIDLabel.Name = "PatientIDLabel";
            this.PatientIDLabel.Size = new System.Drawing.Size(79, 18);
            this.PatientIDLabel.TabIndex = 6;
            this.PatientIDLabel.Text = "Patient ID: ";
            // 
            // PatientNameTextbox
            // 
            this.PatientNameTextbox.Location = new System.Drawing.Point(126, 21);
            this.PatientNameTextbox.Name = "PatientNameTextbox";
            this.PatientNameTextbox.ReadOnly = true;
            this.PatientNameTextbox.Size = new System.Drawing.Size(333, 20);
            this.PatientNameTextbox.TabIndex = 5;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(19, 23);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(101, 18);
            this.PatientNameLabel.TabIndex = 4;
            this.PatientNameLabel.Text = "Patient Name:";
            // 
            // ApptSelectLabel
            // 
            this.ApptSelectLabel.AutoSize = true;
            this.ApptSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSelectLabel.Location = new System.Drawing.Point(19, 110);
            this.ApptSelectLabel.Name = "ApptSelectLabel";
            this.ApptSelectLabel.Size = new System.Drawing.Size(143, 18);
            this.ApptSelectLabel.TabIndex = 8;
            this.ApptSelectLabel.Text = "Select Appointment: ";
            // 
            // ApptSelectComboBox
            // 
            this.ApptSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptSelectComboBox.FormattingEnabled = true;
            this.ApptSelectComboBox.Location = new System.Drawing.Point(22, 143);
            this.ApptSelectComboBox.Name = "ApptSelectComboBox";
            this.ApptSelectComboBox.Size = new System.Drawing.Size(227, 21);
            this.ApptSelectComboBox.TabIndex = 9;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(19, 203);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 18);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Time: ";
            // 
            // ApptTimePicker
            // 
            this.ApptTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ApptTimePicker.Location = new System.Drawing.Point(99, 201);
            this.ApptTimePicker.Name = "ApptTimePicker";
            this.ApptTimePicker.Size = new System.Drawing.Size(107, 20);
            this.ApptTimePicker.TabIndex = 11;
            // 
            // ReasonRichText
            // 
            this.ReasonRichText.Location = new System.Drawing.Point(99, 337);
            this.ReasonRichText.Name = "ReasonRichText";
            this.ReasonRichText.Size = new System.Drawing.Size(316, 164);
            this.ReasonRichText.TabIndex = 15;
            this.ReasonRichText.Text = "";
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonLabel.Location = new System.Drawing.Point(22, 336);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(68, 18);
            this.ReasonLabel.TabIndex = 14;
            this.ReasonLabel.Text = "Reason: ";
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(99, 265);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(243, 21);
            this.DoctorComboBox.TabIndex = 13;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLabel.Location = new System.Drawing.Point(22, 265);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(62, 18);
            this.DoctorNameLabel.TabIndex = 12;
            this.DoctorNameLabel.Text = "Doctor: ";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(99, 544);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 45);
            this.ConfirmButton.TabIndex = 16;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(298, 544);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 45);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EditAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ReasonRichText);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.DoctorComboBox);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.ApptTimePicker);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ApptSelectComboBox);
            this.Controls.Add(this.ApptSelectLabel);
            this.Controls.Add(this.PatientIDTextbox);
            this.Controls.Add(this.PatientIDLabel);
            this.Controls.Add(this.PatientNameTextbox);
            this.Controls.Add(this.PatientNameLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "EditAppointmentUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatientIDTextbox;
        private System.Windows.Forms.Label PatientIDLabel;
        private System.Windows.Forms.TextBox PatientNameTextbox;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label ApptSelectLabel;
        private System.Windows.Forms.ComboBox ApptSelectComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker ApptTimePicker;
        private System.Windows.Forms.RichTextBox ReasonRichText;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
