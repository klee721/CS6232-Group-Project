using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// UserControl for creating an interface for scheduling new appointments for a patient
    /// </summary>
    public partial class AppointmentBookingUserControl : UserControl
    {

        private AppointmentController apptController;
        private DoctorController doctorController;
        public Patient patient;

        /// <summary>
        /// Constructor. Initializes instance variables and some UI elements
        /// </summary>
        public AppointmentBookingUserControl()
        {
            InitializeComponent();
            this.apptController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.InitializeDoctorComboBox();
            this.ApptDatePicker.Value = DateTime.Now.Date;
            this.ApptDatePicker.MinDate = DateTime.Now.Date;
            this.Enabled = false;
             
        }
        /// <summary>
        /// Event when a user clicks Create. First verifies that the selected doctor is available for the selected date and time. If so, the user can confirm or back out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateApptButton_Click(object sender, EventArgs e)
        {
            if (this.ReasonRichText.Text == "")
            {
                MessageBox.Show("Please enter a reason for the appointment", "Reason Required");
                return;
            }

            DateTime newAptTime = this.CombineDateAndTime();
            int doctorID = Int32.Parse(this.DoctorComboBox.SelectedValue.ToString());
            bool result = this.apptController.CheckAvailability(doctorID, newAptTime);

            if (result)
            {
                DialogResult dialogresult = MessageBox.Show("Dr. " + this.DoctorComboBox.Text + " is available, please click OK to schedule.", "Availability Found", MessageBoxButtons.OKCancel);
                if (dialogresult == DialogResult.OK)
                {
                    Appointment appointment = new Appointment();
                    appointment.PatientID = this.patient.Id;
                    appointment.DoctorID = Int32.Parse(this.DoctorComboBox.SelectedValue.ToString());
                    appointment.AppointmentDate = newAptTime;
                    appointment.Reason = this.ReasonRichText.Text;
                    appointment.Status = "A";
                    this.apptController.AddAppointment(appointment);
                    this.RefreshUI();
                }
                else
                {
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Dr. " + this.DoctorComboBox.Text + " is not available in that timeslot.");
            }

        }

        /// <summary>
        /// Private helper to combine the values of both DateTimePickers into one Datetime for DB writing
        /// </summary>
        /// <returns>void</returns>
        private DateTime CombineDateAndTime()
        {
            DateTime Date = this.ApptDatePicker.Value.Date;
            DateTime Time = this.ApptTimePicker.Value;
            DateTime newDateTime = Date.Add(Time.TimeOfDay);
            return newDateTime;
        }

        private void RefreshUI()
        {
            this.PatientApptList.DataSource = this.apptController.GetAllAppointmentsByPatient(this.patient.Id);
            this.ReasonRichText.Text = "";
           
        }

        private void InitializeDoctorComboBox()
        {
            List<Doctor> doctorList = this.doctorController.GetAllDoctors();
            if (doctorList.Count <= 0)
            {
                this.Enabled = false;
                MessageBox.Show("There are no doctors. Please register a doctor to the database.");
            }
            else
            {
                this.Enabled = true;
                this.DoctorComboBox.DataSource = doctorList;
                this.DoctorComboBox.DisplayMember = "LastName";
                this.DoctorComboBox.ValueMember = "DoctorID";
            }
        }

        private void Plus30_Click(object sender, EventArgs e)
        {

            DateTime tempTime = ApptTimePicker.Value;
            tempTime = tempTime.AddMinutes(30);

            this.ApptTimePicker.Value = tempTime;
        }

        private void Minus30Button_Click(object sender, EventArgs e)
        {
            DateTime tempTime = ApptTimePicker.Value;
            tempTime = tempTime.AddMinutes(-30);

            this.ApptTimePicker.Value = tempTime;
        }

        /// <summary>
        /// Method to retrieve a patient object from the parent form. This enables the module and loads the patient data
        /// </summary>
        /// <param name="selectedPatient">a Patient object to use in appointment booking</param>
        public void GetPatient(Patient selectedPatient)
        {
            this.patient = selectedPatient;
            this.Enabled = true;
            this.PatientApptList.DataSource = this.apptController.GetAllAppointmentsByPatient(this.patient.Id);
        }

        private void ClearApptList(object sender, EventArgs e)
        {
            this.PatientApptList.DataSource = null;
           
        }
    }
}
