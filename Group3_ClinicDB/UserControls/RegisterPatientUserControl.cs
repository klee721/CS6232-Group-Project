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
    public partial class RegisterPatientUserControl : UserControl
    {
        public RegisterPatientUserControl()
        {
            InitializeComponent();
        }

        private void RegisterPatientUserControl_Load(object sender, EventArgs e)
        {
            this.genderComboBox.Items.Add("N/A");
            this.genderComboBox.SelectedIndex = this.genderComboBox.Items.Count - 1;

            this.stateComboBox.Items.Add("N/A");
            this.stateComboBox.SelectedIndex = this.stateComboBox.Items.Count - 1;
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            this.registrationSuccessMessage.Visible = true;
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.genderComboBox.SelectedIndex = this.genderComboBox.Items.Count - 1;
            this.ssnTextBox.Text = "";
            this.addressTextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = this.stateComboBox.Items.Count - 1;
            this.zipCodeTextBox.Text = "";
            this.phoneNumberTextBox.Text = "";
        }
    }
}
