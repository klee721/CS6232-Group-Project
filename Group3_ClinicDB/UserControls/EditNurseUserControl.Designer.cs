
namespace Group3_ClinicDB.UserControls
{
    partial class EditNurseUserControl
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
            this.ConfirmPassTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeactivateRadio = new System.Windows.Forms.RadioButton();
            this.ActiveRadio = new System.Windows.Forms.RadioButton();
            this.NurseIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchNurseButton = new System.Windows.Forms.Button();
            this.SetStatusButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmPassTextbox
            // 
            this.ConfirmPassTextbox.Location = new System.Drawing.Point(170, 355);
            this.ConfirmPassTextbox.Name = "ConfirmPassTextbox";
            this.ConfirmPassTextbox.PasswordChar = '*';
            this.ConfirmPassTextbox.Size = new System.Drawing.Size(279, 20);
            this.ConfirmPassTextbox.TabIndex = 30;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(36, 360);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(116, 15);
            this.ConfirmPassLabel.TabIndex = 29;
            this.ConfirmPassLabel.Text = "Confirm Password:  ";
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(39, 406);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(122, 32);
            this.EditUserButton.TabIndex = 28;
            this.EditUserButton.Text = "Edit User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // UserFullNameLabel
            // 
            this.UserFullNameLabel.AutoSize = true;
            this.UserFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFullNameLabel.Location = new System.Drawing.Point(133, 181);
            this.UserFullNameLabel.MaximumSize = new System.Drawing.Size(150, 20);
            this.UserFullNameLabel.MinimumSize = new System.Drawing.Size(150, 20);
            this.UserFullNameLabel.Name = "UserFullNameLabel";
            this.UserFullNameLabel.Size = new System.Drawing.Size(150, 20);
            this.UserFullNameLabel.TabIndex = 27;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(40, 181);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EmployeeNameLabel.TabIndex = 26;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(172, 293);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(279, 20);
            this.PasswordTextBox.TabIndex = 25;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(35, 293);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(92, 15);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "New Password:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(172, 231);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(279, 20);
            this.UserNameTextBox.TabIndex = 23;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(35, 231);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(95, 15);
            this.UserNameLabel.TabIndex = 22;
            this.UserNameLabel.Text = "Edit Username: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DeactivateRadio);
            this.panel1.Controls.Add(this.ActiveRadio);
            this.panel1.Location = new System.Drawing.Point(39, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 62);
            this.panel1.TabIndex = 31;
            // 
            // DeactivateRadio
            // 
            this.DeactivateRadio.AutoSize = true;
            this.DeactivateRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeactivateRadio.ForeColor = System.Drawing.Color.Red;
            this.DeactivateRadio.Location = new System.Drawing.Point(161, 22);
            this.DeactivateRadio.Name = "DeactivateRadio";
            this.DeactivateRadio.Size = new System.Drawing.Size(66, 19);
            this.DeactivateRadio.TabIndex = 1;
            this.DeactivateRadio.TabStop = true;
            this.DeactivateRadio.Text = "Inactive";
            this.DeactivateRadio.UseVisualStyleBackColor = true;
            // 
            // ActiveRadio
            // 
            this.ActiveRadio.AutoSize = true;
            this.ActiveRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveRadio.Location = new System.Drawing.Point(61, 22);
            this.ActiveRadio.Name = "ActiveRadio";
            this.ActiveRadio.Size = new System.Drawing.Size(56, 19);
            this.ActiveRadio.TabIndex = 0;
            this.ActiveRadio.TabStop = true;
            this.ActiveRadio.Text = "Active";
            this.ActiveRadio.UseVisualStyleBackColor = true;
            // 
            // NurseIDTextBox
            // 
            this.NurseIDTextBox.Location = new System.Drawing.Point(92, 27);
            this.NurseIDTextBox.Name = "NurseIDTextBox";
            this.NurseIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.NurseIDTextBox.TabIndex = 32;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(25, 33);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(61, 15);
            this.EmployeeIDLabel.TabIndex = 33;
            this.EmployeeIDLabel.Text = "Nurse ID: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchNurseButton);
            this.panel2.Controls.Add(this.NurseIDTextBox);
            this.panel2.Controls.Add(this.EmployeeIDLabel);
            this.panel2.Location = new System.Drawing.Point(38, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 140);
            this.panel2.TabIndex = 34;
            // 
            // SearchNurseButton
            // 
            this.SearchNurseButton.Location = new System.Drawing.Point(28, 85);
            this.SearchNurseButton.Name = "SearchNurseButton";
            this.SearchNurseButton.Size = new System.Drawing.Size(122, 32);
            this.SearchNurseButton.TabIndex = 35;
            this.SearchNurseButton.Text = "Search";
            this.SearchNurseButton.UseVisualStyleBackColor = true;
            this.SearchNurseButton.Click += new System.EventHandler(this.SearchNurseButton_Click);
            // 
            // SetStatusButton
            // 
            this.SetStatusButton.Location = new System.Drawing.Point(39, 562);
            this.SetStatusButton.Name = "SetStatusButton";
            this.SetStatusButton.Size = new System.Drawing.Size(122, 32);
            this.SetStatusButton.TabIndex = 35;
            this.SetStatusButton.Text = "Set Status";
            this.SetStatusButton.UseVisualStyleBackColor = true;
            this.SetStatusButton.Click += new System.EventHandler(this.SetStatusButton_Click);
            // 
            // EditNurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SetStatusButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmPassTextbox);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.UserFullNameLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "EditNurseUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConfirmPassTextbox;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Label UserFullNameLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton DeactivateRadio;
        private System.Windows.Forms.RadioButton ActiveRadio;
        private System.Windows.Forms.TextBox NurseIDTextBox;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchNurseButton;
        private System.Windows.Forms.Button SetStatusButton;
    }
}
