using Group3_ClinicDB.Controller;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// UserControl whose purpose is to edit a patient object in the DB
    /// </summary>
    public partial class EditPatientUserControl : UserControl
    {
        private readonly StateController stateController;
        private readonly PersonController personController;
        private readonly PatientController patientController;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public EditPatientUserControl()
        {
            InitializeComponent();
            this.stateController = new StateController();
            this.personController = new PersonController();
            this.patientController = new PatientController();
        }

        private void InitEditPatient()
        {

        }

        private void EditPatientUserControlLoad(object sender, System.EventArgs e)
        {
            this.InitEditPatient();
        }
    }
}
