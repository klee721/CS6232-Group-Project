﻿using System;
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
        public Patient patient;

        public EditAppointmentUserControl()
        {
            InitializeComponent();
            this.apptController = new AppointmentController();
            this.doctorController = new DoctorController(); 
            this.selectedAppointment = new Appointment();
            this.appointmentList = new List<Appointment>();
          

            this.Enabled = false;

          
            
        }


        private void ApptSelectComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            this.ApptSelectComboBox_SelectedIndexChanged(sender, e);

        }


        private void ApptSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ApptSelectComboBox.SelectedIndex < 0)
            {
                return;
            }
            if (appointmentList.Count > 0)
            {
                this.FillOutForm();
            }
        
        }
         
        /// <summary>
        /// This function refreshes the Appointments stored in this combo box to account for New Appointments being created in other tabs
        /// </summary>
        public void SetupAppointmentsComboBox()
        {
            if (this.patient != null)
            {
                this.appointmentList = this.apptController.GetActiveAppointmentsByPatient(this.patient.Id);
                this.ApptSelectComboBox.DataSource = appointmentList;
                this.ApptSelectComboBox.DisplayMember = "AppointmentDate";
                this.ApptSelectComboBox.ValueMember = "ID";
            }
        }

        private void SetupDoctorsComboBox()
        {
            this.DoctorComboBox.DataSource = this.doctorController.GetAllDoctors();
            this.DoctorComboBox.DisplayMember = "LastName";
            this.DoctorComboBox.ValueMember = "DoctorID";
        }

        private void FillOutForm()
        {
            if (appointmentList.Count > 0)
            {
                if (this.ApptSelectComboBox.SelectedValue != null)
                {
                    this.EnableModule();
                    int result;
                    if (int.TryParse(this.ApptSelectComboBox.SelectedValue.ToString(), out result))
                    {
                        int aptNumber = int.Parse(this.ApptSelectComboBox.SelectedValue.ToString());
                        this.selectedAppointment = this.appointmentList.Find(apt => apt.ID == aptNumber);
                        this.ApptDatePicker.Value = selectedAppointment.AppointmentDate.Date;
                        this.ApptDatePicker.MinDate = DateTime.Now.Date;
                        this.ApptTimePicker.Value = DateTime.Now.Date;
                        this.ApptTimePicker.Value += selectedAppointment.AppointmentDate.TimeOfDay;
                        this.DoctorComboBox.SelectedValue = selectedAppointment.DoctorID;
                        this.ReasonRichText.Text = selectedAppointment.Reason;

                    }
                    else
                    {

                   
                    }
                }
            }
            else
            {
                this.LockModule();
                MessageBox.Show("Patient has no appointments.");
            }

        }





        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool updateResult = this.apptController.CheckCancellation(selectedAppointment);
            if (updateResult)
            {
                if (this.ReasonRichText.Text == "")
                {
                    MessageBox.Show("Please enter a reason for the appointment", "Reason Required");
                    return;
                }

                DateTime newAptTime = this.CombineDateAndTime();
                int doctorID = Int32.Parse(this.DoctorComboBox.SelectedValue.ToString());
                bool result = this.apptController.CheckUpdateAvailability(doctorID, this.selectedAppointment.AppointmentDate, newAptTime);

                if (result)
                {
                    DialogResult dialogresult = MessageBox.Show("Dr. " + this.DoctorComboBox.Text + " is available, please click OK to schedule.", "Availability Found", MessageBoxButtons.OKCancel);
                    if (dialogresult == DialogResult.OK)
                    {
                        Appointment appointment = new Appointment();
                        appointment.ID = selectedAppointment.ID;
                        appointment.PatientID = this.patient.Id;
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
            else
            {
                MessageBox.Show("You cannot edit an appointment less than 24 hours away.");
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

        private void LockModule()
        {
            this.ApptDatePicker.Enabled = false;
            this.ApptTimePicker.Enabled = false;
            this.Plus30Button.Enabled = false;
            this.Minus30Button.Enabled = false;
            this.ReasonRichText.Enabled = false;
            this.DoctorComboBox.Enabled = false;
            this.CancelButton.Enabled = false;
            this.ConfirmButton.Enabled = false;
        }

        private void EnableModule()
        {
            this.ApptDatePicker.Enabled = true;
            this.ApptTimePicker.Enabled = true;
            this.Plus30Button.Enabled = true;
            this.Minus30Button.Enabled = true;
            this.ReasonRichText.Enabled = true;
            this.DoctorComboBox.Enabled = true;
            this.CancelButton.Enabled = true;
            this.ConfirmButton.Enabled = true;
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

        /// <summary>
        /// Method to retrieve a pateint object from the parent form
        /// </summary>
        /// <param name="selectedPatient">a Patient object to be used in appointment editing</param>
        public void GetPatient(Patient selectedPatient)
        {
            this.patient = selectedPatient;
            this.Enabled = true;

            this.SetupAppointmentsComboBox();
            this.SetupDoctorsComboBox();
            
           
        }

        private void RefreshList(object sender, EventArgs e)
        {
            this.SetupAppointmentsComboBox();
        }
    }
}
