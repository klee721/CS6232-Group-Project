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
            this.LoggedInTextBox.Text = user.userName;
            this.loginform = loginform;
            this.SelectedPatientTextBox.Text = "";
        }


        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            if (this.searchUserControl2.GetPatient() != null)
            {
                this.patient = this.searchUserControl2.GetPatient();
                this.SelectedPatientTextBox.Text = "ID #: " + this.patient.Id;

                this.appointmentBookingUserControl2.GetPatient(this.patient);
                this.editAppointmentUserControl1.GetPatient(this.patient);
                this.editPatientUserControl1.GetPatient(this.patient);
                //PUT ANY UC PATIENT GETS HERE
            }
            else
            {
                MessageBox.Show("No patient selected. Please search for a patient and select them.");
            }
        }

        private void LogoutLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.loginform.Show();
            this.patient = null;
            this.SelectedPatientTextBox.Text = "";
            this.DisableModules();

        }

        private void DisableModules()
        {
            this.appointmentBookingUserControl2.Enabled = false;
            this.editAppointmentUserControl1.Enabled = false;
            //DISABLE YOUR MODULES ON LOGOUT HERE

        }

        /// <summary>
        /// Method that changes the logged in user to a new User
        /// </summary>
        /// <param name="newUser">the new user logging into the system</param>
        public void ChangeUser(User newUser)
        {
            this.user = newUser;
            this.LoggedInTextBox.Text = user.userName;
        }
    }
}
