using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.UserControls
{
    public partial class EditAppointmentUserControl : UserControl
    {

        private AppointmentController apptController;
        private DoctorController doctorController;
        private Appointment selectedAppointment;
        private List<Appointment> appointmentList;

        public EditAppointmentUserControl()
        {
            InitializeComponent();
            this.apptController = new AppointmentController();
            this.doctorController = new DoctorController(); 
            this.selectedAppointment = new Appointment();

           
            this.SetupAppointmentsComboBox();
            this.SetupDoctorsComboBox();
            this.FillOutForm();
        }


        private void ApptSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillOutForm();
        }

        /// <summary>
        /// This function refreshes the Appointments stored in this combo box to account for New Appointments being created in other tabs
        /// </summary>
        public void SetupAppointmentsComboBox()
        {
            this.appointmentList = this.apptController.GetActiveAppointmentsByPatient(1); //TESTING DAL WITH PATIENT 1
            this.ApptSelectComboBox.DataSource = appointmentList;  
            this.ApptSelectComboBox.DisplayMember = "AppointmentDate";
            this.ApptSelectComboBox.ValueMember = "ID";
        }

        private void SetupDoctorsComboBox()
        {
            this.DoctorComboBox.DataSource = this.doctorController.GetAllDoctors();
            this.DoctorComboBox.DisplayMember = "LastName";
            this.DoctorComboBox.ValueMember = "DoctorID";
        }

        private void FillOutForm()
        {
   
            int index = (int)this.ApptSelectComboBox.SelectedValue;
            this.selectedAppointment = this.appointmentList.Find(apt => apt.ID == index);

            this.ApptDatePicker.Value = selectedAppointment.AppointmentDate.Date;
            this.ApptDatePicker.MinDate = DateTime.Now.Date;
            this.ApptTimePicker.Value = DateTime.Now.Date;
            this.ApptTimePicker.Value += selectedAppointment.AppointmentDate.TimeOfDay;
            this.DoctorComboBox.SelectedValue = selectedAppointment.DoctorID;
            this.ReasonRichText.Text = selectedAppointment.Reason;


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
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
                    appointment.ID = selectedAppointment.ID;
                    appointment.PatientID = 1;   //TESTING DAL WITH PATIENT 1
                    appointment.DoctorID = Int32.Parse(this.DoctorComboBox.SelectedValue.ToString());
                    appointment.AppointmentDate = newAptTime;
                    appointment.Reason = this.ReasonRichText.Text;
                    this.apptController.UpdateAppointment(appointment);

                    MessageBox.Show("Appointment on " + appointment.AppointmentDate + " has been successfully edited.");
                    this.SetupAppointmentsComboBox();

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

        private DateTime CombineDateAndTime()
        {
            DateTime Date = this.ApptDatePicker.Value.Date;
            DateTime Time = this.ApptTimePicker.Value;
            DateTime newDateTime = Date.Add(Time.TimeOfDay);
            return newDateTime;
        }

        /// <summary>
        /// Method that occurs when the Cancel Button is clicked. First checks if a given appointment can be cancelled. 
        /// If it is less than 24 hours away or in the past, it cannot.
        /// Then asks the user to confirm they are ok with cancellation. If they approve, the record status is set to C, and the UI refreshes
        /// , excluding the now cancelled appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            bool result = this.apptController.CheckCancellation(selectedAppointment);
            if (result)
            {
                DialogResult dialogresult = MessageBox.Show("Cancelling an appointment is permanent. Changes will not be saved. Are you sure you would like to cancel this appointment?", "Cancel Appointment", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    this.apptController.CancelAppointment(this.selectedAppointment);
                    MessageBox.Show("Appointment on " + this.selectedAppointment.AppointmentDate + " has been cancelled.");
                    this.SetupAppointmentsComboBox();
                }

            }
            else
            {
                MessageBox.Show("You cannot cancel an appointment less than 24 hours away.");
            }

           
        }

        private void Plus30Button_Click(object sender, EventArgs e)
        {
            DateTime tempTime = ApptTimePicker.Value;
            tempTime = tempTime.AddMinutes(30);

            this.ApptTimePicker.Value = tempTime;
        }

        private void Minus30Button_Click_1(object sender, EventArgs e)
        {
            DateTime tempTime = ApptTimePicker.Value;
            tempTime = tempTime.AddMinutes(-30);

            this.ApptTimePicker.Value = tempTime;
        }
    }
}
