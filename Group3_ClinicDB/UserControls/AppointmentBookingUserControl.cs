using System;
using System.Windows.Forms;
using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.UserControls
{
    public partial class AppointmentBookingUserControl : UserControl
    {

        private AppointmentController apptController;
        private DoctorController doctorController;

        public AppointmentBookingUserControl()
        {
            InitializeComponent();
            this.apptController = new AppointmentController();
            this.PatientApptList.DataSource = this.apptController.GetAppointmentsByPatient(1);   //TESTING THE DAL WITH PATIENT 1
            this.doctorController = new DoctorController();
            this.InitializeDoctorComboBox();
        }

        private void CreateApptButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.PatientID = 1;
            appointment.DoctorID = 1;
            appointment.AppointmentDate = this.CombineDateAndTime();
            appointment.Reason = this.ReasonRichText.Text;
            appointment.Status = "A";

            this.apptController.AddAppointment(appointment);
            this.PatientApptList.DataSource = this.apptController.GetAppointmentsByPatient(1);  //TESTING THE DAL WITH PATIENT 1


        }

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


    }
}
