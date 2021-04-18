using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// User Control for searching test results
    /// </summary>
    public partial class SearchTestResultsUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        private Patient patient;

        /// <summary>
        /// 0 parameter constructor
        /// </summary>
        public SearchTestResultsUserControl()
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

            this.InitSearchTestResults();

            return this.patient;
        }

        private void InitSearchTestResults()
        {
            this.DisablePatientInfo(true);
            this.patientDataGridView.DataSource = null;

            if (this.patient != null)
            {
                this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatientPerformed(this.patient);
                this.DisablePatientInfo(false);
            }
        }

        private void SearchTestResultsUserControlLoad(object sender, EventArgs e)
        {
            this.InitSearchTestResults();
        }

        private void SearchTestResultsUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitSearchTestResults();
        }

        private void DisablePatientInfo(bool disable)
        {
            if (disable)
            {
                this.patientNameLabel.Text = "test results search";
                this.visitIdRadioButton.Checked = false;
                this.visitIdTextBox.ReadOnly = true;
                this.visitIdErrorLabel.Visible = false;
                this.visitIdButton.Enabled = false;
                this.visitIdResetButton.Enabled = false;
            }
            else
            {
                this.patientNameLabel.Text = this.patient.FirstName + " " + this.patient.LastName + "'s test results search";
                this.visitIdRadioButton.Checked = true;
                this.visitIdTextBox.ReadOnly = false;
                this.visitIdButton.Enabled = true;
                this.visitIdResetButton.Enabled = true;
            }
        }

        private void VisitIdTextBoxTextChanged(object sender, EventArgs e)
        {
            this.visitIdErrorLabel.Visible = false;
        }

        private void VisitIdResetButtonClick(object sender, EventArgs e)
        {
            this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatientPerformed(this.patient);
        }

        private void VisitIdButtonClick(object sender, EventArgs e)
        {
            //validations
            //error
            //DAL method
            //success message
            //failure message
        }
    }
}
