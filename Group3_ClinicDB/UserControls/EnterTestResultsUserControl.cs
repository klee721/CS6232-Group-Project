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
        private int patientId;
        private int normalIndex;
        private LabTest oldLabTest;
        private LabTest newLabTest;

        public EnterTestResultsUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.patient = null;
            this.patientId = 0;
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
                this.performedDateTimePicker.MaxDate = DateTime.Now.AddDays(1);
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
                this.orderDateTimePicker.Visible = false;
                this.performedDateTimeLabel.Visible = false;
                this.performedDateTimePicker.Visible = false;
                this.testCodeLabel.Visible = false;
                this.testCodeTextBox.Visible = false;
                this.resultsLabel.Visible = false;
                this.resultsTextBox.Visible = false;
                this.normalLabel.Visible = false;
                this.normalComboBox.Visible = false;
            } else
            {
                this.patientNameLabel.Text = this.patient.FirstName + " " + this.patient.LastName + "'s lab test";
                this.patientNameLabel.Visible = true;
                this.orderDateTimeLabel.Visible = true;
                this.orderDateTimePicker.Visible = true;
                this.performedDateTimeLabel.Visible = true;
                this.performedDateTimePicker.Visible = true;
                this.testCodeLabel.Visible = true;
                this.testCodeTextBox.Visible = true;
                this.resultsLabel.Visible = true;
                this.resultsTextBox.Visible = true;
                this.normalLabel.Visible = true;
                this.normalComboBox.Visible = true;
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

                this.patientId = id;
                this.orderDateTimePicker.Value = orderDateTime;
                this.performedDateTimePicker.MinDate = orderDateTime.AddDays(1);
                this.performedDateTimePicker.Value = performedDateTime;
                this.testCodeTextBox.Text = testCode;
                this.resultsTextBox.Text = results;
                this.normalIndex = normalComboBox.Items.IndexOf(normal);
                this.normalComboBox.SelectedIndex = this.normalIndex;

                this.oldLabTest.PatientID = this.patientId;
                this.oldLabTest.OrderDateTime = this.orderDateTimePicker.Value;
                this.oldLabTest.PerformedDateTime = this.performedDateTimePicker.Value;
                this.oldLabTest.TestCode = this.testCodeTextBox.Text;
                this.oldLabTest.Results = this.resultsTextBox.Text;
                this.oldLabTest.Normal = this.normalComboBox.SelectedItem.ToString();
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
                this.newLabTest.PatientID = this.patientId;
                this.newLabTest.OrderDateTime = this.orderDateTimePicker.Value;
                this.newLabTest.PerformedDateTime = this.performedDateTimePicker.Value;
                this.newLabTest.TestCode = this.testCodeTextBox.Text;
                this.newLabTest.Results = this.resultsTextBox.Text;
                this.newLabTest.Normal = this.normalComboBox.SelectedItem.ToString();
                this.labTestController.UpdateLabTest(this.oldLabTest, this.newLabTest);
            }
        }

        private void ResultsTextBoxTextChanged(object sender, EventArgs e)
        {
            this.resultsErrorLabel.Visible = false;
            this.resultsErrorLabel.ForeColor = Color.Black;
        }
    }
}
