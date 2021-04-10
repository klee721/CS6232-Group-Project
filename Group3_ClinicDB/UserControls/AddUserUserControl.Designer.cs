
namespace Group3_ClinicDB.UserControls
{
    partial class AddUserUserControl
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.FindEmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeRoleLabel = new System.Windows.Forms.Label();
            this.AdminRadio = new System.Windows.Forms.RadioButton();
            this.NurseRadio = new System.Windows.Forms.RadioButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.ConfirmPassTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(14, 381);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(71, 15);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Username: ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(151, 381);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(279, 20);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.EmployeeIDTextBox);
            this.panel1.Controls.Add(this.EmployeeIDLabel);
            this.panel1.Controls.Add(this.FindEmployeeLabel);
            this.panel1.Controls.Add(this.EmployeeRoleLabel);
            this.panel1.Controls.Add(this.AdminRadio);
            this.panel1.Controls.Add(this.NurseRadio);
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 291);
            this.panel1.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(20, 232);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(102, 161);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(82, 20);
            this.EmployeeIDTextBox.TabIndex = 5;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(15, 162);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(80, 15);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // FindEmployeeLabel
            // 
            this.FindEmployeeLabel.AutoSize = true;
            this.FindEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindEmployeeLabel.Location = new System.Drawing.Point(449, 12);
            this.FindEmployeeLabel.Name = "FindEmployeeLabel";
            this.FindEmployeeLabel.Size = new System.Drawing.Size(181, 20);
            this.FindEmployeeLabel.TabIndex = 3;
            this.FindEmployeeLabel.Text = "Search For Employee";
            // 
            // EmployeeRoleLabel
            // 
            this.EmployeeRoleLabel.AutoSize = true;
            this.EmployeeRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeRoleLabel.Location = new System.Drawing.Point(17, 82);
            this.EmployeeRoleLabel.Name = "EmployeeRoleLabel";
            this.EmployeeRoleLabel.Size = new System.Drawing.Size(94, 15);
            this.EmployeeRoleLabel.TabIndex = 2;
            this.EmployeeRoleLabel.Text = "Employee Role:";
            // 
            // AdminRadio
            // 
            this.AdminRadio.AutoSize = true;
            this.AdminRadio.Location = new System.Drawing.Point(200, 80);
            this.AdminRadio.Name = "AdminRadio";
            this.AdminRadio.Size = new System.Drawing.Size(85, 17);
            this.AdminRadio.TabIndex = 1;
            this.AdminRadio.TabStop = true;
            this.AdminRadio.Text = "Administrator";
            this.AdminRadio.UseVisualStyleBackColor = true;
            // 
            // NurseRadio
            // 
            this.NurseRadio.AutoSize = true;
            this.NurseRadio.Location = new System.Drawing.Point(131, 80);
            this.NurseRadio.Name = "NurseRadio";
            this.NurseRadio.Size = new System.Drawing.Size(53, 17);
            this.NurseRadio.TabIndex = 0;
            this.NurseRadio.TabStop = true;
            this.NurseRadio.Text = "Nurse";
            this.NurseRadio.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(151, 443);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(279, 20);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(14, 443);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserFullNameLabel
            // 
            this.UserFullNameLabel.AutoSize = true;
            this.UserFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFullNameLabel.Location = new System.Drawing.Point(108, 331);
            this.UserFullNameLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.UserFullNameLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.UserFullNameLabel.Name = "UserFullNameLabel";
            this.UserFullNameLabel.Size = new System.Drawing.Size(120, 20);
            this.UserFullNameLabel.TabIndex = 18;
            this.UserFullNameLabel.Text = "EMPLOYEE NAME";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(15, 331);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EmployeeNameLabel.TabIndex = 17;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(31, 554);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(122, 32);
            this.CreateUserButton.TabIndex = 19;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // ConfirmPassTextbox
            // 
            this.ConfirmPassTextbox.Location = new System.Drawing.Point(149, 505);
            this.ConfirmPassTextbox.Name = "ConfirmPassTextbox";
            this.ConfirmPassTextbox.PasswordChar = '*';
            this.ConfirmPassTextbox.Size = new System.Drawing.Size(279, 20);
            this.ConfirmPassTextbox.TabIndex = 21;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(15, 510);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(116, 15);
            this.ConfirmPassLabel.TabIndex = 20;
            this.ConfirmPassLabel.Text = "Confirm Password:  ";
            // 
            // AddUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmPassTextbox);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.UserFullNameLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "AddUserUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label FindEmployeeLabel;
        private System.Windows.Forms.Label EmployeeRoleLabel;
        private System.Windows.Forms.RadioButton AdminRadio;
        private System.Windows.Forms.RadioButton NurseRadio;
        private System.Windows.Forms.Label UserFullNameLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.TextBox ConfirmPassTextbox;
        private System.Windows.Forms.Label ConfirmPassLabel;
    }
}
