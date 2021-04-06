
namespace Group3_ClinicDB.UserControls
{
    partial class AddVisitUserControl
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
            System.Windows.Forms.Label appointment_idLabel;
            System.Windows.Forms.Label bloodPressureDiastolicLabel;
            System.Windows.Forms.Label bloodPressureSystolicLabel;
            System.Windows.Forms.Label bodyTemparatureLabel;
            System.Windows.Forms.Label finalDiagnoseLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label initialDiagnoseLabel;
            System.Windows.Forms.Label nurseIdLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label weightLabel;
            this.bloodPressureDiastolicTextBox = new System.Windows.Forms.TextBox();
            this.bloodPressureSystolicTextBox = new System.Windows.Forms.TextBox();
            this.bodyTemparatureTextBox = new System.Windows.Forms.TextBox();
            this.finalDiagnoseTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnoseTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.appointment_idComboBox = new System.Windows.Forms.ComboBox();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.nurseComboBox = new System.Windows.Forms.ComboBox();
            appointment_idLabel = new System.Windows.Forms.Label();
            bloodPressureDiastolicLabel = new System.Windows.Forms.Label();
            bloodPressureSystolicLabel = new System.Windows.Forms.Label();
            bodyTemparatureLabel = new System.Windows.Forms.Label();
            finalDiagnoseLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            initialDiagnoseLabel = new System.Windows.Forms.Label();
            nurseIdLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointment_idLabel
            // 
            appointment_idLabel.AutoSize = true;
            appointment_idLabel.Location = new System.Drawing.Point(53, 17);
            appointment_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appointment_idLabel.Name = "appointment_idLabel";
            appointment_idLabel.Size = new System.Drawing.Size(94, 13);
            appointment_idLabel.TabIndex = 1;
            appointment_idLabel.Text = "appointment Time:";
            // 
            // bloodPressureDiastolicLabel
            // 
            bloodPressureDiastolicLabel.AutoSize = true;
            bloodPressureDiastolicLabel.Location = new System.Drawing.Point(53, 40);
            bloodPressureDiastolicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bloodPressureDiastolicLabel.Name = "bloodPressureDiastolicLabel";
            bloodPressureDiastolicLabel.Size = new System.Drawing.Size(123, 13);
            bloodPressureDiastolicLabel.TabIndex = 3;
            bloodPressureDiastolicLabel.Text = "blood Pressure Diastolic:";
            // 
            // bloodPressureSystolicLabel
            // 
            bloodPressureSystolicLabel.AutoSize = true;
            bloodPressureSystolicLabel.Location = new System.Drawing.Point(53, 63);
            bloodPressureSystolicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bloodPressureSystolicLabel.Name = "bloodPressureSystolicLabel";
            bloodPressureSystolicLabel.Size = new System.Drawing.Size(119, 13);
            bloodPressureSystolicLabel.TabIndex = 5;
            bloodPressureSystolicLabel.Text = "blood Pressure Systolic:";
            // 
            // bodyTemparatureLabel
            // 
            bodyTemparatureLabel.AutoSize = true;
            bodyTemparatureLabel.Location = new System.Drawing.Point(53, 86);
            bodyTemparatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bodyTemparatureLabel.Name = "bodyTemparatureLabel";
            bodyTemparatureLabel.Size = new System.Drawing.Size(111, 13);
            bodyTemparatureLabel.TabIndex = 7;
            bodyTemparatureLabel.Text = "body Temparature (F):";
            // 
            // finalDiagnoseLabel
            // 
            finalDiagnoseLabel.AutoSize = true;
            finalDiagnoseLabel.Location = new System.Drawing.Point(53, 311);
            finalDiagnoseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            finalDiagnoseLabel.Name = "finalDiagnoseLabel";
            finalDiagnoseLabel.Size = new System.Drawing.Size(77, 13);
            finalDiagnoseLabel.TabIndex = 9;
            finalDiagnoseLabel.Text = "final Diagnose:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(53, 131);
            heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(62, 13);
            heightLabel.TabIndex = 11;
            heightLabel.Text = "height (cm):";
            // 
            // initialDiagnoseLabel
            // 
            initialDiagnoseLabel.AutoSize = true;
            initialDiagnoseLabel.Location = new System.Drawing.Point(54, 260);
            initialDiagnoseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            initialDiagnoseLabel.Name = "initialDiagnoseLabel";
            initialDiagnoseLabel.Size = new System.Drawing.Size(81, 13);
            initialDiagnoseLabel.TabIndex = 15;
            initialDiagnoseLabel.Text = "initial Diagnose:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Location = new System.Drawing.Point(53, 176);
            nurseIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new System.Drawing.Size(36, 13);
            nurseIdLabel.TabIndex = 17;
            nurseIdLabel.Text = "nurse:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(53, 154);
            pulseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(35, 13);
            pulseLabel.TabIndex = 19;
            pulseLabel.Text = "pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(54, 213);
            symptomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(56, 13);
            symptomsLabel.TabIndex = 21;
            symptomsLabel.Text = "symptoms:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(53, 109);
            weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(58, 13);
            weightLabel.TabIndex = 23;
            weightLabel.Text = "weight (lb):";
            // 
            // bloodPressureDiastolicTextBox
            // 
            this.bloodPressureDiastolicTextBox.Location = new System.Drawing.Point(182, 38);
            this.bloodPressureDiastolicTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bloodPressureDiastolicTextBox.Name = "bloodPressureDiastolicTextBox";
            this.bloodPressureDiastolicTextBox.Size = new System.Drawing.Size(76, 20);
            this.bloodPressureDiastolicTextBox.TabIndex = 2;
            // 
            // bloodPressureSystolicTextBox
            // 
            this.bloodPressureSystolicTextBox.Location = new System.Drawing.Point(182, 61);
            this.bloodPressureSystolicTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bloodPressureSystolicTextBox.Name = "bloodPressureSystolicTextBox";
            this.bloodPressureSystolicTextBox.Size = new System.Drawing.Size(76, 20);
            this.bloodPressureSystolicTextBox.TabIndex = 3;
            // 
            // bodyTemparatureTextBox
            // 
            this.bodyTemparatureTextBox.Location = new System.Drawing.Point(182, 83);
            this.bodyTemparatureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bodyTemparatureTextBox.Name = "bodyTemparatureTextBox";
            this.bodyTemparatureTextBox.Size = new System.Drawing.Size(76, 20);
            this.bodyTemparatureTextBox.TabIndex = 4;
            // 
            // finalDiagnoseTextBox
            // 
            this.finalDiagnoseTextBox.Location = new System.Drawing.Point(182, 302);
            this.finalDiagnoseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finalDiagnoseTextBox.Multiline = true;
            this.finalDiagnoseTextBox.Name = "finalDiagnoseTextBox";
            this.finalDiagnoseTextBox.Size = new System.Drawing.Size(310, 42);
            this.finalDiagnoseTextBox.TabIndex = 11;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(182, 129);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(76, 20);
            this.heightTextBox.TabIndex = 6;
            // 
            // initialDiagnoseTextBox
            // 
            this.initialDiagnoseTextBox.Location = new System.Drawing.Point(182, 245);
            this.initialDiagnoseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.initialDiagnoseTextBox.Multiline = true;
            this.initialDiagnoseTextBox.Name = "initialDiagnoseTextBox";
            this.initialDiagnoseTextBox.Size = new System.Drawing.Size(310, 48);
            this.initialDiagnoseTextBox.TabIndex = 10;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Location = new System.Drawing.Point(182, 152);
            this.pulseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(76, 20);
            this.pulseTextBox.TabIndex = 7;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(181, 202);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(311, 40);
            this.symptomsTextBox.TabIndex = 9;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(182, 106);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(76, 20);
            this.weightTextBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(78, 409);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(56, 19);
            this.submitButton.TabIndex = 25;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(200, 409);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 19);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // appointment_idComboBox
            // 
            this.appointment_idComboBox.FormattingEnabled = true;
            this.appointment_idComboBox.Location = new System.Drawing.Point(182, 13);
            this.appointment_idComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointment_idComboBox.Name = "appointment_idComboBox";
            this.appointment_idComboBox.Size = new System.Drawing.Size(139, 21);
            this.appointment_idComboBox.TabIndex = 1;
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(94, 375);
            this.confirmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 13);
            this.confirmLabel.TabIndex = 29;
            // 
            // nurseComboBox
            // 
            this.nurseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nurseComboBox.FormattingEnabled = true;
            this.nurseComboBox.Location = new System.Drawing.Point(182, 174);
            this.nurseComboBox.Name = "nurseComboBox";
            this.nurseComboBox.Size = new System.Drawing.Size(139, 21);
            this.nurseComboBox.TabIndex = 8;
            // 
            // AddVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nurseComboBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.appointment_idComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(appointment_idLabel);
            this.Controls.Add(bloodPressureDiastolicLabel);
            this.Controls.Add(this.bloodPressureDiastolicTextBox);
            this.Controls.Add(bloodPressureSystolicLabel);
            this.Controls.Add(this.bloodPressureSystolicTextBox);
            this.Controls.Add(bodyTemparatureLabel);
            this.Controls.Add(this.bodyTemparatureTextBox);
            this.Controls.Add(finalDiagnoseLabel);
            this.Controls.Add(this.finalDiagnoseTextBox);
            this.Controls.Add(heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(initialDiagnoseLabel);
            this.Controls.Add(this.initialDiagnoseTextBox);
            this.Controls.Add(nurseIdLabel);
            this.Controls.Add(pulseLabel);
            this.Controls.Add(this.pulseTextBox);
            this.Controls.Add(symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddVisitUserControl";
            this.Size = new System.Drawing.Size(713, 504);
            this.Load += new System.EventHandler(this.AddVisitUserControl_Load);
            this.Enter += new System.EventHandler(this.AddVisitUserControl_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bloodPressureDiastolicTextBox;
        private System.Windows.Forms.TextBox bloodPressureSystolicTextBox;
        private System.Windows.Forms.TextBox bodyTemparatureTextBox;
        private System.Windows.Forms.TextBox finalDiagnoseTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox initialDiagnoseTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox appointment_idComboBox;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.ComboBox nurseComboBox;
    }
}
