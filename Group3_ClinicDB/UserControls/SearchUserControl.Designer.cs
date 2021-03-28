
namespace Group3_ClinicDB.UserControls
{
    partial class SearchUserControl
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
            this.dobSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.namesSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLastNameSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dobSearchRadioButton
            // 
            this.dobSearchRadioButton.AutoSize = true;
            this.dobSearchRadioButton.Location = new System.Drawing.Point(105, 26);
            this.dobSearchRadioButton.Name = "dobSearchRadioButton";
            this.dobSearchRadioButton.Size = new System.Drawing.Size(102, 17);
            this.dobSearchRadioButton.TabIndex = 0;
            this.dobSearchRadioButton.TabStop = true;
            this.dobSearchRadioButton.Text = "Search by DOB:";
            this.dobSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search  Criteria:";
            // 
            // namesSearchRadioButton
            // 
            this.namesSearchRadioButton.AutoSize = true;
            this.namesSearchRadioButton.Location = new System.Drawing.Point(350, 26);
            this.namesSearchRadioButton.Name = "namesSearchRadioButton";
            this.namesSearchRadioButton.Size = new System.Drawing.Size(173, 17);
            this.namesSearchRadioButton.TabIndex = 2;
            this.namesSearchRadioButton.TabStop = true;
            this.namesSearchRadioButton.Text = "Search by First and Last Name:";
            this.namesSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // dobLastNameSearchRadioButton
            // 
            this.dobLastNameSearchRadioButton.AutoSize = true;
            this.dobLastNameSearchRadioButton.Location = new System.Drawing.Point(679, 26);
            this.dobLastNameSearchRadioButton.Name = "dobLastNameSearchRadioButton";
            this.dobLastNameSearchRadioButton.Size = new System.Drawing.Size(177, 17);
            this.dobLastNameSearchRadioButton.TabIndex = 3;
            this.dobLastNameSearchRadioButton.TabStop = true;
            this.dobLastNameSearchRadioButton.Text = "Search by DOB and Last Name:";
            this.dobLastNameSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dobLastNameSearchRadioButton);
            this.Controls.Add(this.namesSearchRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dobSearchRadioButton);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(1025, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dobSearchRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton namesSearchRadioButton;
        private System.Windows.Forms.RadioButton dobLastNameSearchRadioButton;
    }
}
