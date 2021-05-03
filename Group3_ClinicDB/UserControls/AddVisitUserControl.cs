﻿using System;
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

        public User loginUser;

        public List<Appointment> appointments;


        /// <summary>
        /// The constructor
        /// </summary>
        /// 
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.visitController = new VisitsController();
            this.appointmentController = new AppointmentController();
            this.nurseController = new NurseController();
            this.Enabled = false;
            this.loginUser = new User();
            this.confirmLabel.Text = "";
            this.appointments = new List<Appointment>();
        }

        /// <summary>
        /// Method to retrieve a patient object from the parent form. This enables the module and loads the patient data
        /// </summary>
        /// <param name="selectedPatient">a Patient object to use in appointment booking</param>
        public void GetPatient(Patient selectedPatient)
        {
            this.patient = selectedPatient;
            this.Enabled = true;
            this.Reset();
            this.RefreshAppointments();
        }

        /// <summary>
        /// Method to retrieve a patient object from the parent form. This enables the module and loads the nurse data
        /// </summary>
        /// <param name="loginUser">a Nurse user object to use in appointment booking</param>
        public void GetNurse(User loginNurseUser)
        {
            this.loginUser = loginNurseUser;
            this.nurseNameLabel.Text = loginNurseUser.firstName + " " + loginNurseUser.lastName;
        }

        /// <summary>
        /// Method to refresh appointments combo box
        /// </summary>
        /// 
        private void RefreshAppointments()
        {
            //appointment_idComboBox.Items.Clear();
            this.appointment_idComboBox.SelectedValue = "";
            //this.appointment_idComboBox.SelectedIndex = 0;
            //List<Appointment> appointments;


            try
            {
                //instead of using the following line of code, which couples the 
                //DAL with the view, we ask the controller to get the data for us 
                //so that the view does not have to know where the data comes from
                //(the line after the commented line)

                if (this.patient != null)
                {
                    appointments = this.appointmentController.GetOpenAppointmentsWithNoVisitsByPatient(this.patient.Id); //Added patient_id 1
                    appointment_idComboBox.Refresh();
                   // if (appointments.Count > 0)
                   // {

                        appointment_idComboBox.DisplayMember = "AppointmentDate";
                        appointment_idComboBox.ValueMember = "ID" ;
                        appointment_idComboBox.DataSource = appointments;

                   // }
                    //else
                    // {
                    //     MessageBox.Show("No appointments.");
                    


                    //}
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }

        /// <summary>
        /// Method to refresh Nurses combo box
        /// </summary>
        /// 
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

        private bool validations()
        {
            string errors = "Y";

    
       // if (string.IsNullOrEmpty(this.appointment_idComboBox.SelectedValue.ToString()))
                if (appointments.Count <= 0)
                {
                //MessageBox.Show("Weight is required.", "Error!");
                this.appointmentErrorLabel.Visible = true;
                errors = "N";
        //return;
    }
    else
    {
                this.appointmentErrorLabel.Visible = false;
            }
    if (string.IsNullOrEmpty(this.weightTextBox.Text.ToString()))
            {
                //MessageBox.Show("Weight is required.", "Error!");
                this.weightErrorLabel.Visible = true;
                errors = "N";
                //return;
            } else
            {
                this.weightErrorLabel.Visible = false;
            }

            if (string.IsNullOrEmpty(this.heightTextBox.Text.ToString()))
            {
                // MessageBox.Show("height is required.", "Error!");
                this.heightErrorLabel.Visible = true;
                errors = "N";
                // return;
            } else
            {
                this.heightErrorLabel.Visible = false;
            }

            if (string.IsNullOrEmpty(this.bloodPressureSystolicTextBox.Text.ToString()))
            {
                //MessageBox.Show("bloodPressureSystolic is required.", "Error!");
                //return;
                bpsErrorLabel.Visible = true;
                errors = "N";
            }
            else
            {
                this.bpsErrorLabel.Visible = false;
            }
            if (string.IsNullOrEmpty(this.bloodPressureDiastolicTextBox.Text.ToString()))
            {
                //MessageBox.Show("bloodPressureDiastolic is required.", "Error!");
                //return;
                bpdErrorLabel.Visible = true;
                errors = "N";
            }
            else
            {
                this.bpdErrorLabel.Visible = false;
            }
            if (string.IsNullOrEmpty(this.pulseTextBox.Text.ToString()))
            {
                //MessageBox.Show("pulse is required.", "Error!");
                //return;
                pulseErrorLabel.Visible = true;
                errors = "N";
            }
            else
            {
                this.pulseErrorLabel.Visible = false;
            }
            if (string.IsNullOrEmpty(this.bodyTemparatureTextBox.Text.ToString()))
            {
                //MessageBox.Show("bodyTemparature is required.", "Error!");
                //return;
                temparatureErrorlabel.Visible = true;
                errors = "N";
            }
            else
            {
                this.temparatureErrorlabel.Visible = false;
            }
            if (string.IsNullOrEmpty(this.initialDiagnoseTextBox.Text.ToString()))
            {
                //MessageBox.Show("initialDiagnose is required.", "Error!");
                //return;
                initialDiagnoseErrorLabel.Visible = true;
                errors = "N";
            }
            else
            {
                this.initialDiagnoseErrorLabel.Visible = false;
            }
            if (string.IsNullOrEmpty(this.symptomsTextBox.Text.ToString()))
            {
                //MessageBox.Show("initialDiagnose is required.", "Error!");
                //return;
                symptomsErrorlabel.Visible = true;
                errors = "N";
            }
            else
            {
                this.symptomsErrorlabel.Visible = false;
            }
            if (errors == "N")
            {
                MessageBox.Show("Input information is missing!!!!", "Error!");
                //return;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method for add click button or submit click button
        /// </summary>
        /// 

        private void AddButton_Click(object sender, EventArgs e)
        {
            var appointment_id = this.appointment_idComboBox.SelectedValue;
            //var nurseId = this.nurseComboBox.SelectedValue;
            var nurseId = this.loginUser.nurseID;
            int i = 0;
            decimal d = 0;
            if (!this.validations())
            {
                return;
            }
           
            try
            {
                d = decimal.Parse(this.weightTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Weight is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var weight = decimal.Parse(this.weightTextBox.Text.ToString());
            

            try
            {
                d = decimal.Parse(this.heightTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("height is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

           
            var height = decimal.Parse(this.heightTextBox.Text.ToString());

            
            try
            {
                d = decimal.Parse(this.bloodPressureSystolicTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("bloodPressureSystolic is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                

            }

            var bloodPressureSystolic = decimal.Parse(this.bloodPressureSystolicTextBox.Text.ToString());

            
            try
            {
                d = decimal.Parse(this.bloodPressureDiastolicTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("bloodPressureDiastolic is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            var bloodPressureDiastolic = decimal.Parse(this.bloodPressureDiastolicTextBox.Text.ToString());

            

            try
            {
                i = int.Parse(this.pulseTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("pulse is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var pulse = int.Parse(this.pulseTextBox.Text.ToString());

           
            
            try
            {
                d = decimal.Parse(this.bodyTemparatureTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("bodyTemparature is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var bodyTemparature = decimal.Parse(this.bodyTemparatureTextBox.Text.ToString());
            

            
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
                        this.Reset();
                    
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

        /// <summary>
        /// Method to load comboboxes on load
        /// </summary>
        /// 
        private void AddVisitUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshAppointments();
            this.RefreshNurses();


        }

        /// <summary>
        /// Method to load appointments on entering tab
        /// </summary>
        /// 
        private void AddVisitUserControl_Enter(object sender, EventArgs e)
        {
            this.Reset();
            this.RefreshAppointments();
            
        }

        /// <summary>
        /// Method to reset all values
        /// </summary>
        /// 
        private void Reset()
        {
            this.weightTextBox.Text = "";
            this.heightTextBox.Text = "";
            this.bloodPressureDiastolicTextBox.Text = "";
            this.bloodPressureSystolicTextBox.Text = "";
            this.bodyTemparatureTextBox.Text = "";
            this.pulseTextBox.Text = "";
            this.symptomsTextBox.Text = "";
            this.initialDiagnoseTextBox.Text = "";
            this.finalDiagnoseTextBox.Text = "";
            // this.confirmLabel.Text = "";
            //this.appointment_idComboBox.SelectedIndex = 0;
            initialDiagnoseErrorLabel.Visible = false;
            appointmentErrorLabel.Visible = false;
            bpdErrorLabel.Visible = false;
            bpsErrorLabel.Visible = false;
            pulseErrorLabel.Visible = false;
            temparatureErrorlabel.Visible = false;
            heightErrorLabel.Visible = false;
            weightErrorLabel.Visible = false;
            nurseErrorLabel.Visible = false;
            symptomsErrorlabel.Visible = false;
            this.RefreshAppointments();
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

    }
}
