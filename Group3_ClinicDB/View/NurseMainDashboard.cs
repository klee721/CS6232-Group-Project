using System;
using Group3_ClinicDB.Model;
using System.Windows.Forms;

namespace Group3_ClinicDB.View
{
    public partial class NurseMainDashboard : Form
    {
        public NurseMainDashboard(User user)
        {
            InitializeComponent();
            this.LoggedInTextBox.Text = user.userName;
        }

        private void RefreshContent(object sender, EventArgs e)
        {
            this.editAppointmentUserControl1.SetupAppointmentsComboBox();
        }
    }
}
