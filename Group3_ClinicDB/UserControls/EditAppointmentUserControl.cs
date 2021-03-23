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

            this.appointmentList = this.apptController.GetAppointmentsByPatient(1);
            this.SetupAppointmentsComboBox();
            this.SetupDoctorsComboBox();

        }


        private void ApptSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillOutForm();
            this.SetupAppointmentsComboBox();
        }

        private void SetupAppointmentsComboBox()
        {
            this.ApptSelectComboBox.DataSource = appointmentList;  //TESTING DAL WITH PATIENT 1
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
            this.ApptTimePicker.Value = DateTime.Now.Date;
            int index = (int)this.ApptSelectComboBox.SelectedValue;
            this.selectedAppointment = this.appointmentList.Find(apt => apt.ID == index);

            this.ApptDatePicker.Value = selectedAppointment.AppointmentDate.Date;
            this.ApptTimePicker.Value += selectedAppointment.AppointmentDate.TimeOfDay;
            this.DoctorComboBox.SelectedValue = selectedAppointment.DoctorID;
            this.ReasonRichText.Text = selectedAppointment.Reason;


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            bool result = this.apptController.CheckCancellation(selectedAppointment);
            if (result)
            {
                DialogResult dialogresult = MessageBox.Show("Cancelling an appointment is permanent. Are you sure you would like to cancel this appointment?", "Cancel Appointment", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {



                    this.SetupAppointmentsComboBox();
                }

            }
            else
            {
                MessageBox.Show("You cannot cancel an appointment less than 24 hours away.");
            }

           
        }
    }
}
