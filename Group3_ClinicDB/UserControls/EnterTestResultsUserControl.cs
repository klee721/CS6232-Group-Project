using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class EnterTestResultsUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        private Patient patient;

        public EnterTestResultsUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.patient = null;
        }

        /// <summary>
        /// Retrieves the patient that has been searched
        /// </summary>
        /// <param name="searchedPatient">The patient that has been searched</param>
        /// <returns>The patient that has been searched</returns>
        public Patient GetPatient(Patient searchedPatient)
        {
            this.patient = searchedPatient;

            this.InitEnterTestResults();

            return this.patient;
        }

        private void InitEnterTestResults()
        {
            if (this.patient != null)
            {
                this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatient(this.patient);
            }
        }

        private void EnterTestResultsUserControlLoad(object sender, EventArgs e)
        {
            this.InitEnterTestResults();
        }

        private void EnterTestResultsUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitEnterTestResults();
        }
    }
}
