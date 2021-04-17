using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class EnterTestResultsUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        private Patient patient;
        private int normalIndex;
        private LabTest oldLabTest;
        private LabTest newLabTest;

        public EnterTestResultsUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.patient = null;
            this.oldLabTest = new LabTest();
            this.newLabTest = new LabTest();
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
                this.HidePatientInfo(true);

                this.normalComboBox.Items.Clear();
                this.normalComboBox.Items.Add("Y");
                this.normalComboBox.Items.Add("N");
                this.normalComboBox.SelectedIndex = 0;
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

        private void HidePatientInfo(bool hide)
        {
            if (hide)
            {
                this.patientNameLabel.Visible = false;
                this.orderDateTimeLabel.Visible = false;
                this.fullOrderedDateTimeTextBox.Visible = false;
                this.performedDateTimeLabel.Visible = false;
                this.fullPerformedDateTimeTextBox.Visible = false;
                this.testCodeLabel.Visible = false;
                this.testCodeTextBox.Visible = false;
                this.resultsLabel.Visible = false;
                this.resultsTextBox.Visible = false;
                this.normalLabel.Visible = false;
                this.normalComboBox.Visible = false;
                this.testResultsButton.Visible = false;
                this.resultsErrorLabel.Visible = false;
            } else
            {
                this.patientNameLabel.Text = this.patient.FirstName + " " + this.patient.LastName + "'s lab test";
                this.patientNameLabel.Visible = true;
                this.orderDateTimeLabel.Visible = true;
                this.fullOrderedDateTimeTextBox.Visible = true;
                this.performedDateTimeLabel.Visible = true;
                this.fullPerformedDateTimeTextBox.Visible = true;
                this.fullPerformedDateTimeTextBox.Text = "Updated at time of submission";
                this.testCodeLabel.Visible = true;
                this.testCodeTextBox.Visible = true;
                this.resultsLabel.Visible = true;
                this.resultsTextBox.Visible = true;
                this.normalLabel.Visible = true;
                this.normalComboBox.Visible = true;
                this.testResultsButton.Visible = true;
            }
        }

        private void PatientDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (patientDataGridView.SelectedCells.Count > 0)
            {
                this.HidePatientInfo(false);
                this.resultsErrorLabel.Visible = false;
                this.resultsErrorLabel.ForeColor = Color.Black;

                int selectedrowindex = patientDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patientDataGridView.Rows[selectedrowindex];

                int id = (int)selectedRow.Cells["PatientId"].Value;
                DateTime orderDateTime = (DateTime)selectedRow.Cells["OrderDateTime"].Value;
                DateTime performedDateTime = (DateTime)selectedRow.Cells["PerformedDateTime"].Value;
                string testCode = selectedRow.Cells["TestCode"].Value.ToString();
                string results = selectedRow.Cells["Results"].Value.ToString();
                string normal = selectedRow.Cells["Normal"].Value.ToString();
                int visitID = (int)selectedRow.Cells["visitId"].Value;

                this.fullOrderedDateTimeTextBox.Text = orderDateTime.ToString();
                this.testCodeTextBox.Text = testCode;
                this.resultsTextBox.Text = results;
                this.normalIndex = normalComboBox.Items.IndexOf(normal);
                this.normalComboBox.SelectedIndex = this.normalIndex;

                this.oldLabTest.PatientID = id;
                this.oldLabTest.OrderDateTime = orderDateTime;
                this.oldLabTest.PerformedDateTime = performedDateTime;
                this.oldLabTest.TestCode = this.testCodeTextBox.Text;
                this.oldLabTest.Results = this.resultsTextBox.Text;
                this.oldLabTest.Normal = this.normalComboBox.SelectedItem.ToString();
                this.oldLabTest.visitId = visitID;
            }
        }

        private void TestResultsButtonClick(object sender, EventArgs e)
        {
            if(this.resultsTextBox.Text.Equals(""))
            {
                this.resultsErrorLabel.Text = "Must enter a result for the lab test";
                this.resultsErrorLabel.Visible = true;
                this.resultsErrorLabel.ForeColor = Color.Red;
            } else
            {
                this.newLabTest.PatientID = this.oldLabTest.PatientID;
                this.newLabTest.OrderDateTime = this.oldLabTest.OrderDateTime;
                this.newLabTest.PerformedDateTime = DateTime.Now;
                this.newLabTest.TestCode = this.oldLabTest.TestCode;
                this.newLabTest.Results = this.resultsTextBox.Text;
                this.newLabTest.Normal = this.oldLabTest.Normal;
                this.newLabTest.visitId = this.oldLabTest.visitId;

                //this.labTestController.UpdateLabTest(this.oldLabTest, this.newLabTest);

                this.fullPerformedDateTimeTextBox.Text = this.newLabTest.PerformedDateTime.ToString();
                this.fullPerformedDateTimeTextBox.Visible = true;

                this.oldLabTest = this.newLabTest;
                this.newLabTest = null;
                this.patientDataGridView.DataSource = this.labTestController.GetAllLabTestsForPatient(this.patient);

                this.resultsErrorLabel.Visible = true;
                this.resultsErrorLabel.Text = "Results successfully entered!";
                this.resultsErrorLabel.ForeColor = Color.Black;
            }
        }

        private void ResultsTextBoxTextChanged(object sender, EventArgs e)
        {
            this.resultsErrorLabel.Visible = false;
            this.resultsErrorLabel.ForeColor = Color.Black;
        }
    }
}
