using System;
using System.Windows.Forms;
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

        /// <summary>
        /// Constructor. Initializes instance variables and some UI elements
        /// </summary>
        public AppointmentBookingUserControl()
        {
            InitializeComponent();
            this.apptController = new AppointmentController();
            this.PatientApptList.DataSource = this.apptController.GetAppointmentsByPatient(1);   //TESTING THE DAL WITH PATIENT 1
            this.doctorController = new DoctorController();
            this.InitializeDoctorComboBox();
            this.ApptDatePicker.Value = DateTime.Now.Date;
             

        }
        /// <summary>
        /// Event when a user clicks Create. First verifies that the selected doctor is available for the selected date and time. If so, the user can confirm or back out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateApptButton_Click(object sender, EventArgs e)
        {
            DateTime newAptTime = this.CombineDateAndTime();
            int doctorID = Int32.Parse(this.DoctorComboBox.SelectedValue.ToString());
            bool result = this.apptController.CheckAvailability(doctorID, newAptTime);

            if (result)
            {
                DialogResult dialogresult = MessageBox.Show("Dr. " + this.DoctorComboBox.Text + " is available, please click OK to schedule.", "Availability Found", MessageBoxButtons.OKCancel);
                if (dialogresult == DialogResult.OK)
                {
                    Appointment appointment = new Appointment();
                    appointment.PatientID = 1;
                    appointment.DoctorID = Int32.Parse(this.DoctorComboBox.SelectedValue.ToString());
                    appointment.AppointmentDate = this.CombineDateAndTime();
                    appointment.Reason = this.ReasonRichText.Text;
                    appointment.Status = "A";
                    this.apptController.AddAppointment(appointment);
                    this.PatientApptList.DataSource = this.apptController.GetAppointmentsByPatient(1);  //TESTING THE DAL WITH PATIENT 1
                    this.ClearAll();
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

        private void ClearAll()
        {
            this.ReasonRichText.Text = "";
           
        }

        private void InitializeDoctorComboBox()
        {
            this.DoctorComboBox.DataSource = this.doctorController.GetAllDoctors();
            this.DoctorComboBox.DisplayMember ="LastName";
            this.DoctorComboBox.ValueMember = "DoctorID";
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
    }
}
