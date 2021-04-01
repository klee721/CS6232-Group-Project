using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
using System.Drawing;
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
        Patient oldPatient;
        Patient newPatient;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public EditPatientUserControl()
        {
            InitializeComponent();
            this.stateController = new StateController();
            this.personController = new PersonController();
            this.patientController = new PatientController();
            this.oldPatient = null;
            this.newPatient = null;
        }

        private void InitEditPatient()
        {
            if (this.stateController.GetStates().Count == 0)
            {
                this.stateErrorLabel.Visible = true;
                this.stateErrorLabel.ForeColor = Color.Red;
                this.updateButton.Enabled = false;
                this.clearButton.Enabled = false;
            }
            else
            {
                this.stateErrorLabel.Visible = false;
                this.updateButton.Enabled = true;
                this.clearButton.Enabled = true;

                this.stateComboBox.DataSource = this.stateController.GetStates();
                this.stateComboBox.DisplayMember = "stateCode";

                this.genderComboBox.Items.Add("Male");
                this.genderComboBox.Items.Add("Female");
                this.dobDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
                this.dobDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);

                this.Clear();
            }
        }

        private void EditPatientUserControlLoad(object sender, System.EventArgs e)
        {
            this.InitEditPatient();
        }

        private void EditPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitEditPatient();
        }

        private void Validations()
        {
            if (this.lastNameTextBox.Text.Equals(""))
            {
                this.lastNameErrorLabel.Text = "Last name information missing";
                this.lastNameErrorLabel.Visible = true;
                this.lastNameErrorLabel.ForeColor = Color.Red;
            }
            if (this.firstNameTextBox.Text.Equals(""))
            {
                this.firstNameErrorLabel.Text = "First name information missing";
                this.firstNameErrorLabel.Visible = true;
                this.firstNameErrorLabel.ForeColor = Color.Red;
            }
            if (this.ssnTextBox.Text.Length != 9)
            {
                this.ssnErrorLabel.Text = "Social security number must contain exactly nine digits";
                this.ssnErrorLabel.Visible = true;
                this.ssnErrorLabel.ForeColor = Color.Red;
            }
            if (this.addressTextBox.Text.Equals(""))
            {
                this.address1ErrorLabel.Visible = true;
                this.address1ErrorLabel.ForeColor = Color.Red;
            }
            if (this.cityTextBox.Text.Equals(""))
            {
                this.cityErrorLabel.Visible = true;
                this.cityErrorLabel.ForeColor = Color.Red;
            }
            if (this.zipCodeTextBox.Text.Length != 5)
            {
                this.zipCodeErrorLabel.Visible = true;
                this.zipCodeErrorLabel.ForeColor = Color.Red;
            }
            if (this.phoneNumberTextBox.Text.Length != 10)
            {
                this.phoneNumberErrorLabel.Visible = true;
                this.phoneNumberErrorLabel.ForeColor = Color.Red;
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            this.Validations();
        }
        private void Clear()
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.dobDateTimePicker.Value = DateTime.Now.Date.AddDays(-2);
            this.genderComboBox.SelectedIndex = 0;
            this.ssnTextBox.Text = "";
            this.addressTextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = 0;
            this.zipCodeTextBox.Text = "";
            this.phoneNumberTextBox.Text = "";

            this.ResetLastNameError();
            this.ResetFirstNameError();
            this.ResetSsnError();
            this.ResetAddress1Error();
            this.ResetCityError();
            this.ResetZipCodeError();
            this.ResetPhoneError();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void LastNameTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetLastNameError();
        }

        private void FirstNameTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetFirstNameError();
        }

        private void GenderComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateSuccessMessage.Visible = false;
        }

        private void SsnTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetSsnError();
        }

        private void AddressTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetAddress1Error();
        }

        private void CityTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetCityError();
        }

        private void StateComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateSuccessMessage.Visible = false;
        }

        private void ZipCodeTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetZipCodeError();
        }

        private void PhoneNumberTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetPhoneError();
        }

        private void ResetLastNameError()
        {
            this.lastNameErrorLabel.Visible = false;
            this.lastNameErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
        }

        private void ResetFirstNameError()
        {
            this.firstNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
        }

        private void ResetSsnError()
        {
            this.ssnErrorLabel.Visible = false;
            this.ssnErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
        }

        private void ResetAddress1Error()
        {
            this.address1ErrorLabel.Visible = false;
            this.address1ErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
        }

        private void ResetCityError()
        {
            this.cityErrorLabel.Visible = false;
            this.cityErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
        }

        private void ResetZipCodeError()
        {
            this.zipCodeErrorLabel.Visible = false;
            this.zipCodeErrorLabel.ForeColor = Color.Red;
            this.updateSuccessMessage.Visible = false;
        }

        private void ResetPhoneError()
        {
            this.phoneNumberErrorLabel.Visible = false;
            this.phoneNumberErrorLabel.ForeColor = Color.Red;
            this.updateSuccessMessage.Visible = false;
        }
    }
}
