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
        public UpdateVisitUserControl()
        {
            InitializeComponent();
            this.visitController = new VisitsController();
            this.appointmentController = new AppointmentController();
            this.visit = new Visits();
        }

        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
           // var appointment_id = this.appointment_idComboBox.SelectedValue;
            var nurseId = 1;

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
               // visit.appointment_id = (int)appointment_id;
                visit.bloodPressureDiastolic = bloodPressureDiastolic;
                visit.bloodPressureSystolic = bloodPressureSystolic;
                visit.bodyTemparature = bodyTemparature;
                visit.finalDiagnose = finalDiagnose;
                visit.height = height;
                visit.initialDiagnose = initialDiagnose;
                visit.nurseId = nurseId;
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


        }
    }
}
