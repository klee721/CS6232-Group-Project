
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
            this.SearchPatientTab = new System.Windows.Forms.TabPage();
            this.SelectPatientButton = new System.Windows.Forms.Button();
            this.searchUserControl2 = new Group3_ClinicDB.UserControls.SearchUserControl();
            this.registerPatientTab = new System.Windows.Forms.TabPage();
            this.registerPatientUserControl1 = new Group3_ClinicDB.UserControls.RegisterPatientUserControl();
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
            this.EditVisitTab = new System.Windows.Forms.TabPage();
            this.updateVisitUserControl1 = new Group3_ClinicDB.UserControls.UpdateVisitUserControl();
            this.OrderTestTab = new System.Windows.Forms.TabPage();
            this.orderTestsUserControl1 = new Group3_ClinicDB.UserControls.OrderTestsUserControl();
            this.enterTestResultsTab = new System.Windows.Forms.TabPage();
            this.enterTestResultsUserControl1 = new Group3_ClinicDB.UserControls.EnterTestResultsUserControl();
            this.searchTestResults = new System.Windows.Forms.TabPage();
            this.searchTestResultsUserControl1 = new Group3_ClinicDB.UserControls.SearchTestResultsUserControl();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.SelectedPatientIDLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.SelectedPatientNameLabel = new System.Windows.Forms.Label();
            this.PatientIDLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteSuccessMessage = new System.Windows.Forms.Label();
            this.DashboardTabControl.SuspendLayout();
            this.SearchPatientTab.SuspendLayout();
            this.registerPatientTab.SuspendLayout();
            this.editPatientTab.SuspendLayout();
            this.ScheduleApptTab.SuspendLayout();
            this.EditApptTab.SuspendLayout();
            this.visitsTabPage.SuspendLayout();
            this.addVisitTabPage.SuspendLayout();
            this.EditVisitTab.SuspendLayout();
            this.OrderTestTab.SuspendLayout();
            this.enterTestResultsTab.SuspendLayout();
            this.searchTestResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.Controls.Add(this.SearchPatientTab);
            this.DashboardTabControl.Controls.Add(this.registerPatientTab);
            this.DashboardTabControl.Controls.Add(this.editPatientTab);
            this.DashboardTabControl.Controls.Add(this.ScheduleApptTab);
            this.DashboardTabControl.Controls.Add(this.EditApptTab);
            this.DashboardTabControl.Controls.Add(this.visitsTabPage);
            this.DashboardTabControl.Controls.Add(this.addVisitTabPage);
            this.DashboardTabControl.Controls.Add(this.EditVisitTab);
            this.DashboardTabControl.Controls.Add(this.OrderTestTab);
            this.DashboardTabControl.Controls.Add(this.enterTestResultsTab);
            this.DashboardTabControl.Controls.Add(this.searchTestResults);
            this.DashboardTabControl.Location = new System.Drawing.Point(3, 138);
            this.DashboardTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(1834, 986);
            this.DashboardTabControl.TabIndex = 0;
            this.DashboardTabControl.Click += new System.EventHandler(this.DashboardTabControlClick);
            // 
            // SearchPatientTab
            // 
            this.SearchPatientTab.Controls.Add(this.SelectPatientButton);
            this.SearchPatientTab.Controls.Add(this.searchUserControl2);
            this.SearchPatientTab.Location = new System.Drawing.Point(4, 29);
            this.SearchPatientTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchPatientTab.Name = "SearchPatientTab";
            this.SearchPatientTab.Size = new System.Drawing.Size(1826, 953);
            this.SearchPatientTab.TabIndex = 8;
            this.SearchPatientTab.Text = "Search Patients";
            this.SearchPatientTab.UseVisualStyleBackColor = true;
            // 
            // SelectPatientButton
            // 
            this.SelectPatientButton.Location = new System.Drawing.Point(1210, 854);
            this.SelectPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectPatientButton.Name = "SelectPatientButton";
            this.SelectPatientButton.Size = new System.Drawing.Size(304, 83);
            this.SelectPatientButton.TabIndex = 9;
            this.SelectPatientButton.Text = "Select Patient";
            this.SelectPatientButton.UseVisualStyleBackColor = true;
            this.SelectPatientButton.Click += new System.EventHandler(this.SelectPatientButtonClick);
            // 
            // searchUserControl2
            // 
            this.searchUserControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchUserControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserControl2.Location = new System.Drawing.Point(0, 0);
            this.searchUserControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchUserControl2.Name = "searchUserControl2";
            this.searchUserControl2.Size = new System.Drawing.Size(1826, 1145);
            this.searchUserControl2.TabIndex = 8;
            // 
            // registerPatientTab
            // 
            this.registerPatientTab.Controls.Add(this.registerPatientUserControl1);
            this.registerPatientTab.Location = new System.Drawing.Point(4, 29);
            this.registerPatientTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPatientTab.Name = "registerPatientTab";
            this.registerPatientTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPatientTab.Size = new System.Drawing.Size(1826, 953);
            this.registerPatientTab.TabIndex = 0;
            this.registerPatientTab.Text = "Register Patient";
            this.registerPatientTab.UseVisualStyleBackColor = true;
            // 
            // registerPatientUserControl1
            // 
            this.registerPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPatientUserControl1.Location = new System.Drawing.Point(4, 5);
            this.registerPatientUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.registerPatientUserControl1.MaximumSize = new System.Drawing.Size(1822, 946);
            this.registerPatientUserControl1.MinimumSize = new System.Drawing.Size(1822, 946);
            this.registerPatientUserControl1.Name = "registerPatientUserControl1";
            this.registerPatientUserControl1.Size = new System.Drawing.Size(1822, 946);
            this.registerPatientUserControl1.TabIndex = 0;
            // 
            // editPatientTab
            // 
            this.editPatientTab.Controls.Add(this.editPatientUserControl1);
            this.editPatientTab.Location = new System.Drawing.Point(4, 29);
            this.editPatientTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editPatientTab.Name = "editPatientTab";
            this.editPatientTab.Size = new System.Drawing.Size(1826, 953);
            this.editPatientTab.TabIndex = 7;
            this.editPatientTab.Text = "Edit Patient";
            this.editPatientTab.UseVisualStyleBackColor = true;
            // 
            // editPatientUserControl1
            // 
            this.editPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPatientUserControl1.Location = new System.Drawing.Point(0, 0);
            this.editPatientUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.editPatientUserControl1.MaximumSize = new System.Drawing.Size(1822, 946);
            this.editPatientUserControl1.MinimumSize = new System.Drawing.Size(1822, 946);
            this.editPatientUserControl1.Name = "editPatientUserControl1";
            this.editPatientUserControl1.Size = new System.Drawing.Size(1822, 946);
            this.editPatientUserControl1.TabIndex = 0;
            // 
            // ScheduleApptTab
            // 
            this.ScheduleApptTab.Controls.Add(this.appointmentBookingUserControl2);
            this.ScheduleApptTab.Location = new System.Drawing.Point(4, 29);
            this.ScheduleApptTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleApptTab.Name = "ScheduleApptTab";
            this.ScheduleApptTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleApptTab.Size = new System.Drawing.Size(1826, 953);
            this.ScheduleApptTab.TabIndex = 1;
            this.ScheduleApptTab.Text = "Schedule Appointment";
            this.ScheduleApptTab.UseVisualStyleBackColor = true;
            // 
            // appointmentBookingUserControl2
            // 
            this.appointmentBookingUserControl2.Enabled = false;
            this.appointmentBookingUserControl2.Location = new System.Drawing.Point(0, 0);
            this.appointmentBookingUserControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.appointmentBookingUserControl2.MaximumSize = new System.Drawing.Size(1822, 946);
            this.appointmentBookingUserControl2.MinimumSize = new System.Drawing.Size(1822, 946);
            this.appointmentBookingUserControl2.Name = "appointmentBookingUserControl2";
            this.appointmentBookingUserControl2.Size = new System.Drawing.Size(1822, 946);
            this.appointmentBookingUserControl2.TabIndex = 0;
            // 
            // EditApptTab
            // 
            this.EditApptTab.Controls.Add(this.editAppointmentUserControl1);
            this.EditApptTab.Location = new System.Drawing.Point(4, 29);
            this.EditApptTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditApptTab.Name = "EditApptTab";
            this.EditApptTab.Size = new System.Drawing.Size(1826, 953);
            this.EditApptTab.TabIndex = 2;
            this.EditApptTab.Text = "Edit Appointment";
            this.EditApptTab.UseVisualStyleBackColor = true;
            // 
            // editAppointmentUserControl1
            // 
            this.editAppointmentUserControl1.Enabled = false;
            this.editAppointmentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.editAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editAppointmentUserControl1.MaximumSize = new System.Drawing.Size(1822, 946);
            this.editAppointmentUserControl1.MinimumSize = new System.Drawing.Size(1822, 946);
            this.editAppointmentUserControl1.Name = "editAppointmentUserControl1";
            this.editAppointmentUserControl1.Size = new System.Drawing.Size(1822, 946);
            this.editAppointmentUserControl1.TabIndex = 0;
            // 
            // visitsTabPage
            // 
            this.visitsTabPage.Controls.Add(this.allVisitsUserControl1);
            this.visitsTabPage.Location = new System.Drawing.Point(4, 29);
            this.visitsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitsTabPage.Name = "visitsTabPage";
            this.visitsTabPage.Size = new System.Drawing.Size(1826, 953);
            this.visitsTabPage.TabIndex = 3;
            this.visitsTabPage.Text = "Visits";
            this.visitsTabPage.UseVisualStyleBackColor = true;
            // 
            // allVisitsUserControl1
            // 
            this.allVisitsUserControl1.Enabled = false;
            this.allVisitsUserControl1.Location = new System.Drawing.Point(27, 37);
            this.allVisitsUserControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.allVisitsUserControl1.Name = "allVisitsUserControl1";
            this.allVisitsUserControl1.Size = new System.Drawing.Size(964, 448);
            this.allVisitsUserControl1.TabIndex = 0;
            // 
            // addVisitTabPage
            // 
            this.addVisitTabPage.Controls.Add(this.addVisitUserControl1);
            this.addVisitTabPage.Location = new System.Drawing.Point(4, 29);
            this.addVisitTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addVisitTabPage.Name = "addVisitTabPage";
            this.addVisitTabPage.Size = new System.Drawing.Size(1826, 953);
            this.addVisitTabPage.TabIndex = 4;
            this.addVisitTabPage.Text = "Add Visit";
            this.addVisitTabPage.UseVisualStyleBackColor = true;
            // 
            // addVisitUserControl1
            // 
            this.addVisitUserControl1.Enabled = false;
            this.addVisitUserControl1.Location = new System.Drawing.Point(81, 23);
            this.addVisitUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addVisitUserControl1.Name = "addVisitUserControl1";
            this.addVisitUserControl1.Size = new System.Drawing.Size(1041, 742);
            this.addVisitUserControl1.TabIndex = 0;
            // 
            // EditVisitTab
            // 
            this.EditVisitTab.Controls.Add(this.updateVisitUserControl1);
            this.EditVisitTab.Location = new System.Drawing.Point(4, 29);
            this.EditVisitTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditVisitTab.Name = "EditVisitTab";
            this.EditVisitTab.Size = new System.Drawing.Size(1826, 953);
            this.EditVisitTab.TabIndex = 5;
            this.EditVisitTab.Text = "Edit Visit";
            this.EditVisitTab.UseVisualStyleBackColor = true;
            // 
            // updateVisitUserControl1
            // 
            this.updateVisitUserControl1.Enabled = false;
            this.updateVisitUserControl1.Location = new System.Drawing.Point(45, 95);
            this.updateVisitUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateVisitUserControl1.Name = "updateVisitUserControl1";
            this.updateVisitUserControl1.Size = new System.Drawing.Size(744, 725);
            this.updateVisitUserControl1.TabIndex = 0;
            // 
            // OrderTestTab
            // 
            this.OrderTestTab.Controls.Add(this.orderTestsUserControl1);
            this.OrderTestTab.Location = new System.Drawing.Point(4, 29);
            this.OrderTestTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderTestTab.Name = "OrderTestTab";
            this.OrderTestTab.Size = new System.Drawing.Size(1826, 953);
            this.OrderTestTab.TabIndex = 9;
            this.OrderTestTab.Text = "Order Tests";
            this.OrderTestTab.UseVisualStyleBackColor = true;
            // 
            // orderTestsUserControl1
            // 
            this.orderTestsUserControl1.Enabled = false;
            this.orderTestsUserControl1.Location = new System.Drawing.Point(30, 52);
            this.orderTestsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.orderTestsUserControl1.Name = "orderTestsUserControl1";
            this.orderTestsUserControl1.Size = new System.Drawing.Size(1075, 740);
            this.orderTestsUserControl1.TabIndex = 0;
            // 
            // enterTestResultsTab
            // 
            this.enterTestResultsTab.Controls.Add(this.enterTestResultsUserControl1);
            this.enterTestResultsTab.Location = new System.Drawing.Point(4, 29);
            this.enterTestResultsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterTestResultsTab.Name = "enterTestResultsTab";
            this.enterTestResultsTab.Size = new System.Drawing.Size(1826, 953);
            this.enterTestResultsTab.TabIndex = 10;
            this.enterTestResultsTab.Text = "Enter Test Results";
            this.enterTestResultsTab.UseVisualStyleBackColor = true;
            // 
            // enterTestResultsUserControl1
            // 
            this.enterTestResultsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterTestResultsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.enterTestResultsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.enterTestResultsUserControl1.MaximumSize = new System.Drawing.Size(1822, 946);
            this.enterTestResultsUserControl1.MinimumSize = new System.Drawing.Size(1822, 946);
            this.enterTestResultsUserControl1.Name = "enterTestResultsUserControl1";
            this.enterTestResultsUserControl1.Size = new System.Drawing.Size(1822, 946);
            this.enterTestResultsUserControl1.TabIndex = 0;
            // 
            // searchTestResults
            // 
            this.searchTestResults.Controls.Add(this.searchTestResultsUserControl1);
            this.searchTestResults.Location = new System.Drawing.Point(4, 29);
            this.searchTestResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTestResults.Name = "searchTestResults";
            this.searchTestResults.Size = new System.Drawing.Size(1826, 953);
            this.searchTestResults.TabIndex = 11;
            this.searchTestResults.Text = "Search Test Results";
            this.searchTestResults.UseVisualStyleBackColor = true;
            // 
            // searchTestResultsUserControl1
            // 
            this.searchTestResultsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTestResultsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.searchTestResultsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.searchTestResultsUserControl1.MaximumSize = new System.Drawing.Size(1822, 946);
            this.searchTestResultsUserControl1.MinimumSize = new System.Drawing.Size(1822, 946);
            this.searchTestResultsUserControl1.Name = "searchTestResultsUserControl1";
            this.searchTestResultsUserControl1.Size = new System.Drawing.Size(1822, 946);
            this.searchTestResultsUserControl1.TabIndex = 0;
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(1551, 58);
            this.LoggedInAsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(91, 20);
            this.LoggedInAsLabel.TabIndex = 3;
            this.LoggedInAsLabel.Text = "Username: ";
            // 
            // SelectedPatientIDLabel
            // 
            this.SelectedPatientIDLabel.AutoSize = true;
            this.SelectedPatientIDLabel.Location = new System.Drawing.Point(1215, 18);
            this.SelectedPatientIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedPatientIDLabel.Name = "SelectedPatientIDLabel";
            this.SelectedPatientIDLabel.Size = new System.Drawing.Size(92, 20);
            this.SelectedPatientIDLabel.TabIndex = 5;
            this.SelectedPatientIDLabel.Text = "Patient ID:  ";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(1756, 114);
            this.LogoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(59, 20);
            this.LogoutLink.TabIndex = 7;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.Click += new System.EventHandler(this.LogoutLinkClick);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(1512, 14);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(129, 20);
            this.EmployeeNameLabel.TabIndex = 10;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // SelectedPatientNameLabel
            // 
            this.SelectedPatientNameLabel.AutoSize = true;
            this.SelectedPatientNameLabel.Location = new System.Drawing.Point(1196, 58);
            this.SelectedPatientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedPatientNameLabel.Name = "SelectedPatientNameLabel";
            this.SelectedPatientNameLabel.Size = new System.Drawing.Size(117, 20);
            this.SelectedPatientNameLabel.TabIndex = 12;
            this.SelectedPatientNameLabel.Text = "Patient Name:  ";
            // 
            // PatientIDLabel
            // 
            this.PatientIDLabel.AutoSize = true;
            this.PatientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDLabel.Location = new System.Drawing.Point(1320, 14);
            this.PatientIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientIDLabel.MaximumSize = new System.Drawing.Size(180, 31);
            this.PatientIDLabel.MinimumSize = new System.Drawing.Size(180, 31);
            this.PatientIDLabel.Name = "PatientIDLabel";
            this.PatientIDLabel.Size = new System.Drawing.Size(180, 31);
            this.PatientIDLabel.TabIndex = 14;
            this.PatientIDLabel.Text = "PATIENT ID #";
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(1320, 54);
            this.PatientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLabel.MaximumSize = new System.Drawing.Size(180, 31);
            this.PatientNameLabel.MinimumSize = new System.Drawing.Size(180, 31);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(180, 31);
            this.PatientNameLabel.TabIndex = 15;
            this.PatientNameLabel.Text = "PATIENT NAME";
            // 
            // UserFullNameLabel
            // 
            this.UserFullNameLabel.AutoSize = true;
            this.UserFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFullNameLabel.Location = new System.Drawing.Point(1652, 14);
            this.UserFullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserFullNameLabel.MaximumSize = new System.Drawing.Size(180, 31);
            this.UserFullNameLabel.MinimumSize = new System.Drawing.Size(180, 31);
            this.UserFullNameLabel.Name = "UserFullNameLabel";
            this.UserFullNameLabel.Size = new System.Drawing.Size(180, 31);
            this.UserFullNameLabel.TabIndex = 16;
            this.UserFullNameLabel.Text = "EMPLOYEE NAME";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(1652, 54);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.MaximumSize = new System.Drawing.Size(180, 31);
            this.UserNameLabel.MinimumSize = new System.Drawing.Size(180, 31);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(180, 31);
            this.UserNameLabel.TabIndex = 17;
            this.UserNameLabel.Text = "USERNAME";
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(52, 20);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(270, 49);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete Patient";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // deleteSuccessMessage
            // 
            this.deleteSuccessMessage.AutoSize = true;
            this.deleteSuccessMessage.Location = new System.Drawing.Point(52, 80);
            this.deleteSuccessMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteSuccessMessage.Name = "deleteSuccessMessage";
            this.deleteSuccessMessage.Size = new System.Drawing.Size(142, 20);
            this.deleteSuccessMessage.TabIndex = 19;
            this.deleteSuccessMessage.Text = "Delete Successful!";
            this.deleteSuccessMessage.Visible = false;
            // 
            // NurseMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 1061);
            this.Controls.Add(this.deleteSuccessMessage);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserFullNameLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientIDLabel);
            this.Controls.Add(this.SelectedPatientNameLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.SelectedPatientIDLabel);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.DashboardTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1850, 1167);
            this.MinimumSize = new System.Drawing.Size(1850, 1038);
            this.Name = "NurseMainDashboard";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.DashboardTabControl.ResumeLayout(false);
            this.SearchPatientTab.ResumeLayout(false);
            this.registerPatientTab.ResumeLayout(false);
            this.editPatientTab.ResumeLayout(false);
            this.ScheduleApptTab.ResumeLayout(false);
            this.EditApptTab.ResumeLayout(false);
            this.visitsTabPage.ResumeLayout(false);
            this.addVisitTabPage.ResumeLayout(false);
            this.EditVisitTab.ResumeLayout(false);
            this.OrderTestTab.ResumeLayout(false);
            this.enterTestResultsTab.ResumeLayout(false);
            this.searchTestResults.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage EditVisitTab;
        private UserControls.AppointmentBookingUserControl appointmentBookingUserControl2;
        private UserControls.EditAppointmentUserControl editAppointmentUserControl1;
        private UserControls.AllVisitsUserControl allVisitsUserControl1;
        private UserControls.AddVisitUserControl addVisitUserControl1;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.Label SelectedPatientIDLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private UserControls.RegisterPatientUserControl registerPatientUserControl1;
        private UserControls.UpdateVisitUserControl updateVisitUserControl1;
        private System.Windows.Forms.TabPage editPatientTab;
        private UserControls.SearchUserControl searchUserControl2;
        private System.Windows.Forms.Button SelectPatientButton;
        private UserControls.EditPatientUserControl editPatientUserControl1;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label SelectedPatientNameLabel;
        private System.Windows.Forms.TabPage SearchPatientTab;
        private System.Windows.Forms.Label PatientIDLabel;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label UserFullNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TabPage OrderTestTab;
        private UserControls.OrderTestsUserControl orderTestsUserControl1;
        private System.Windows.Forms.TabPage enterTestResultsTab;
        private UserControls.EnterTestResultsUserControl enterTestResultsUserControl1;
        private System.Windows.Forms.TabPage searchTestResults;
        private UserControls.SearchTestResultsUserControl searchTestResultsUserControl1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label deleteSuccessMessage;
    }
}