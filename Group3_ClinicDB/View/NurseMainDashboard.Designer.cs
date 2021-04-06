
namespace Group3_ClinicDB.View
{
    partial class NurseMainDashboard
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
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.registerPatientTab = new System.Windows.Forms.TabPage();
            this.registerPatientUserControl1 = new Group3_ClinicDB.UserControls.RegisterPatientUserControl();
            this.allPatientsTab = new System.Windows.Forms.TabPage();
            this.allPatientUserControl1 = new Group3_ClinicDB.UserControls.AllPatientUserControl();
            this.editPatientTab = new System.Windows.Forms.TabPage();
            this.editPatientUserControl1 = new Group3_ClinicDB.UserControls.EditPatientUserControl();
            this.ScheduleApptTab = new System.Windows.Forms.TabPage();
            this.appointmentBookingUserControl2 = new Group3_ClinicDB.UserControls.AppointmentBookingUserControl();
            this.EditApptTab = new System.Windows.Forms.TabPage();
            this.editAppointmentUserControl1 = new Group3_ClinicDB.UserControls.EditAppointmentUserControl();
            this.visitsTabPage = new System.Windows.Forms.TabPage();
            this.allVisitsUserControl1 = new Group3_ClinicDB.UserControls.AllVisitsUserControl();
            this.addVisitTabPage = new System.Windows.Forms.TabPage();
            this.addVisitUserControl1 = new Group3_ClinicDB.UserControls.AddVisitUserControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.updateVisitUserControl1 = new Group3_ClinicDB.UserControls.UpdateVisitUserControl();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.LoggedInTextBox = new System.Windows.Forms.TextBox();
            this.SelectedPatientLabel = new System.Windows.Forms.Label();
            this.SelectedPatientTextBox = new System.Windows.Forms.TextBox();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.SelectPatientButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchUserControl2 = new Group3_ClinicDB.UserControls.SearchUserControl();
            this.DashboardTabControl.SuspendLayout();
            this.registerPatientTab.SuspendLayout();
            this.allPatientsTab.SuspendLayout();
            this.editPatientTab.SuspendLayout();
            this.ScheduleApptTab.SuspendLayout();
            this.EditApptTab.SuspendLayout();
            this.visitsTabPage.SuspendLayout();
            this.addVisitTabPage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.Controls.Add(this.registerPatientTab);
            this.DashboardTabControl.Controls.Add(this.allPatientsTab);
            this.DashboardTabControl.Controls.Add(this.editPatientTab);
            this.DashboardTabControl.Controls.Add(this.ScheduleApptTab);
            this.DashboardTabControl.Controls.Add(this.EditApptTab);
            this.DashboardTabControl.Controls.Add(this.visitsTabPage);
            this.DashboardTabControl.Controls.Add(this.addVisitTabPage);
            this.DashboardTabControl.Controls.Add(this.tabPage6);
            this.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DashboardTabControl.Location = new System.Drawing.Point(0, 253);
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(1223, 641);
            this.DashboardTabControl.TabIndex = 0;
            // 
            // registerPatientTab
            // 
            this.registerPatientTab.Controls.Add(this.registerPatientUserControl1);
            this.registerPatientTab.Location = new System.Drawing.Point(4, 22);
            this.registerPatientTab.Name = "registerPatientTab";
            this.registerPatientTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerPatientTab.Size = new System.Drawing.Size(1215, 615);
            this.registerPatientTab.TabIndex = 0;
            this.registerPatientTab.Text = "Register Patient";
            this.registerPatientTab.UseVisualStyleBackColor = true;
            // 
            // registerPatientUserControl1
            // 
            this.registerPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPatientUserControl1.Location = new System.Drawing.Point(3, 3);
            this.registerPatientUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPatientUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.registerPatientUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.registerPatientUserControl1.Name = "registerPatientUserControl1";
            this.registerPatientUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.registerPatientUserControl1.TabIndex = 0;
            // 
            // allPatientsTab
            // 
            this.allPatientsTab.Controls.Add(this.allPatientUserControl1);
            this.allPatientsTab.Location = new System.Drawing.Point(4, 22);
            this.allPatientsTab.Name = "allPatientsTab";
            this.allPatientsTab.Size = new System.Drawing.Size(1215, 615);
            this.allPatientsTab.TabIndex = 6;
            this.allPatientsTab.Text = "Patients";
            this.allPatientsTab.UseVisualStyleBackColor = true;
            // 
            // allPatientUserControl1
            // 
            this.allPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allPatientUserControl1.Location = new System.Drawing.Point(0, 3);
            this.allPatientUserControl1.Name = "allPatientUserControl1";
            this.allPatientUserControl1.Size = new System.Drawing.Size(1215, 612);
            this.allPatientUserControl1.TabIndex = 0;
            // 
            // editPatientTab
            // 
            this.editPatientTab.Controls.Add(this.editPatientUserControl1);
            this.editPatientTab.Location = new System.Drawing.Point(4, 22);
            this.editPatientTab.Name = "editPatientTab";
            this.editPatientTab.Size = new System.Drawing.Size(1215, 615);
            this.editPatientTab.TabIndex = 7;
            this.editPatientTab.Text = "Edit Patient";
            this.editPatientTab.UseVisualStyleBackColor = true;
            // 
            // editPatientUserControl1
            // 
            this.editPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPatientUserControl1.Location = new System.Drawing.Point(0, 0);
            this.editPatientUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.editPatientUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.editPatientUserControl1.Name = "editPatientUserControl1";
            this.editPatientUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.editPatientUserControl1.TabIndex = 0;
            // 
            // ScheduleApptTab
            // 
            this.ScheduleApptTab.Controls.Add(this.appointmentBookingUserControl2);
            this.ScheduleApptTab.Location = new System.Drawing.Point(4, 22);
            this.ScheduleApptTab.Name = "ScheduleApptTab";
            this.ScheduleApptTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduleApptTab.Size = new System.Drawing.Size(1215, 615);
            this.ScheduleApptTab.TabIndex = 1;
            this.ScheduleApptTab.Text = "Schedule Appointment";
            this.ScheduleApptTab.UseVisualStyleBackColor = true;
            // 
            // appointmentBookingUserControl2
            // 
            this.appointmentBookingUserControl2.Enabled = false;
            this.appointmentBookingUserControl2.Location = new System.Drawing.Point(0, 0);
            this.appointmentBookingUserControl2.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentBookingUserControl2.MaximumSize = new System.Drawing.Size(1215, 615);
            this.appointmentBookingUserControl2.MinimumSize = new System.Drawing.Size(1215, 615);
            this.appointmentBookingUserControl2.Name = "appointmentBookingUserControl2";
            this.appointmentBookingUserControl2.Size = new System.Drawing.Size(1215, 615);
            this.appointmentBookingUserControl2.TabIndex = 0;
            // 
            // EditApptTab
            // 
            this.EditApptTab.Controls.Add(this.editAppointmentUserControl1);
            this.EditApptTab.Location = new System.Drawing.Point(4, 22);
            this.EditApptTab.Name = "EditApptTab";
            this.EditApptTab.Size = new System.Drawing.Size(1215, 615);
            this.EditApptTab.TabIndex = 2;
            this.EditApptTab.Text = "Edit Appointment";
            this.EditApptTab.UseVisualStyleBackColor = true;
            // 
            // editAppointmentUserControl1
            // 
            this.editAppointmentUserControl1.Enabled = false;
            this.editAppointmentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.editAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.editAppointmentUserControl1.MaximumSize = new System.Drawing.Size(1215, 615);
            this.editAppointmentUserControl1.MinimumSize = new System.Drawing.Size(1215, 615);
            this.editAppointmentUserControl1.Name = "editAppointmentUserControl1";
            this.editAppointmentUserControl1.Size = new System.Drawing.Size(1215, 615);
            this.editAppointmentUserControl1.TabIndex = 0;
            // 
            // visitsTabPage
            // 
            this.visitsTabPage.Controls.Add(this.allVisitsUserControl1);
            this.visitsTabPage.Location = new System.Drawing.Point(4, 22);
            this.visitsTabPage.Name = "visitsTabPage";
            this.visitsTabPage.Size = new System.Drawing.Size(1215, 615);
            this.visitsTabPage.TabIndex = 3;
            this.visitsTabPage.Text = "Visits";
            this.visitsTabPage.UseVisualStyleBackColor = true;
            // 
            // allVisitsUserControl1
            // 
            this.allVisitsUserControl1.Enabled = false;
            this.allVisitsUserControl1.Location = new System.Drawing.Point(18, 24);
            this.allVisitsUserControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.allVisitsUserControl1.Name = "allVisitsUserControl1";
            this.allVisitsUserControl1.Size = new System.Drawing.Size(643, 291);
            this.allVisitsUserControl1.TabIndex = 0;
            // 
            // addVisitTabPage
            // 
            this.addVisitTabPage.Controls.Add(this.addVisitUserControl1);
            this.addVisitTabPage.Location = new System.Drawing.Point(4, 22);
            this.addVisitTabPage.Name = "addVisitTabPage";
            this.addVisitTabPage.Size = new System.Drawing.Size(1215, 615);
            this.addVisitTabPage.TabIndex = 4;
            this.addVisitTabPage.Text = "Add Visit";
            this.addVisitTabPage.UseVisualStyleBackColor = true;
            // 
            // addVisitUserControl1
            // 
            this.addVisitUserControl1.Enabled = false;
            this.addVisitUserControl1.Location = new System.Drawing.Point(54, 15);
            this.addVisitUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.addVisitUserControl1.Name = "addVisitUserControl1";
            this.addVisitUserControl1.Size = new System.Drawing.Size(694, 482);
            this.addVisitUserControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.updateVisitUserControl1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1215, 615);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Edit Visit";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // updateVisitUserControl1
            // 
            this.updateVisitUserControl1.Enabled = false;
            this.updateVisitUserControl1.Location = new System.Drawing.Point(30, 62);
            this.updateVisitUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.updateVisitUserControl1.Name = "updateVisitUserControl1";
            this.updateVisitUserControl1.Size = new System.Drawing.Size(496, 471);
            this.updateVisitUserControl1.TabIndex = 0;
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(1025, 49);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(61, 13);
            this.LoggedInAsLabel.TabIndex = 3;
            this.LoggedInAsLabel.Text = "Username: ";
            // 
            // LoggedInTextBox
            // 
            this.LoggedInTextBox.Location = new System.Drawing.Point(1092, 42);
            this.LoggedInTextBox.Name = "LoggedInTextBox";
            this.LoggedInTextBox.ReadOnly = true;
            this.LoggedInTextBox.Size = new System.Drawing.Size(119, 20);
            this.LoggedInTextBox.TabIndex = 4;
            this.LoggedInTextBox.Text = "USERNAME";
            // 
            // SelectedPatientLabel
            // 
            this.SelectedPatientLabel.AutoSize = true;
            this.SelectedPatientLabel.Location = new System.Drawing.Point(1040, 75);
            this.SelectedPatientLabel.Name = "SelectedPatientLabel";
            this.SelectedPatientLabel.Size = new System.Drawing.Size(46, 13);
            this.SelectedPatientLabel.TabIndex = 5;
            this.SelectedPatientLabel.Text = "Patient: ";
            // 
            // SelectedPatientTextBox
            // 
            this.SelectedPatientTextBox.Location = new System.Drawing.Point(1092, 68);
            this.SelectedPatientTextBox.Name = "SelectedPatientTextBox";
            this.SelectedPatientTextBox.ReadOnly = true;
            this.SelectedPatientTextBox.Size = new System.Drawing.Size(119, 20);
            this.SelectedPatientTextBox.TabIndex = 6;
            this.SelectedPatientTextBox.Text = "PATIENT ID";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(1171, 101);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(40, 13);
            this.LogoutLink.TabIndex = 7;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.Click += new System.EventHandler(this.LogoutLink_Click);
            // 
            // SelectPatientButton
            // 
            this.SelectPatientButton.Location = new System.Drawing.Point(782, 215);
            this.SelectPatientButton.Name = "SelectPatientButton";
            this.SelectPatientButton.Size = new System.Drawing.Size(203, 54);
            this.SelectPatientButton.TabIndex = 9;
            this.SelectPatientButton.Text = "Select Patient";
            this.SelectPatientButton.UseVisualStyleBackColor = true;
            this.SelectPatientButton.Click += new System.EventHandler(this.SelectPatientButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1092, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(999, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employee Name:";
            // 
            // searchUserControl2
            // 
            this.searchUserControl2.Location = new System.Drawing.Point(0, 0);
            this.searchUserControl2.Name = "searchUserControl2";
            this.searchUserControl2.Size = new System.Drawing.Size(1025, 209);
            this.searchUserControl2.TabIndex = 8;
            // 
            // NurseMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 894);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectPatientButton);
            this.Controls.Add(this.searchUserControl2);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.SelectedPatientTextBox);
            this.Controls.Add(this.SelectedPatientLabel);
            this.Controls.Add(this.LoggedInTextBox);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.DashboardTabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1239, 933);
            this.MinimumSize = new System.Drawing.Size(1239, 933);
            this.Name = "NurseMainDashboard";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.DashboardTabControl.ResumeLayout(false);
            this.registerPatientTab.ResumeLayout(false);
            this.allPatientsTab.ResumeLayout(false);
            this.editPatientTab.ResumeLayout(false);
            this.ScheduleApptTab.ResumeLayout(false);
            this.EditApptTab.ResumeLayout(false);
            this.visitsTabPage.ResumeLayout(false);
            this.addVisitTabPage.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DashboardTabControl;
        private System.Windows.Forms.TabPage registerPatientTab;
        private System.Windows.Forms.TabPage ScheduleApptTab;
        private System.Windows.Forms.TabPage EditApptTab;
        private System.Windows.Forms.TabPage visitsTabPage;
        private System.Windows.Forms.TabPage addVisitTabPage;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage allPatientsTab;
        private UserControls.AppointmentBookingUserControl appointmentBookingUserControl2;
        private UserControls.EditAppointmentUserControl editAppointmentUserControl1;
        private UserControls.AllVisitsUserControl allVisitsUserControl1;
        private UserControls.AddVisitUserControl addVisitUserControl1;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.TextBox LoggedInTextBox;
        private System.Windows.Forms.Label SelectedPatientLabel;
        private System.Windows.Forms.TextBox SelectedPatientTextBox;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private UserControls.RegisterPatientUserControl registerPatientUserControl1;
        private UserControls.UpdateVisitUserControl updateVisitUserControl1;
        private UserControls.AllPatientUserControl allPatientUserControl1;
        private System.Windows.Forms.TabPage editPatientTab;
        private UserControls.SearchUserControl searchUserControl2;
        private System.Windows.Forms.Button SelectPatientButton;
        private UserControls.EditPatientUserControl editPatientUserControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}