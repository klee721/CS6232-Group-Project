
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
            this.ApptSelectLabel = new System.Windows.Forms.Label();
            this.ApptSelectComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ReasonRichText = new System.Windows.Forms.RichTextBox();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Minus30Button = new System.Windows.Forms.Button();
            this.Plus30Button = new System.Windows.Forms.Button();
            this.ApptTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ApptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApptSelectLabel
            // 
            this.ApptSelectLabel.AutoSize = true;
            this.ApptSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSelectLabel.Location = new System.Drawing.Point(19, 15);
            this.ApptSelectLabel.Name = "ApptSelectLabel";
            this.ApptSelectLabel.Size = new System.Drawing.Size(143, 18);
            this.ApptSelectLabel.TabIndex = 8;
            this.ApptSelectLabel.Text = "Select Appointment: ";
            // 
            // ApptSelectComboBox
            // 
            this.ApptSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptSelectComboBox.FormattingEnabled = true;
            this.ApptSelectComboBox.Location = new System.Drawing.Point(22, 48);
            this.ApptSelectComboBox.Name = "ApptSelectComboBox";
            this.ApptSelectComboBox.Size = new System.Drawing.Size(227, 21);
            this.ApptSelectComboBox.TabIndex = 1;
            this.ApptSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.ApptSelectComboBox_SelectedIndexChanged);
            this.ApptSelectComboBox.Click += new System.EventHandler(this.RefreshList);
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
            // ReasonRichText
            // 
            this.ReasonRichText.Location = new System.Drawing.Point(99, 337);
            this.ReasonRichText.Name = "ReasonRichText";
            this.ReasonRichText.Size = new System.Drawing.Size(316, 164);
            this.ReasonRichText.TabIndex = 6;
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
            this.DoctorComboBox.TabIndex = 5;
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
            this.ConfirmButton.Location = new System.Drawing.Point(28, 530);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(134, 59);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm Changes";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(225, 530);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 59);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel Appointment";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Minus30Button
            // 
            this.Minus30Button.Location = new System.Drawing.Point(180, 214);
            this.Minus30Button.Name = "Minus30Button";
            this.Minus30Button.Size = new System.Drawing.Size(54, 23);
            this.Minus30Button.TabIndex = 4;
            this.Minus30Button.Text = "-30";
            this.Minus30Button.UseVisualStyleBackColor = true;
            this.Minus30Button.Click += new System.EventHandler(this.Minus30Button_Click_1);
            // 
            // Plus30Button
            // 
            this.Plus30Button.Location = new System.Drawing.Point(180, 185);
            this.Plus30Button.Name = "Plus30Button";
            this.Plus30Button.Size = new System.Drawing.Size(54, 23);
            this.Plus30Button.TabIndex = 3;
            this.Plus30Button.Text = "+30";
            this.Plus30Button.UseVisualStyleBackColor = true;
            this.Plus30Button.Click += new System.EventHandler(this.Plus30Button_Click);
            // 
            // ApptTimePicker
            // 
            this.ApptTimePicker.CustomFormat = "hh:mm tt";
            this.ApptTimePicker.Enabled = false;
            this.ApptTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptTimePicker.Location = new System.Drawing.Point(99, 203);
            this.ApptTimePicker.Name = "ApptTimePicker";
            this.ApptTimePicker.Size = new System.Drawing.Size(75, 20);
            this.ApptTimePicker.TabIndex = 18;
            this.ApptTimePicker.Value = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            // 
            // ApptDatePicker
            // 
            this.ApptDatePicker.Location = new System.Drawing.Point(99, 126);
            this.ApptDatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.ApptDatePicker.Name = "ApptDatePicker";
            this.ApptDatePicker.Size = new System.Drawing.Size(185, 20);
            this.ApptDatePicker.TabIndex = 2;
            this.ApptDatePicker.Value = new System.DateTime(2021, 3, 21, 19, 39, 45, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(22, 128);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(43, 18);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Date:";
            // 
            // EditAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApptDatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Minus30Button);
            this.Controls.Add(this.Plus30Button);
            this.Controls.Add(this.ApptTimePicker);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ReasonRichText);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.DoctorComboBox);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ApptSelectComboBox);
            this.Controls.Add(this.ApptSelectLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "EditAppointmentUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ApptSelectLabel;
        private System.Windows.Forms.ComboBox ApptSelectComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.RichTextBox ReasonRichText;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Minus30Button;
        private System.Windows.Forms.Button Plus30Button;
        private System.Windows.Forms.DateTimePicker ApptTimePicker;
        private System.Windows.Forms.DateTimePicker ApptDatePicker;
        private System.Windows.Forms.Label DateLabel;
    }
}
