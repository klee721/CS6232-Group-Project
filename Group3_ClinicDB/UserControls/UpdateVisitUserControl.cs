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
    public partial class UpdateVisitUserControl : UserControl
    {

        private readonly VisitsController visitController;
        private readonly AppointmentController appointmentController;
        private Visits visit;
        public Patient patient;

        public UpdateVisitUserControl()
        {
            InitializeComponent();
            this.visitController = new VisitsController();
            this.appointmentController = new AppointmentController();
            this.visit = new Visits();
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

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
           // var appointment_id = this.appointment_idComboBox.SelectedValue;
            
            var initialDiagnose = this.initialDiagnoseTextBox.Text;
            var finalDiagnose = this.finalDiagnoseTextBox.Text;
            var symptoms = this.symptomsTextBox.Text;

            try
            {
                Visits newVisit = new Visits();
                newVisit.Id = visit.Id;
                newVisit.appointment_id = visit.appointment_id;
                newVisit.bloodPressureDiastolic = visit.bloodPressureDiastolic;
                newVisit.bloodPressureSystolic = visit.bloodPressureSystolic;
                newVisit.bodyTemparature = visit.bodyTemparature;
                newVisit.finalDiagnose = finalDiagnose;
                newVisit.initialDiagnose = initialDiagnose;
                newVisit.nurseId = visit.nurseId;
                newVisit.pulse = visit.pulse;
                newVisit.symptoms = visit.symptoms;
                newVisit.weight = visit.weight;
                newVisit.height = visit.height;
                
               
                
               
              
                    if (this.visitController.UpdateVisit(visit,newVisit))
                    {

                        this.confirmLabel.Text = "Visit updated successfully";
                    }
                    else
                    {
                        MessageBox.Show("Visit is not updated");
                    }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void GetVisitUserControl_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(this.visitTextBox.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Incident Id is not a valid number!!!!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
            this.getVisitDetails(id);
        }

        private void getVisitDetails(int visitID)
        {
            this.visitController.GetVisitsByID(visitID);
            try
            {
                this.visit = this.visitController.GetVisitsByID(visitID);
                if (string.IsNullOrEmpty(this.visit.symptoms))
                {
                    MessageBox.Show("There is no visit with the entered id.");
                    return;
                }

                this.weightTextBox.Text = visit.weight.ToString();
                this.heightTextBox.Text = visit.height.ToString();
                this.bodyTemparatureTextBox.Text = visit.bodyTemparature.ToString();
                this.pulseTextBox.Text = visit.pulse.ToString();
                this.symptomsTextBox.Text = visit.symptoms;
                this.nurseIdTextBox.Text = visit.nurseId.ToString();
                this.bloodPressureSystolicTextBox.Text = visit.bloodPressureSystolic.ToString();
                this.bloodPressureDiastolicTextBox.Text = visit.bloodPressureDiastolic.ToString();
                this.initialDiagnoseTextBox.Text = visit.initialDiagnose;
                this.finalDiagnoseTextBox.Text = visit.finalDiagnose;
                
                //this.clearButton.Enabled = true;
                this.getVisitButton.Enabled = false;
                this.visitTextBox.Enabled = false;
                this.updateButton.Enabled = true;
                this.clearButton.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.visit = new Visits();
            this.weightTextBox.Text = "";
            this.heightTextBox.Text = "";
            this.bodyTemparatureTextBox.Text = "";
            this.pulseTextBox.Text = "";
            this.symptomsTextBox.Text = "";
            this.nurseIdTextBox.Text = "";
            this.bloodPressureSystolicTextBox.Text = "";
            this.bloodPressureDiastolicTextBox.Text = "";
            this.initialDiagnoseTextBox.Text = "";
            this.finalDiagnoseTextBox.Text = "";
            this.visitTextBox.Text = "";
            this.updateButton.Enabled = false;
            this.clearButton.Enabled = false;
            this.getVisitButton.Enabled = true;
            this.visitTextBox.Enabled = true;
            this.confirmLabel.Text = "";

        }
    }
}
