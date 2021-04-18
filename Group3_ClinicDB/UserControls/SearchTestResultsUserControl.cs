using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                this.performedTextBox.Text = "";
                this.resultsTextBox.Text = "";
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
            this.performedTextBox.Text = "";
            this.resultsTextBox.Text = "";
            this.visitIdTextBox.Text = "";
            this.HideErrorLabel(true, "");
            this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatientPerformed(this.patient);
        }

        private void HideErrorLabel(bool hide, string text)
        {
            if (hide)
            {
                this.visitIdErrorLabel.Visible = false;
                this.visitIdErrorLabel.Text = text;
                this.visitIdErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.visitIdErrorLabel.Visible = true;
                this.visitIdErrorLabel.Text = text;
                this.visitIdErrorLabel.ForeColor = Color.Red;
            }
        }

        private void VisitIdButtonClick(object sender, EventArgs e)
        {
            this.ValidateVisitID();
        }

        private void ValidateVisitID()
        {
            if (this.visitIdTextBox.Text.Equals(""))
            {
                this.HideErrorLabel(false, "Visit ID cannot be empty");
            }
            else
            {
                try
                {
                    int visitInt = Convert.ToInt32(this.visitIdTextBox.Text);

                    if (visitInt < 0)
                    {
                        this.HideErrorLabel(false, "Visit ID cannot be a negative number");
                    } else
                    {
                        this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatientPerformedByVisitId(this.patient, visitInt);
                       
                        if (this.patientDataGridView.Rows.Count == 0)
                        {
                            this.performedTextBox.Text = "";
                            this.resultsTextBox.Text = "";
                            this.HideErrorLabel(false, "No Lab Tests found for the specified visit ID");
                            this.visitIdErrorLabel.ForeColor = Color.Black;
                        }
                        else
                        {
                            this.visitIdTextBox.Text = "";
                            this.performedTextBox.Text = "";
                            this.resultsTextBox.Text = "";
                            this.HideErrorLabel(false, "Search successful!");
                            this.visitIdErrorLabel.ForeColor = Color.Black;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Visit ID can only be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.HideErrorLabel(false, "Visit ID can only be a number");
                }
            }
        }

        private void PatientDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (patientDataGridView.SelectedCells.Count > 0)
            {
                this.visitIdTextBox.Text = "";
                this.performedTextBox.Text = "";
                this.resultsTextBox.Text = "";

                int selectedrowindex = patientDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patientDataGridView.Rows[selectedrowindex];

                int id = (int)selectedRow.Cells["PatientId"].Value;
                DateTime orderDateTime = (DateTime)selectedRow.Cells["OrderDateTime"].Value;
                DateTime performedDateTime = (DateTime)selectedRow.Cells["PerformedDateTime"].Value;
                string testCode = selectedRow.Cells["TestCode"].Value.ToString();
                string results = selectedRow.Cells["Results"].Value.ToString();
                string normal = selectedRow.Cells["Normal"].Value.ToString();
                int visitID = (int)selectedRow.Cells["visitId"].Value;

                this.performedTextBox.Text = performedDateTime.ToString();
                this.resultsTextBox.Text = results;
            }
        }
    }
}
