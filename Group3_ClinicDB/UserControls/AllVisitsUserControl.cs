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
    public partial class AllVisitsUserControl : UserControl
    {

        public Patient patient;
        /// <summary>
        /// The constructor
        /// </summary>

        public AllVisitsUserControl()
        {
            InitializeComponent();
            this.controller = new VisitsController();
            this.Enabled = false;

        }

        private readonly VisitsController controller;

 
        private void AllVisitsUserControl_Load(object sender, EventArgs e)
        {

            //visitsDALDataGridView.DataSource = null;
            this.load_visits();
        }

        public void load_visits()
        {
            if (this.patient != null)
            {
                visitsDALDataGridView.DataSource = this.controller.GetVisitsByPatient(this.patient.Id);
            }
            else
            {
                visitsDALDataGridView.DataSource = this.controller.GetVisits();
            }
        }

        /// <summary>
        /// Method to retrieve a patient object from the parent form. This enables the module and loads the patient data
        /// </summary>
        /// <param name="selectedPatient">a Patient object to use in appointment booking</param>
        public void GetPatient(Patient selectedPatient)
        {
            this.patient = selectedPatient;
            this.Enabled = true;
            this.load_visits();
        }

    }
}
