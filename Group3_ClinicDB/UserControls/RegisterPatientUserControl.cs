using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
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
        private readonly StateController stateController;
        private readonly PersonController personController;
        private readonly PatientController patientController;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public RegisterPatientUserControl()
        {
            InitializeComponent();
            this.stateController = new StateController();
            this.personController = new PersonController();
            this.patientController = new PatientController();
        }

        private void InitRegisterPatient()
        {
            if(this.stateController.GetStates().Count == 0)
            {
                this.stateErrorLabel.Visible = true;
                this.stateErrorLabel.ForeColor = Color.Red;
                this.registerButton.Enabled = false;
                this.clearButton.Enabled = false;
            } else
            {
                this.stateErrorLabel.Visible = false;
                this.registerButton.Enabled = true;
                this.clearButton.Enabled = true;

                this.stateComboBox.DataSource = this.stateController.GetStates();
                this.stateComboBox.DisplayMember = "stateCode";

                this.genderComboBox.Items.Add("male");
                this.genderComboBox.Items.Add("female");
                this.dobDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
                this.dobDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);
                this.Clear();
            }  
        }

        private void RegisterPatientUserControlLoad(object sender, EventArgs e)
        {
            this.InitRegisterPatient();
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
            
            if (!this.lastNameTextBox.Text.Equals("") && !this.firstNameTextBox.Text.Equals("") 
                && this.ssnTextBox.Text.Length == 9 && !this.addressTextBox.Text.Equals("") 
                && !this.cityTextBox.Text.Equals("") && this.zipCodeTextBox.Text.Length == 5 
                && this.phoneNumberTextBox.Text.Length == 10)
            {
                try
                {
                    long ssnLong = Convert.ToInt64(this.ssnTextBox.Text);
                    try
                    {
                        long zipCodeLong = Convert.ToInt64(this.zipCodeTextBox.Text);
                        try
                        {
                            long phoneNumberLong = Convert.ToInt64(this.phoneNumberTextBox.Text);

                            string firstName = this.firstNameTextBox.Text;
                            string lastName = this.lastNameTextBox.Text;
                            DateTime dob = this.dobDateTimePicker.Value;
                            string ssn = this.ssnTextBox.Text;
                            string gender = this.genderComboBox.SelectedItem.ToString();
                            string address1 = this.addressTextBox.Text;
                            string address2 = this.address2TextBox.Text;
                            string city = this.cityTextBox.Text;
                            string state = this.stateController.GetStates()[this.stateComboBox.SelectedIndex].StateCode;
                            string zipCode = this.zipCodeTextBox.Text;
                            string phoneNumber = this.phoneNumberTextBox.Text;

                            Person person = new Person(firstName, lastName, dob, gender, ssn,
                                                        address1, address2, city, state, zipCode, phoneNumber);

                            if (this.personController.GetPersonId(person) != 0)
                            {
                                this.patientController.AddPatient(this.personController.GetPersonId(person));
                                this.registrationSuccessMessage.Visible = true;
                            } else
                            {
                                if (!this.personController.SsnExists(person))
                                {
                                    this.personController.AddPerson(person);
                                    this.patientController.AddPatient(this.personController.GetPersonId(person));
                                    this.registrationSuccessMessage.Visible = true;
                                } else
                                {
                                    this.ssnErrorLabel.Text = "This social security number already exists";
                                    this.ssnErrorLabel.Visible = true;
                                    this.ssnErrorLabel.ForeColor = Color.Red;
                                }
                            }  
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Phone number can only contain whole numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.phoneNumberErrorLabel.Visible = true;
                            this.phoneNumberErrorLabel.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Zipcode can only contain whole numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.zipCodeErrorLabel.Visible = true;
                        this.zipCodeErrorLabel.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Social security number can only contain whole numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ssnErrorLabel.Visible = true;
                    this.ssnErrorLabel.ForeColor = Color.Red;
                }
            }
        }

        private void RegisterButtonClick(object sender, EventArgs e)
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

        private void RegisterPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitRegisterPatient();
        }
    }
}
