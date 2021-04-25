using System;
using System.Collections.Generic;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.Controller;
using System.Drawing;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class EditNurseUsercontrol : UserControl
    {
        PersonController personController;
        NurseController nurseController;
        StateController stateController;

        int storedNurseID;
        int storedPersonID;

        Person storedNurse;

        private int genderIndex;
        private int stateIndex;


        public EditNurseUsercontrol()
        {
            InitializeComponent();
            this.nurseController = new NurseController();
            this.personController = new PersonController();
            this.stateController = new StateController();
            this.storedNurseID = 0;
            this.storedNurse = null;
            this.LockEditNurse();
            this.InitEditNurse();
        }

        private void InitEditNurse()
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

                foreach (State state in this.stateController.GetStates())
                {
                    this.stateComboBox.Items.Add(state.StateCode);
                }
                this.stateComboBox.SelectedIndex = 0;

                this.genderComboBox.Items.Clear();
                this.genderComboBox.Items.Add("Male");
                this.genderComboBox.Items.Add("Female");

                this.dobDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
                this.dobDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);
            }

        }

        public void ClearModule()
        {
            this.storedNurseID = 0;
            this.storedNurse = null;
            this.NurseIDTextBox.Text = "";
            this.Clear();
            this.LockEditNurse();
        }

        private void LockEditNurse()
        {
            this.firstNameTextBox.Enabled = false;
            this.lastNameTextBox.Enabled = false;
            this.dobDateTimePicker.Enabled = false;
            this.genderComboBox.Enabled = false;
            this.ssnTextBox.Enabled = false;
            this.addressTextBox.Enabled = false;
            this.address2TextBox.Enabled = false;
            this.cityTextBox.Enabled = false;
            this.stateComboBox.Enabled = false;
            this.zipCodeTextBox.Enabled = false;
            this.phoneNumberTextBox.Enabled = false;
            this.clearButton.Enabled = false;
            this.updateButton.Enabled = false;
        }

        private void OpenEditNurse()
        {
            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.dobDateTimePicker.Enabled = true;
            this.genderComboBox.Enabled = true;
            this.ssnTextBox.Enabled = true;
            this.addressTextBox.Enabled = true;
            this.address2TextBox.Enabled = true;
            this.cityTextBox.Enabled = true;
            this.stateComboBox.Enabled = true;
            this.zipCodeTextBox.Enabled = true;
            this.phoneNumberTextBox.Enabled = true;
            this.clearButton.Enabled = true;
            this.updateButton.Enabled = true;
        }


        private void SearchNurseButton_Click(object sender, EventArgs e)
        {

            if (NurseIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Nurse ID number.");
                return;
            }

            int result;
            Nurse newNurse = new Nurse();

            if (Int32.TryParse(NurseIDTextBox.Text, out result))
            {
                int checkEmployee = this.nurseController.GetNurseByID(result);
                if (checkEmployee != 0)
                {
                    this.storedNurseID = result;

                    this.storedPersonID = this.nurseController.GetNurseByID(result);
                    this.storedNurse = this.personController.GetPersonDataById(this.storedPersonID);

                    this.OpenEditNurse();
                    this.PopulateFields();

                }
                else
                {
                    MessageBox.Show("No Nurses found.");
                    this.LockEditNurse();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Nurse ID number.");
                this.LockEditNurse();
            }
        }

        private void PopulateFields()
        {
            this.genderIndex = genderComboBox.Items.IndexOf(storedNurse.Gender);
            this.stateIndex = stateComboBox.Items.IndexOf(storedNurse.State);

            this.firstNameTextBox.Text = storedNurse.FirstName;
            this.lastNameTextBox.Text = storedNurse.LastName;
            this.dobDateTimePicker.Value = storedNurse.DateOfBirth;
            this.genderComboBox.SelectedIndex = this.genderIndex;
            this.ssnTextBox.Text = storedNurse.Ssn;
            this.addressTextBox.Text = storedNurse.Address1;
            this.address2TextBox.Text = storedNurse.Address2;
            this.cityTextBox.Text = storedNurse.City;
            this.stateComboBox.SelectedIndex = this.stateIndex;
            this.zipCodeTextBox.Text = storedNurse.ZipCode;
            this.phoneNumberTextBox.Text = storedNurse.PhoneNumber;

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
                        Person updatedPerson = new Person(firstName, lastName, dob, gender, ssn, address1, address2, city, state, zipCode, phoneNumber);

                        if (ssn != this.storedNurse.Ssn)
                        {
                            
                            if (this.personController.SsnExists(updatedPerson))
                            {
                                if (MessageBox.Show("The given SSN already exists",
                                                                             "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    this.ssnErrorLabel.Text = "This social security number already exists";
                                    this.ssnErrorLabel.Visible = true;
                                    this.ssnErrorLabel.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                this.Updates(updatedPerson);
                            }
                        }
                        else
                        {
                            this.Updates(updatedPerson);
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

        private void Updates(Person updatedPerson)
        {
            if (this.personController.UpdateNurse(storedPersonID, updatedPerson))
            {
                MessageBox.Show("Nurse data update successful");
                this.Clear();
                this.LockEditNurse();

            }
            else
            {
                this.updateSuccessMessage.Text = "Nurse update unsuccessful. Something has gone wrong.";
                this.updateSuccessMessage.Visible = true;
                this.updateSuccessMessage.ForeColor = Color.Red;
                this.Clear();
                this.LockEditNurse();
            }

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

            this.ResetLastNameError();
            this.ResetFirstNameError();
            this.ResetSsnError();
            this.ResetAddress1Error();
            this.ResetCityError();
            this.ResetZipCodeError();
            this.ResetPhoneError();

            this.LockEditNurse();
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

        private void Address2TextBoxTextChanged(object sender, EventArgs e)
        {
            this.updateSuccessMessage.Visible = false;
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.UpdateValidations();
        }
    }
}
