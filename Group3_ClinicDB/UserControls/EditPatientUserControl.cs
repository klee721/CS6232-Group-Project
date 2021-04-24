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
        private Patient oldPatient;
        private Patient newPatient;
        private int genderIndex;
        private int stateIndex;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public EditPatientUserControl()
        {
            InitializeComponent();
            this.stateController = new StateController();
            this.personController = new PersonController();
            this.oldPatient = null;
            this.newPatient = null;
        }

        /// <summary>
        /// Sets the patients to null
        /// Used on logout
        /// </summary>
        public void NullifyPatients()
        {
            this.oldPatient = null;
            this.newPatient = null;
        }

        /// <summary>
        /// Retrieves the patient that has been searched
        /// </summary>
        /// <param name="searchedPatient">The patient that has been searched</param>
        /// <returns>The patient that has been searched</returns>
        public Patient GetPatient(Patient searchedPatient)
        {
             this.oldPatient = new Patient(searchedPatient.Id, searchedPatient.PersonsId, searchedPatient.FirstName,
                                                searchedPatient.LastName, searchedPatient.DateOfBirth, searchedPatient.Gender,
                                                searchedPatient.SSN, searchedPatient.Address1, searchedPatient.Address2,
                                                searchedPatient.City, searchedPatient.State, searchedPatient.ZipCode,
                                                searchedPatient.PhoneNumber);

            this.InitEditPatient();

            return this.oldPatient;
        }

        private void EditPatientUserControlLoad(object sender, EventArgs e)
        {
            this.InitEditPatient();
        }

        private void EditPatientUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitEditPatient();
        }

        private void InitEditPatient()
        {
            if (this.stateController.GetStates().Count == 0)
            {
                this.stateErrorLabel.Visible = true;
                this.stateErrorLabel.ForeColor = Color.Red;
                this.updateButton.Enabled = false;
                this.clearButton.Enabled = false;
                this.deleteButton.Enabled = false;
                this.editButton.Enabled = false;
            }
            else
            {
                this.stateErrorLabel.Visible = false; 

                foreach(State state in this.stateController.GetStates())
                {
                    this.stateComboBox.Items.Add(state.StateCode);
                }
                this.stateComboBox.SelectedIndex = 0;

                this.genderComboBox.Items.Clear();
                this.genderComboBox.Items.Add("Male");
                this.genderComboBox.Items.Add("Female");

                this.dobDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
                this.dobDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);

                if (this.oldPatient != null)
                {
                    this.deleteButton.Enabled = true;
                    this.editButton.Enabled = true;
                    this.PopulateFields(this.oldPatient);
                    this.DisableFields(true);
                    this.Enabled = true;
                }
                else
                {
                    this.Clear();
                    this.Enabled = false;
                }
            }
        }

        private void PopulateFields(Patient patient)
        {
            this.genderIndex = genderComboBox.Items.IndexOf(patient.Gender);
            this.stateIndex = stateComboBox.Items.IndexOf(patient.State);

            this.lastNameTextBox.Text = patient.LastName;
            this.firstNameTextBox.Text = patient.FirstName;
            this.dobDateTimePicker.Value = patient.DateOfBirth;
            this.genderComboBox.SelectedIndex = this.genderIndex;
            this.ssnTextBox.Text = patient.SSN;
            this.addressTextBox.Text = patient.Address1;
            this.address2TextBox.Text = patient.Address2;
            this.cityTextBox.Text = patient.City;
            this.stateComboBox.SelectedIndex = this.stateIndex;
            this.zipCodeTextBox.Text = patient.ZipCode;
            this.phoneNumberTextBox.Text = patient.PhoneNumber;
        }

        private void DisableFields(bool disable)
        {
            if (disable)
            {
                this.lastNameTextBox.ReadOnly = true;
                this.firstNameTextBox.ReadOnly = true;
                this.dobDateTimePicker.Enabled = false;
                this.genderComboBox.Enabled = false;
                this.ssnTextBox.ReadOnly = true;
                this.addressTextBox.ReadOnly = true;
                this.address2TextBox.ReadOnly = true;
                this.stateComboBox.Enabled = false;
                this.cityTextBox.ReadOnly = true;
                this.zipCodeTextBox.ReadOnly = true;
                this.phoneNumberTextBox.ReadOnly = true;
                this.updateButton.Enabled = false;
                this.clearButton.Enabled = false;
            }
            else
            {
                this.lastNameTextBox.ReadOnly = false;
                this.firstNameTextBox.ReadOnly = false;
                this.dobDateTimePicker.Enabled = true;
                this.genderComboBox.Enabled = true;
                this.ssnTextBox.ReadOnly = false;
                this.addressTextBox.ReadOnly = false;
                this.address2TextBox.ReadOnly = false;
                this.stateComboBox.Enabled = true;
                this.cityTextBox.ReadOnly = false;
                this.zipCodeTextBox.ReadOnly = false;
                this.phoneNumberTextBox.ReadOnly = false;
                this.updateButton.Enabled = true;
                this.clearButton.Enabled = true;
            }
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            this.deleteButton.Enabled = false;
            this.DisableFields(false);
        }

        private void DeleteValidations()
        {
            Console.WriteLine("working");
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            this.DeleteValidations();
        }

        private void UpdateValidations()
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
                if (this.firstNameTextBox.Text.Equals(this.oldPatient.FirstName) && this.lastNameTextBox.Text.Equals(this.oldPatient.LastName) &&
                    this.dobDateTimePicker.Value == this.oldPatient.DateOfBirth && this.genderComboBox.SelectedIndex == this.genderIndex &&
                    this.ssnTextBox.Text.Equals(this.oldPatient.SSN) && this.addressTextBox.Text.Equals(this.oldPatient.Address1) &&
                    this.address2TextBox.Text.Equals(this.oldPatient.Address2) && this.cityTextBox.Text.Equals(this.oldPatient.City) &&
                    this.stateComboBox.SelectedIndex == this.stateIndex && this.zipCodeTextBox.Text.Equals(this.oldPatient.ZipCode) &&
                    this.phoneNumberTextBox.Text.Equals(this.oldPatient.PhoneNumber))
                {
                    MessageBox.Show("Update Failed. You have not edited any information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.updateSuccessMessage.Text = "No information edited";
                    this.updateSuccessMessage.Visible = true;
                    this.updateSuccessMessage.ForeColor = Color.Red;
                } else
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

                                if (ssn != this.oldPatient.SSN)
                                {
                                    Person person = new Person(firstName, lastName, dob, gender, ssn,
                                                        address1, address2, city, state, zipCode, phoneNumber);
                                    if (this.personController.SsnExists(person))
                                    {
                                        if (MessageBox.Show("The given SSN already exists",
                                             "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                        {
                                            this.ssnErrorLabel.Text = "This social security number already exists";
                                            this.ssnErrorLabel.Visible = true;
                                            this.ssnErrorLabel.ForeColor = Color.Red;
                                        }
                                    } else
                                    {
                                        this.newPatient = new Patient(this.oldPatient.Id, this.oldPatient.PersonsId, firstName, lastName, dob, gender, ssn,
                                                                        address1, address2, city, state, zipCode, phoneNumber);
                                        this.Updates();
                                    }
                                }
                                else
                                {
                                    this.newPatient = new Patient(this.oldPatient.Id, this.oldPatient.PersonsId, firstName, lastName, dob, gender, ssn,
                                                                        address1, address2, city, state, zipCode, phoneNumber);
                                    this.Updates();
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
        }

        private void Updates()
        {
            if (this.personController.UpdatePerson(this.oldPatient, this.newPatient))
            {
                this.oldPatient = this.newPatient;
                this.newPatient = null;
                this.Clear();
                this.updateSuccessMessage.Text = "Patient Updated!";
                this.updateSuccessMessage.Visible = true;
                this.updateSuccessMessage.ForeColor = Color.Black;
            }
            else
            {
                this.updateSuccessMessage.Text = "Patient update not changed. Someone has changed the patient before you";
                this.updateSuccessMessage.Visible = true;
                this.updateSuccessMessage.ForeColor = Color.Red;
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            this.UpdateValidations();
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
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;

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
            this.deleteSuccessMessage.Visible = false;
        }

        private void SsnTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetSsnError();
        }

        private void AddressTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetAddress1Error();
        }

        private void Address2TextBoxTextChanged(object sender, EventArgs e)
        {
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }

        private void CityTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ResetCityError();
        }

        private void StateComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
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
            this.deleteSuccessMessage.Visible = false;
        }

        private void ResetFirstNameError()
        {
            this.firstNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }

        private void ResetSsnError()
        {
            this.ssnErrorLabel.Visible = false;
            this.ssnErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }

        private void ResetAddress1Error()
        {
            this.address1ErrorLabel.Visible = false;
            this.address1ErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }

        private void ResetCityError()
        {
            this.cityErrorLabel.Visible = false;
            this.cityErrorLabel.ForeColor = Color.Black;
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }

        private void ResetZipCodeError()
        {
            this.zipCodeErrorLabel.Visible = false;
            this.zipCodeErrorLabel.ForeColor = Color.Red;
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }

        private void ResetPhoneError()
        {
            this.phoneNumberErrorLabel.Visible = false;
            this.phoneNumberErrorLabel.ForeColor = Color.Red;
            this.updateSuccessMessage.Visible = false;
            this.deleteSuccessMessage.Visible = false;
        }
    }
}
