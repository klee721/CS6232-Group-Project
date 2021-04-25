﻿
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
            this.AddNurseTab = new System.Windows.Forms.TabPage();
            this.EditNurseTab = new System.Windows.Forms.TabPage();
            this.ReportingTab = new System.Windows.Forms.TabPage();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.addUserUserControl1 = new Group3_ClinicDB.UserControls.AddUserUserControl();
            this.editNurseUserControl1 = new Group3_ClinicDB.UserControls.EditNurseUserControl();
            this.getLabTestReportUserControl1 = new Group3_ClinicDB.UserControls.GetLabTestReportUserControl();
            this.addNurseUserControl1 = new Group3_ClinicDB.UserControls.AddNurseUserControl();
            this.AdminTabControl.SuspendLayout();
            this.AddUserTab.SuspendLayout();
            this.AddNurseTab.SuspendLayout();
            this.EditNurseTab.SuspendLayout();
            this.ReportingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.AddUserTab);
            this.AdminTabControl.Controls.Add(this.AddNurseTab);
            this.AdminTabControl.Controls.Add(this.EditNurseTab);
            this.AdminTabControl.Controls.Add(this.ReportingTab);
            this.AdminTabControl.Location = new System.Drawing.Point(-2, 87);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(1223, 641);
            this.AdminTabControl.TabIndex = 1;
            // 
            // AddUserTab
            // 
            this.AddUserTab.Controls.Add(this.addUserUserControl1);
            this.AddUserTab.Location = new System.Drawing.Point(4, 22);
            this.AddUserTab.Name = "AddUserTab";
            this.AddUserTab.Size = new System.Drawing.Size(1215, 615);
            this.AddUserTab.TabIndex = 8;
            this.AddUserTab.Text = "Add User";
            this.AddUserTab.UseVisualStyleBackColor = true;
            // 
            // AddNurseTab
            // 
            this.AddNurseTab.Controls.Add(this.addNurseUserControl1);
            this.AddNurseTab.Location = new System.Drawing.Point(4, 22);
            this.AddNurseTab.Name = "AddNurseTab";
            this.AddNurseTab.Size = new System.Drawing.Size(1215, 615);
            this.AddNurseTab.TabIndex = 11;
            this.AddNurseTab.Text = "AddNurse";
            this.AddNurseTab.UseVisualStyleBackColor = true;
            // 
            // EditNurseTab
            // 
            this.EditNurseTab.Controls.Add(this.editNurseUserControl1);
            this.EditNurseTab.Location = new System.Drawing.Point(4, 22);
            this.EditNurseTab.Name = "EditNurseTab";
            this.EditNurseTab.Size = new System.Drawing.Size(1215, 615);
            this.EditNurseTab.TabIndex = 9;
            this.EditNurseTab.Text = "Edit Nurse";
            this.EditNurseTab.UseVisualStyleBackColor = true;
            // 
            // ReportingTab
            // 
            this.ReportingTab.Controls.Add(this.getLabTestReportUserControl1);
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
            // addUserUserControl1
            // 
            this.addUserUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addUserUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.addUserUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.addUserUserControl1.Name = "addUserUserControl1";
            this.addUserUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.addUserUserControl1.TabIndex = 0;
            // 
            // editNurseUserControl1
            // 
            this.editNurseUserControl1.Location = new System.Drawing.Point(0, 0);
            this.editNurseUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.editNurseUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.editNurseUserControl1.Name = "editNurseUserControl1";
            this.editNurseUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.editNurseUserControl1.TabIndex = 0;
            // 
            // getLabTestReportUserControl1
            // 
            this.getLabTestReportUserControl1.Location = new System.Drawing.Point(0, 0);
            this.getLabTestReportUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.getLabTestReportUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.getLabTestReportUserControl1.Name = "getLabTestReportUserControl1";
            this.getLabTestReportUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.getLabTestReportUserControl1.TabIndex = 0;
            // 
            // addNurseUserControl1
            // 
            this.addNurseUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addNurseUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.addNurseUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.addNurseUserControl1.Name = "addNurseUserControl1";
            this.addNurseUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.addNurseUserControl1.TabIndex = 0;
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
            this.AddUserTab.ResumeLayout(false);
            this.AddNurseTab.ResumeLayout(false);
            this.EditNurseTab.ResumeLayout(false);
            this.ReportingTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage AddUserTab;
        private System.Windows.Forms.TabPage EditNurseTab;
        private System.Windows.Forms.TabPage ReportingTab;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserFullNameLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private UserControls.AddUserUserControl addUserUserControl1;
        private UserControls.EditNurseUserControl editNurseUserControl1;
        private UserControls.GetLabTestReportUserControl getLabTestReportUserControl1;
        private System.Windows.Forms.TabPage AddNurseTab;
        private UserControls.AddNurseUserControl addNurseUserControl1;
    }
}