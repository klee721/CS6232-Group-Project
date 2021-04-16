﻿
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
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.labTestsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.labTestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // testCodecomboBox
            // 
            this.testCodecomboBox.FormattingEnabled = true;
            this.testCodecomboBox.Location = new System.Drawing.Point(260, 94);
            this.testCodecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testCodecomboBox.Name = "testCodecomboBox";
            this.testCodecomboBox.Size = new System.Drawing.Size(322, 28);
            this.testCodecomboBox.TabIndex = 1;
            this.testCodecomboBox.SelectedIndexChanged += new System.EventHandler(this.testCodecomboBox_SelectedIndexChanged);
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(270, 35);
            this.testNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(0, 20);
            this.testNameLabel.TabIndex = 2;
            // 
            // submitLabTestButton
            // 
            this.submitLabTestButton.Location = new System.Drawing.Point(260, 300);
            this.submitLabTestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitLabTestButton.Name = "submitLabTestButton";
            this.submitLabTestButton.Size = new System.Drawing.Size(112, 35);
            this.submitLabTestButton.TabIndex = 3;
            this.submitLabTestButton.Text = "Submit";
            this.submitLabTestButton.UseVisualStyleBackColor = true;
            this.submitLabTestButton.Click += new System.EventHandler(this.LabTestButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(484, 300);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test Code";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(270, 171);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 20);
            this.descriptionLabel.TabIndex = 6;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(105, 171);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(128, 20);
            this.Description.TabIndex = 8;
            this.Description.Text = "DescriptionLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(233, 240);
            this.confirmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 20);
            this.confirmLabel.TabIndex = 10;
            // 
            // labTestsDataGridView
            // 
            this.labTestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestsDataGridView.Location = new System.Drawing.Point(25, 387);
            this.labTestsDataGridView.Name = "labTestsDataGridView";
            this.labTestsDataGridView.RowHeadersWidth = 62;
            this.labTestsDataGridView.RowTemplate.Height = 28;
            this.labTestsDataGridView.Size = new System.Drawing.Size(870, 250);
            this.labTestsDataGridView.TabIndex = 11;
            // 
            // OrderTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labTestsDataGridView);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitLabTestButton);
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.testCodecomboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderTestsUserControl";
            this.Size = new System.Drawing.Size(953, 678);
            ((System.ComponentModel.ISupportInitialize)(this.labTestsDataGridView)).EndInit();
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
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.DataGridView labTestsDataGridView;
    }
}