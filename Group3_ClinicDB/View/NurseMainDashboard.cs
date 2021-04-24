using System;
using Group3_ClinicDB.Model;
using System.Windows.Forms;

namespace Group3_ClinicDB.View
{
    public partial class NurseMainDashboard : Form
    {
        public User user;
        public Patient patient;
        private LoginForm loginform;

        public NurseMainDashboard(User user, LoginForm loginform)
        {
            InitializeComponent();
            this.UserNameLabel.Text = user.userName;
            this.UserFullNameLabel.Text = user.firstName + " " + user.lastName;
            this.loginform = loginform;
            this.PatientIDLabel.Text = "";
            this.PatientNameLabel.Text = "";
            this.user = user;
        }

        private void SelectPatientButtonClick(object sender, EventArgs e)
        {
            if (this.searchUserControl2.GetPatient() != null)
            {
                this.patient = this.searchUserControl2.GetPatient();
                this.PatientIDLabel.Text = this.patient.Id.ToString();
                this.PatientNameLabel.Text = this.patient.FirstName + " " + this.patient.LastName;

                this.appointmentBookingUserControl2.GetPatient(this.patient);
                this.editAppointmentUserControl1.GetPatient(this.patient);
                this.editPatientUserControl1.GetPatient(this.patient);
                this.addVisitUserControl1.GetPatient(this.patient);
                this.allVisitsUserControl1.GetPatient(this.patient);
                this.updateVisitUserControl1.GetPatient(this.patient);
                this.orderTestsUserControl1.GetPatient(this.patient);
                this.enterTestResultsUserControl1.GetPatient(this.patient);
                this.searchTestResultsUserControl1.GetPatient(this.patient);
                this.addVisitUserControl1.GetNurse(this.user);
                //PUT ANY UC PATIENT GETS HERE
            }
            else
            {
                MessageBox.Show("No patient selected. Please search for a patient and select them.");
            }
        }

        private void LogoutLinkClick(object sender, EventArgs e)
        {
            this.Hide();
            this.loginform.Show();
            this.patient = null;
            this.PatientIDLabel.Text = "";
            this.PatientNameLabel.Text = "";
            this.DisableModules();

        }

        private void DisableModules()
        {
            this.appointmentBookingUserControl2.Enabled = false;
            this.editAppointmentUserControl1.Enabled = false;
            this.addVisitUserControl1.Enabled = false;
            this.updateVisitUserControl1.Enabled = false;
            this.allVisitsUserControl1.Enabled = false;
            this.orderTestsUserControl1.Enabled = false;
            //           this.editPatientUserControl1.Enabled = false;
            this.editPatientUserControl1.NullifyPatients();
            this.enterTestResultsUserControl1.GetPatient(null);
            this.searchTestResultsUserControl1.GetPatient(null);
            //DISABLE YOUR MODULES ON LOGOUT HERE
        }

        /// <summary>
        /// Method that changes the logged in user to a new User
        /// </summary>
        /// <param name="newUser">the new user logging into the system</param>
        public void ChangeUser(User newUser)
        {
            this.user = newUser;
            this.UserNameLabel.Text = user.userName;
            this.UserFullNameLabel.Text = user.firstName + " " + user.lastName;
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
