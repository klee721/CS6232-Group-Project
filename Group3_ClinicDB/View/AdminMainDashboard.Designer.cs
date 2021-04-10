
namespace Group3_ClinicDB.View
{
    partial class AdminMainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.AddUserTab = new System.Windows.Forms.TabPage();
            this.EditUserTab = new System.Windows.Forms.TabPage();
            this.ReportingTab = new System.Windows.Forms.TabPage();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.AdminTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.AddUserTab);
            this.AdminTabControl.Controls.Add(this.EditUserTab);
            this.AdminTabControl.Controls.Add(this.ReportingTab);
            this.AdminTabControl.Location = new System.Drawing.Point(2, 91);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(1223, 641);
            this.AdminTabControl.TabIndex = 1;
            // 
            // AddUserTab
            // 
            this.AddUserTab.Location = new System.Drawing.Point(4, 22);
            this.AddUserTab.Name = "AddUserTab";
            this.AddUserTab.Size = new System.Drawing.Size(1215, 615);
            this.AddUserTab.TabIndex = 8;
            this.AddUserTab.Text = "Add User";
            this.AddUserTab.UseVisualStyleBackColor = true;
            // 
            // EditUserTab
            // 
            this.EditUserTab.Location = new System.Drawing.Point(4, 22);
            this.EditUserTab.Name = "EditUserTab";
            this.EditUserTab.Size = new System.Drawing.Size(1215, 615);
            this.EditUserTab.TabIndex = 9;
            this.EditUserTab.Text = "Edit User";
            this.EditUserTab.UseVisualStyleBackColor = true;
            // 
            // ReportingTab
            // 
            this.ReportingTab.Location = new System.Drawing.Point(4, 22);
            this.ReportingTab.Name = "ReportingTab";
            this.ReportingTab.Size = new System.Drawing.Size(1215, 615);
            this.ReportingTab.TabIndex = 10;
            this.ReportingTab.Text = "Reporting";
            this.ReportingTab.UseVisualStyleBackColor = true;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(1101, 32);
            this.UserNameLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.UserNameLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(120, 20);
            this.UserNameLabel.TabIndex = 22;
            this.UserNameLabel.Text = "USERNAME";
            // 
            // UserFullNameLabel
            // 
            this.UserFullNameLabel.AutoSize = true;
            this.UserFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFullNameLabel.Location = new System.Drawing.Point(1101, 6);
            this.UserFullNameLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.UserFullNameLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.UserFullNameLabel.Name = "UserFullNameLabel";
            this.UserFullNameLabel.Size = new System.Drawing.Size(120, 20);
            this.UserFullNameLabel.TabIndex = 21;
            this.UserFullNameLabel.Text = "EMPLOYEE NAME";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(1008, 6);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EmployeeNameLabel.TabIndex = 20;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(1171, 71);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(40, 13);
            this.LogoutLink.TabIndex = 19;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(1034, 35);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(61, 13);
            this.LoggedInAsLabel.TabIndex = 18;
            this.LoggedInAsLabel.Text = "Username: ";
            // 
            // AdminMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 733);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserFullNameLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.AdminTabControl);
            this.MaximumSize = new System.Drawing.Size(1239, 772);
            this.MinimumSize = new System.Drawing.Size(1239, 772);
            this.Name = "AdminMainDashboard";
            this.Text = "Admin Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.AdminTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage AddUserTab;
        private System.Windows.Forms.TabPage EditUserTab;
        private System.Windows.Forms.TabPage ReportingTab;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserFullNameLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label LoggedInAsLabel;
    }
}