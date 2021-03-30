
namespace Group3_ClinicDB.UserControls
{
    partial class UpdateVisitUserControl
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
            System.Windows.Forms.Label visitLabel;
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
            this.nurseIdTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.visitTextBox = new System.Windows.Forms.TextBox();
            this.getVisitButton = new System.Windows.Forms.Button();
            visitLabel = new System.Windows.Forms.Label();
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
            // visitLabel
            // 
            visitLabel.AutoSize = true;
            visitLabel.Location = new System.Drawing.Point(80, 89);
            visitLabel.Name = "visitLabel";
            visitLabel.Size = new System.Drawing.Size(55, 20);
            visitLabel.TabIndex = 1;
            visitLabel.Text = "visit id:";
            // 
            // bloodPressureDiastolicLabel
            // 
            bloodPressureDiastolicLabel.AutoSize = true;
            bloodPressureDiastolicLabel.Location = new System.Drawing.Point(80, 125);
            bloodPressureDiastolicLabel.Name = "bloodPressureDiastolicLabel";
            bloodPressureDiastolicLabel.Size = new System.Drawing.Size(183, 20);
            bloodPressureDiastolicLabel.TabIndex = 3;
            bloodPressureDiastolicLabel.Text = "blood Pressure Diastolic:";
            // 
            // bloodPressureSystolicLabel
            // 
            bloodPressureSystolicLabel.AutoSize = true;
            bloodPressureSystolicLabel.Location = new System.Drawing.Point(80, 160);
            bloodPressureSystolicLabel.Name = "bloodPressureSystolicLabel";
            bloodPressureSystolicLabel.Size = new System.Drawing.Size(177, 20);
            bloodPressureSystolicLabel.TabIndex = 5;
            bloodPressureSystolicLabel.Text = "blood Pressure Systolic:";
            // 
            // bodyTemparatureLabel
            // 
            bodyTemparatureLabel.AutoSize = true;
            bodyTemparatureLabel.Location = new System.Drawing.Point(80, 195);
            bodyTemparatureLabel.Name = "bodyTemparatureLabel";
            bodyTemparatureLabel.Size = new System.Drawing.Size(142, 20);
            bodyTemparatureLabel.TabIndex = 7;
            bodyTemparatureLabel.Text = "body Temparature:";
            // 
            // finalDiagnoseLabel
            // 
            finalDiagnoseLabel.AutoSize = true;
            finalDiagnoseLabel.Location = new System.Drawing.Point(80, 560);
            finalDiagnoseLabel.Name = "finalDiagnoseLabel";
            finalDiagnoseLabel.Size = new System.Drawing.Size(114, 20);
            finalDiagnoseLabel.TabIndex = 9;
            finalDiagnoseLabel.Text = "final Diagnose:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(80, 265);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(57, 20);
            heightLabel.TabIndex = 11;
            heightLabel.Text = "height:";
            // 
            // initialDiagnoseLabel
            // 
            initialDiagnoseLabel.AutoSize = true;
            initialDiagnoseLabel.Location = new System.Drawing.Point(80, 433);
            initialDiagnoseLabel.Name = "initialDiagnoseLabel";
            initialDiagnoseLabel.Size = new System.Drawing.Size(120, 20);
            initialDiagnoseLabel.TabIndex = 15;
            initialDiagnoseLabel.Text = "initial Diagnose:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Location = new System.Drawing.Point(80, 337);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new System.Drawing.Size(71, 20);
            nurseIdLabel.TabIndex = 17;
            nurseIdLabel.Text = "nurse Id:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(80, 300);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(51, 20);
            pulseLabel.TabIndex = 19;
            pulseLabel.Text = "pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(80, 372);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(85, 20);
            symptomsLabel.TabIndex = 21;
            symptomsLabel.Text = "symptoms:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(80, 231);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(59, 20);
            weightLabel.TabIndex = 23;
            weightLabel.Text = "weight:";
            // 
            // bloodPressureDiastolicTextBox
            // 
            this.bloodPressureDiastolicTextBox.Location = new System.Drawing.Point(273, 122);
            this.bloodPressureDiastolicTextBox.Name = "bloodPressureDiastolicTextBox";
            this.bloodPressureDiastolicTextBox.ReadOnly = true;
            this.bloodPressureDiastolicTextBox.Size = new System.Drawing.Size(112, 26);
            this.bloodPressureDiastolicTextBox.TabIndex = 4;
            // 
            // bloodPressureSystolicTextBox
            // 
            this.bloodPressureSystolicTextBox.Location = new System.Drawing.Point(273, 157);
            this.bloodPressureSystolicTextBox.Name = "bloodPressureSystolicTextBox";
            this.bloodPressureSystolicTextBox.ReadOnly = true;
            this.bloodPressureSystolicTextBox.Size = new System.Drawing.Size(112, 26);
            this.bloodPressureSystolicTextBox.TabIndex = 6;
            // 
            // bodyTemparatureTextBox
            // 
            this.bodyTemparatureTextBox.Location = new System.Drawing.Point(273, 191);
            this.bodyTemparatureTextBox.Name = "bodyTemparatureTextBox";
            this.bodyTemparatureTextBox.ReadOnly = true;
            this.bodyTemparatureTextBox.Size = new System.Drawing.Size(112, 26);
            this.bodyTemparatureTextBox.TabIndex = 8;
            // 
            // finalDiagnoseTextBox
            // 
            this.finalDiagnoseTextBox.Location = new System.Drawing.Point(273, 545);
            this.finalDiagnoseTextBox.Multiline = true;
            this.finalDiagnoseTextBox.Name = "finalDiagnoseTextBox";
            this.finalDiagnoseTextBox.Size = new System.Drawing.Size(463, 93);
            this.finalDiagnoseTextBox.TabIndex = 10;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(273, 262);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(112, 26);
            this.heightTextBox.TabIndex = 12;
            // 
            // initialDiagnoseTextBox
            // 
            this.initialDiagnoseTextBox.Location = new System.Drawing.Point(273, 430);
            this.initialDiagnoseTextBox.Multiline = true;
            this.initialDiagnoseTextBox.Name = "initialDiagnoseTextBox";
            this.initialDiagnoseTextBox.ReadOnly = true;
            this.initialDiagnoseTextBox.Size = new System.Drawing.Size(463, 107);
            this.initialDiagnoseTextBox.TabIndex = 16;
            // 
            // nurseIdTextBox
            // 
            this.nurseIdTextBox.Location = new System.Drawing.Point(273, 331);
            this.nurseIdTextBox.Name = "nurseIdTextBox";
            this.nurseIdTextBox.ReadOnly = true;
            this.nurseIdTextBox.Size = new System.Drawing.Size(112, 26);
            this.nurseIdTextBox.TabIndex = 18;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Location = new System.Drawing.Point(273, 297);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.ReadOnly = true;
            this.pulseTextBox.Size = new System.Drawing.Size(112, 26);
            this.pulseTextBox.TabIndex = 20;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(273, 369);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.ReadOnly = true;
            this.symptomsTextBox.Size = new System.Drawing.Size(463, 55);
            this.symptomsTextBox.TabIndex = 22;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(273, 226);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ReadOnly = true;
            this.weightTextBox.Size = new System.Drawing.Size(112, 26);
            this.weightTextBox.TabIndex = 24;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(117, 656);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 29);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(300, 656);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 29);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(141, 640);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 20);
            this.confirmLabel.TabIndex = 29;
            // 
            // visitTextBox
            // 
            this.visitTextBox.Location = new System.Drawing.Point(272, 83);
            this.visitTextBox.Name = "visitTextBox";
            this.visitTextBox.Size = new System.Drawing.Size(112, 26);
            this.visitTextBox.TabIndex = 30;
            // 
            // getVisitButton
            // 
            this.getVisitButton.Location = new System.Drawing.Point(451, 82);
            this.getVisitButton.Name = "getVisitButton";
            this.getVisitButton.Size = new System.Drawing.Size(84, 29);
            this.getVisitButton.TabIndex = 31;
            this.getVisitButton.Text = "Get";
            this.getVisitButton.UseVisualStyleBackColor = true;
            this.getVisitButton.Click += new System.EventHandler(this.GetVisitUserControl_Click);
            // 
            // UpdateVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getVisitButton);
            this.Controls.Add(this.visitTextBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(visitLabel);
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
            this.Controls.Add(this.nurseIdTextBox);
            this.Controls.Add(pulseLabel);
            this.Controls.Add(this.pulseTextBox);
            this.Controls.Add(symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Name = "UpdateVisitUserControl";
            this.Size = new System.Drawing.Size(836, 698);
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
        private System.Windows.Forms.TextBox nurseIdTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox visitTextBox;
        private System.Windows.Forms.Button getVisitButton;
    }
}
