using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatientPerformed(this.patient);
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
                this.visitIdErrorLabel.Visible = true;
                this.visitIdButton.Enabled = true;
                this.visitIdResetButton.Enabled = true;
            }
        }

        private void VisitIdTextBoxTextChanged(object sender, EventArgs e)
        {

        }
    }
}
