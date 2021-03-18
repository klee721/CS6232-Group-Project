using System;
using System.Drawing;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class RegisterPatientUserControl : UserControl
    {
        public RegisterPatientUserControl()
        {
            InitializeComponent();
        }

        private void RegisterPatientUserControlLoad(object sender, EventArgs e)
        {
            this.genderComboBox.Items.Add("male");
            this.genderComboBox.Items.Add("female");
            this.genderComboBox.Items.Add("N/A");
            this.genderComboBox.SelectedIndex = this.genderComboBox.Items.Count - 1;

            //DAL for states table
            //DAL for adding patient
            this.stateComboBox.Items.Add("N/A");
            this.stateComboBox.SelectedIndex = this.stateComboBox.Items.Count - 1;
        }

        private void Validations()
        {
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
            else if (this.genderComboBox.SelectedIndex == this.genderComboBox.Items.Count - 1)
            {
                this.genderErrorLabel.Visible = true;
                this.genderErrorLabel.ForeColor = Color.Red;
            }
            else if (this.ssnTextBox.Text.Equals(""))
            {
                this.ssnErrorLabel.Visible = true;
                this.ssnErrorLabel.ForeColor = Color.Red;
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
            this.genderComboBox.SelectedIndex = this.genderComboBox.Items.Count - 1;
            this.ssnTextBox.Text = "";
            this.addressTextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = this.stateComboBox.Items.Count - 1;
            this.zipCodeTextBox.Text = "";
            this.phoneNumberTextBox.Text = "";

            this.ResetLastNameError();
            this.ResetFirstNameError();
            this.ResetGenderError();
            this.ResetSsnError();
            this.ResetAddress1Error();
            this.ResetCityError();
            this.ResetStateError();
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
            this.ResetGenderError();
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
            this.ResetStateError();
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
        }

        private void ResetFirstNameError()
        {
            this.firstNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.ForeColor = Color.Black;
        }

        private void ResetGenderError() 
        {
            this.genderErrorLabel.Visible = false;
            this.genderErrorLabel.ForeColor = Color.Black;
        }

        private void ResetSsnError()
        {
            this.ssnErrorLabel.Visible = false;
            this.ssnErrorLabel.ForeColor = Color.Black;
        }

        private void ResetAddress1Error()
        {
            this.address1ErrorLabel.Visible = false;
            this.address1ErrorLabel.ForeColor = Color.Black;
        }

        private void ResetCityError()
        {
            this.cityErrorLabel.Visible = false;
            this.cityErrorLabel.ForeColor = Color.Black;
        }

        private void ResetStateError()
        {
            this.stateErrorLabel.Visible = false;
            this.stateErrorLabel.ForeColor = Color.Red;
        }

        private void ResetZipCodeError()
        {
            this.zipCodeErrorLabel.Visible = false;
            this.zipCodeErrorLabel.ForeColor = Color.Red;
        }

        private void ResetPhoneError()
        {
            this.phoneNumberErrorLabel.Visible = false;
            this.phoneNumberErrorLabel.ForeColor = Color.Red;
        }
    }
}
