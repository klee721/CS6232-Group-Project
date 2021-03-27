using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// UserControl whose purpose is to display all patient objects from the DB
    /// </summary>
    public partial class AllPatientUserContol : UserControl
    {
        private readonly PatientController patientController;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public AllPatientUserContol()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void InitPatients()
        {
           this.dataGridView1.DataSource = this.patientController.GetAllPatients();
        }

        private void AllPatientUserContolLoad(object sender, EventArgs e)
        {
            this.InitPatients();
        }

        private void AllPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitPatients();
        }
    }
}
