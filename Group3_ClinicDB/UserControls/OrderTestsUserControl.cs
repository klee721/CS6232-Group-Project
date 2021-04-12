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
    public partial class OrderTestsUserControl : UserControl
    {
        private readonly LabTestController labTestController;

        private Test test;
        public Patient patient;

        /// <summary>
        /// The constructor
        /// </summary>
        /// 

        public OrderTestsUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.test = new Test();
            //this.Enabled = false;
        }

        /// <summary>
        /// Method to retrieve a patient object from the parent form. This enables the module and loads the patient data
        /// </summary>
        /// <param name="selectedPatient">a Patient object to use in appointment booking</param>
        public void GetPatient(Patient selectedPatient)
        {
            this.patient = selectedPatient;
            this.Enabled = true;

            this.RefreshTests();
        }


        /// <summary>
        /// Event when a user clicks Create. First verifies that the selected test is available for the selected date and time. If so, the user can confirm or back out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabTestButton_Click(object sender, EventArgs e)
        {
            if (this.test.TestCode == "")
            {
                MessageBox.Show("Please select test code", "Test Required");
                return;
            }
            if (string.IsNullOrEmpty(this.descriptionLabel.Text.ToString()))
            {
                MessageBox.Show("Test code is required.", "Error!");
                return;
            }

            if (string.IsNullOrEmpty(this.testCodecomboBox.SelectedValue.ToString()))
            {
                MessageBox.Show("Test code is required.", "Error!");
                return;
            }

            DateTime newTestTime = DateTime.Now;
            LabTest labTest = new LabTest();
            labTest.PatientID = this.patient.Id;
            labTest.TestCode = this.test.TestCode;
            labTest.OrderDateTime = newTestTime;

            
            if (this.labTestController.OrderLabTest(labTest))
            {

                this.confirmLabel.Text = "Lab test ordered successfully";
                this.Reset();
            }
            else
            {
                MessageBox.Show("Lab test is not ordered");
            }


        }

        /// <summary>
        /// Method to reset all values
        /// </summary>
        /// 
        private void Reset()
        {
            this.testCodecomboBox.SelectedIndex = 0; 
            this.testNameLabel.Text = "";
            this.descriptionLabel.Text = "";
             this.confirmLabel.Text = "";
            //this.testCodecomboBox.Refresh();
            //this.RefreshTests();
            
        }

        /// <summary>
        /// Method for clear button
        /// </summary>
        /// 
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.confirmLabel.Text = "";
        }

        /// <summary>
        /// Method to refresh Nurses combo box
        /// </summary>
        /// 
        private void RefreshTests()
        {
            testCodecomboBox.Items.Clear();
            List<Test> tests;


            try
            {
                //instead of using the following line of code, which couples the 
                //DAL with the view, we ask the controller to get the data for us 
                //so that the view does not have to know where the data comes from
                //(the line after the commented line)

                tests = this.labTestController.GetAllTests();
                testCodecomboBox.Refresh();
                if (tests.Count > 0)
                {

                    testCodecomboBox.DisplayMember = "testCode";
                    testCodecomboBox.ValueMember = "testCode";
                    testCodecomboBox.DataSource = tests;

                }
                else
                {
                    MessageBox.Show("No Tests.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }

        private void testCodecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = testCodecomboBox.SelectedValue.ToString();
            this.test = labTestController.GetTestByCode(code);

            descriptionLabel.Text = test.Description;
            testNameLabel.Text = test.Name;
        }
    }
}
