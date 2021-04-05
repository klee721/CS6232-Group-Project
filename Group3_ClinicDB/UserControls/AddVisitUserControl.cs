using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.UserControls
{
    public partial class AddVisitUserControl : UserControl
    {

        private readonly VisitsController visitController;
        private readonly AppointmentController appointmentController;

        private readonly NurseController nurseController;

        private List<Nurse> nurses;

        public Patient patient;
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.visitController = new VisitsController();
            this.appointmentController = new AppointmentController();
            this.nurseController = new NurseController();
            this.Enabled = false;
        }

        /// <summary>
        /// Method to retrieve a patient object from the parent form. This enables the module and loads the patient data
        /// </summary>
        /// <param name="selectedPatient">a Patient object to use in appointment booking</param>
        public void GetPatient(Patient selectedPatient)
        {
            this.patient = selectedPatient;
            this.Enabled = true;
           
            this.RefreshAppointments();
        }

        private void RefreshAppointments()
        {
            appointment_idComboBox.Items.Clear();
            List<Appointment> appointments;


            try
            {
                //instead of using the following line of code, which couples the 
                //DAL with the view, we ask the controller to get the data for us 
                //so that the view does not have to know where the data comes from
                //(the line after the commented line)

                if (this.patient != null)
                {
                    appointments = this.appointmentController.GetAllAppointmentsByPatient(this.patient.Id); //Added patient_id 1
                    appointment_idComboBox.Refresh();
                    if (appointments.Count > 0)
                    {

                        appointment_idComboBox.DisplayMember = "AppointmentDate";
                        appointment_idComboBox.ValueMember = "ID";
                        appointment_idComboBox.DataSource = appointments;

                    }
                    else
                    {
                        MessageBox.Show("No appointments.");

                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }

        private void RefreshNurses()
        {
            nurseComboBox.Items.Clear();
            List<Nurse> nurses;


            try
            {
                //instead of using the following line of code, which couples the 
                //DAL with the view, we ask the controller to get the data for us 
                //so that the view does not have to know where the data comes from
                //(the line after the commented line)

                nurses = this.nurseController.GetAllNurses();
                nurseComboBox.Refresh();
                if (nurses.Count > 0)
                {

                    nurseComboBox.DisplayMember = "FirstName";
                    nurseComboBox.ValueMember = "NurseID";
                    nurseComboBox.DataSource = nurses;

                }
                else
                {
                    MessageBox.Show("No Nurses.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var appointment_id = this.appointment_idComboBox.SelectedValue;
            var nurseId = this.nurseComboBox.SelectedValue;

            if (string.IsNullOrEmpty(this.weightTextBox.Text.ToString()))
            {
                MessageBox.Show("Weight is required.", "Error!");
                return;
            }
            var weight = int.Parse(this.weightTextBox.Text.ToString());

            if (string.IsNullOrEmpty(this.heightTextBox.Text.ToString()))
            {
                MessageBox.Show("height is required.", "Error!");
                return;
            }
            var height = int.Parse(this.heightTextBox.Text.ToString());

            if (string.IsNullOrEmpty(this.bloodPressureSystolicTextBox.Text.ToString()))
            {
                MessageBox.Show("bloodPressureSystolic is required.", "Error!");
                return;
            }
            var bloodPressureSystolic = int.Parse(this.bloodPressureSystolicTextBox.Text.ToString());

            if (string.IsNullOrEmpty(this.bloodPressureDiastolicTextBox.Text.ToString()))
            {
                MessageBox.Show("bloodPressureDiastolic is required.", "Error!");
                return;
            }
            var bloodPressureDiastolic = int.Parse(this.bloodPressureDiastolicTextBox.Text.ToString());

            if (string.IsNullOrEmpty(this.pulseTextBox.Text.ToString()))
            {
                MessageBox.Show("pulse is required.", "Error!");
                return;
            }
            var pulse = int.Parse(this.pulseTextBox.Text.ToString());

            if (string.IsNullOrEmpty(this.bodyTemparatureTextBox.Text.ToString()))
            {
                MessageBox.Show("bodyTemparature is required.", "Error!");
                return;
            }
            var bodyTemparature = int.Parse(this.bodyTemparatureTextBox.Text.ToString());
            if (string.IsNullOrEmpty(this.initialDiagnoseTextBox.Text.ToString()))
            {
                MessageBox.Show("initialDiagnose is required.", "Error!");
                return;
            }
            var initialDiagnose = this.initialDiagnoseTextBox.Text;
            var finalDiagnose = this.finalDiagnoseTextBox.Text;
            var symptoms = this.symptomsTextBox.Text;

            try
            {
                Visits visit = new Visits();
                visit.appointment_id = (int)appointment_id;
                visit.bloodPressureDiastolic = bloodPressureDiastolic;
                visit.bloodPressureSystolic = bloodPressureSystolic;
                visit.bodyTemparature = bodyTemparature;
                visit.finalDiagnose = finalDiagnose;
                visit.height = height;
                visit.initialDiagnose = initialDiagnose;
                visit.nurseId = (int)nurseId;
                visit.pulse = pulse;
                visit.symptoms = symptoms;
                visit.weight = weight;
                
               
              
                    if (this.visitController.AddVisit(visit))
                    {

                        this.confirmLabel.Text = "Visit added successfully";
                    }
                    else
                    {
                        MessageBox.Show("Visit is not added");
                    }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddVisitUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshAppointments();
            this.RefreshNurses();


        }

       
    }
}
