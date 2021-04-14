using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Collections.Generic;
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
        /// Resets the Patient ListView source to all patients
        /// </summary>
        public void InitPatients()
        {
            //this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
            /*
            List<Patient> patientsList;
            this.patientListView.Items.Clear();

            try
            {
                patientsList = this.patientController.GetAllPatients();

                if (patientsList.Count > 0)
                {
                    Patient patient;
                    for (int current = 0; current < patientsList.Count; current++)
                    {
                        patient = patientsList[current];
                        this.patientListView.Items.Add(patient.Id.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.PersonsId.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.FirstName.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.LastName.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.DateOfBirth.ToShortDateString());
                        this.patientListView.Items[current].SubItems.Add(patient.Gender.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.SSN.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.Address1.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.Address2.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.City.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.State.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.ZipCode.ToString());
                        this.patientListView.Items[current].SubItems.Add(patient.PhoneNumber.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Patients available");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            */
        }

        private void AllPatientUserControlLoad(object sender, EventArgs e)
        {
            this.InitPatients();
        }

        private void AllPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitPatients();
        }
        /*
        /// <summary>
        /// Changes the ListView to a single patient
        /// </summary>
        public void GetPatient(Patient patient)
        {
            this.patientListView.Items.Clear();

            this.patientListView.Items.Add(patient.Id.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.PersonsId.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.FirstName.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.LastName.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.DateOfBirth.ToShortDateString());
            this.patientListView.Items[0].SubItems.Add(patient.Gender.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.SSN.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.Address1.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.Address2.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.City.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.State.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.ZipCode.ToString());
            this.patientListView.Items[0].SubItems.Add(patient.PhoneNumber.ToString());
        }
        */

        /// <summary>
        /// Changes the data source of the datagrid view
        /// </summary>
        public void SetDataSource(List<Patient> patients)
        {
            //this.patientDataGridView.DataSource = patients;
        }
    }
}
