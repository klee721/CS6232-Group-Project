using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class AllPatientUserControl : UserControl
    {
        private readonly PatientController patientController;

        public AllPatientUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        /// <summary>
        /// Resets the Patient DataGridView source to all patients
        /// </summary>
        public void InitPatients()
        {
            this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
        }

        private void AllPatientUserControlLoad(object sender, EventArgs e)
        {
            this.InitPatients();
        }

        private void AllPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitPatients();
        }

        /// <summary>
        /// Changes the data source to a single patient
        /// </summary>
        public void GetPatient(Patient patient)
        {
            //this.patientDataGridView.DataSource = this.patientController.GetPatient(patient);
        }
    }
}
