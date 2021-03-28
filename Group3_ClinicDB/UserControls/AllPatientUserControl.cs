using Group3_ClinicDB.Controller;
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
    public partial class AllPatientUserControl : UserControl
    {
        private readonly PatientController patientController;

        public AllPatientUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void InitPatients()
        {
            this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
        }

        private void AllPatientUserControlLoad(object sender, EventArgs e)
        {
            this.InitPatients();
        }

        private void AllPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitPatients();
        }
    }
}
