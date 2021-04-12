
namespace Group3_ClinicDB.UserControls
{
    partial class OrderTestsUserControl
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
            this.testCodecomboBox = new System.Windows.Forms.ComboBox();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.submitLabTestButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.testDescritionLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testCodecomboBox
            // 
            this.testCodecomboBox.FormattingEnabled = true;
            this.testCodecomboBox.Location = new System.Drawing.Point(173, 169);
            this.testCodecomboBox.Name = "testCodecomboBox";
            this.testCodecomboBox.Size = new System.Drawing.Size(216, 21);
            this.testCodecomboBox.TabIndex = 1;
            this.testCodecomboBox.SelectedIndexChanged += new System.EventHandler(this.testCodecomboBox_SelectedIndexChanged);
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(179, 80);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(0, 13);
            this.testNameLabel.TabIndex = 2;
            // 
            // submitLabTestButton
            // 
            this.submitLabTestButton.Location = new System.Drawing.Point(173, 322);
            this.submitLabTestButton.Name = "submitLabTestButton";
            this.submitLabTestButton.Size = new System.Drawing.Size(75, 23);
            this.submitLabTestButton.TabIndex = 3;
            this.submitLabTestButton.Text = "Submit";
            this.submitLabTestButton.UseVisualStyleBackColor = true;
            this.submitLabTestButton.Click += new System.EventHandler(this.LabTestButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(323, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test Code";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(179, 235);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionLabel.TabIndex = 6;
            // 
            // testDescritionLabel
            // 
            this.testDescritionLabel.AutoSize = true;
            this.testDescritionLabel.Location = new System.Drawing.Point(180, 234);
            this.testDescritionLabel.Name = "testDescritionLabel";
            this.testDescritionLabel.Size = new System.Drawing.Size(0, 13);
            this.testDescritionLabel.TabIndex = 7;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(70, 234);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(86, 13);
            this.Description.TabIndex = 8;
            this.Description.Text = "DescriptionLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(93, 274);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 13);
            this.confirmLabel.TabIndex = 10;
            // 
            // OrderTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.testDescritionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitLabTestButton);
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.testCodecomboBox);
            this.Name = "OrderTestsUserControl";
            this.Size = new System.Drawing.Size(720, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox testCodecomboBox;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.Button submitLabTestButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label testDescritionLabel;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label confirmLabel;
    }
}
