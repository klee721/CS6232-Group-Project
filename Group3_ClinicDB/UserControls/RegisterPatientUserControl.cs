using Group3_ClinicDB.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// UserControl whose purpose is to register(add) a patient object to the DB
    /// </summary>
    public partial class RegisterPatientUserControl : UserControl
    {
        private StateController stateController;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public RegisterPatientUserControl()
        {
            InitializeComponent();
            this.stateController = new StateController();
        }

        private void RegisterPatientUserControlLoad(object sender, EventArgs e)
        {
            this.genderComboBox.Items.Add("male");
            this.genderComboBox.Items.Add("female");
            this.genderComboBox.SelectedIndex = 0;

            //datetimepicker??
            this.stateComboBox.DataSource = this.stateController.GetStates();
            this.stateComboBox.DisplayMember = "stateCode";
            this.stateComboBox.SelectedIndex = 0;
        }

        private void Validations()
        {
            //parse snn and phone#
            //check ssn is 9 digits
            //check phone is 9 digits
            if (this.lastNameTextBox.Text.Equals(""))
            {
                this.lastNameErrorLabel.Visible = true;
                this.lastNameErrorLabel.ForeColor = Color.Red;
            }
            else if (this.firstNameTextBox.Text.Equals(""))
            {
                this.firstNameErrorLabel.Visible = true;
                this.firstNameErrorLabel.ForeColor = Color.Red;
            }
            else if (this.ssnTextBox.Text.Equals(""))
            {
                this.ssnErrorLabel.Visible = true;
                this.ssnErrorLabel.ForeColor = Color.Red;
            }
            else if (this.addressTextBox.Text.Equals(""))
            {
                this.address1ErrorLabel.Visible = true;
                this.address1ErrorLabel.ForeColor = Color.Red;
            }
            else if (this.cityTextBox.Text.Equals(""))
            {
                this.cityErrorLabel.Visible = true;
                this.cityErrorLabel.ForeColor = Color.Red;
            }
            else if (this.zipCodeTextBox.Text.Equals(""))
            {
                this.zipCodeErrorLabel.Visible = true;
                this.zipCodeErrorLabel.ForeColor = Color.Red;
            }
            else if (this.phoneNumberTextBox.Text.Equals(""))
            {
                this.phoneNumberErrorLabel.Visible = true;
                this.phoneNumberErrorLabel.ForeColor = Color.Red;
            }
            else
            {
                this.registrationSuccessMessage.Visible = true;
            }
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            this.Validations();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
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
            this.registrationSuccessMessage.Visible = false;
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
            this.registrationSuccessMessage.Visible = false;
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
            this.registrationSuccessMessage.Visible = false;
        }

        private void ResetFirstNameError()
        {
            this.firstNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.ForeColor = Color.Black;
            this.registrationSuccessMessage.Visible = false;
        }

        private void ResetSsnError()
        {
            this.ssnErrorLabel.Visible = false;
            this.ssnErrorLabel.ForeColor = Color.Black;
            this.registrationSuccessMessage.Visible = false;
        }

        private void ResetAddress1Error()
        {
            this.address1ErrorLabel.Visible = false;
            this.address1ErrorLabel.ForeColor = Color.Black;
            this.registrationSuccessMessage.Visible = false;
        }

        private void ResetCityError()
        {
            this.cityErrorLabel.Visible = false;
            this.cityErrorLabel.ForeColor = Color.Black;
            this.registrationSuccessMessage.Visible = false;
        }

        private void ResetZipCodeError()
        {
            this.zipCodeErrorLabel.Visible = false;
            this.zipCodeErrorLabel.ForeColor = Color.Red;
            this.registrationSuccessMessage.Visible = false;
        }

        private void ResetPhoneError()
        {
            this.phoneNumberErrorLabel.Visible = false;
            this.phoneNumberErrorLabel.ForeColor = Color.Red;
            this.registrationSuccessMessage.Visible = false;
        }
    }
}
