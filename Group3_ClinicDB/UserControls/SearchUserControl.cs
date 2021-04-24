using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// UserControl whose purpose is to search for patients in the DB
    /// </summary>
    public partial class SearchUserControl : UserControl
    {
        private readonly PatientController patientController;
        private List<Patient> patients;
        private Patient patient;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public SearchUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
            this.patients = new List<Patient>();
            this.patient = null;
        }

        private void InitSearches()
        {
            this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
            this.dobSearchRadioButton.Checked = true;
            this.dobSearchDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
            this.dobSearchDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);
            this.dobDoblnSearchDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
            this.dobDoblnSearchDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);
            this.patientLoadedMessage.Visible = false;
        }

        private void SearchUserControlLoad(object sender, EventArgs e)
        {
            this.InitSearches();
        }

        private void SearchUserControlVisibleChanged(object sender, EventArgs e)
        {
            this.InitSearches();
        }

        /// <summary>
        /// Retireve the patient from the search specified
        /// </summary>
        /// <returns>patient object from the search specified</returns>
        public Patient GetPatient()
        {
            return this.patient;
        }

        private void DisableDobSearch(bool disable)
        {
            if (disable)
            {
                this.dobSearchRadioButton.Checked = false;
                this.dobSearchDateTimePicker.Enabled = false;
                this.dobSearchButton.Enabled = false;
            }
            else
            {
                this.dobSearchRadioButton.Checked = true;
                this.dobSearchDateTimePicker.Enabled = true;
                this.dobSearchButton.Enabled = true;
            }
        }

        private void DisableFirstNameLastNameSearch(bool disable)
        {
            if (disable)
            {
                this.fnlnSearchRadioButton.Checked = false;
                this.firstNameFnlnSearchTextBox.ReadOnly = true;
                this.lastNameFnlnSearchTextBox.ReadOnly = true;
                this.fnlnSearchButton.Enabled = false;
                this.firstNameFnlnSearchTextBox.Text = "";
                this.lastNameFnlnSearchTextBox.Text = "";
            } else
            {
                this.fnlnSearchRadioButton.Checked = true;
                this.firstNameFnlnSearchTextBox.ReadOnly = false;
                this.lastNameFnlnSearchTextBox.ReadOnly = false;
                this.fnlnSearchButton.Enabled = true;
            }
        }

        private void DisableDobLastNameSearch(bool disable)
        {
            if (disable)
            {
                this.dobLastNameSearchRadioButton.Checked = false;
                this.dobDoblnSearchDateTimePicker.Enabled = false;
                this.lastNameDoblnSearchTextBox.ReadOnly = true;
                this.doblnSearchButton.Enabled = false;
                this.lastNameDoblnSearchTextBox.Text = "";
            } else
            {
                this.dobLastNameSearchRadioButton.Checked = true;
                this.dobDoblnSearchDateTimePicker.Enabled = true;
                this.lastNameDoblnSearchTextBox.ReadOnly = false;
                this.doblnSearchButton.Enabled = true;
            }
        }

        private void DobSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.dobSearchRadioButton.Checked)
            {
                this.patient = null;
                this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
                this.DisableDobSearch(false);
                this.DisableFirstNameLastNameSearch(true);
                this.DisableDobLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
            } else
            {
                this.DisableDobSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
            }
        }

        private void FnlnSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.fnlnSearchRadioButton.Checked)
            {
                this.patient = null;
                this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
                this.DisableDobSearch(true);
                this.DisableFirstNameLastNameSearch(false);
                this.DisableDobLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
            }
            else
            {
                this.DisableFirstNameLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
            }
        }

        private void DobLastNameSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.dobLastNameSearchRadioButton.Checked)
            {
                this.patient = null;
                this.patientDataGridView.DataSource = this.patientController.GetAllPatients();
                this.DisableDobSearch(true);
                this.DisableFirstNameLastNameSearch(true);
                this.DisableDobLastNameSearch(false);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
            }
            else
            {
                this.DisableDobLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
            }
        }

        private void HideFirstNameFnlnErrorLabel(bool hide)
        {
            if (hide)
            {
                this.firstNameFnlnErrorLabel.Visible = false;
                this.firstNameFnlnErrorLabel.ForeColor = Color.Black;
            } else
            {
                this.firstNameFnlnErrorLabel.Visible = true;
                this.firstNameFnlnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideLastNameFnlnErrorLabel(bool hide)
        {
            if (hide)
            {
                this.lastNameFnlnErrorLabel.Visible = false;
                this.lastNameFnlnErrorLabel.ForeColor = Color.Black;
            } else
            {
                this.lastNameFnlnErrorLabel.Visible = true;
                this.lastNameFnlnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideLastNameDoblnErrorLabel(bool hide)
        {
            if (hide)
            {
                this.lastNameDoblnErrorLabel.Visible = false;
                this.lastNameDoblnErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.lastNameDoblnErrorLabel.Visible = true;
                this.lastNameDoblnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideSearchDobErrorLabel(bool hide, bool successful)
        {
            if (hide)
            {
                this.searchDobErrorLabel.Text = "";
                this.searchDobErrorLabel.Visible = false;
                this.searchDobErrorLabel.ForeColor = Color.Black;
            }
            else if (!hide && successful)
            {
                this.searchDobErrorLabel.Text = "Search Successful!";
                this.searchDobErrorLabel.Visible = true;
                this.searchDobErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.searchDobErrorLabel.Text = "No Patient Found";
                this.searchDobErrorLabel.Visible = true;
                this.searchDobErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideSearchFnlnErrorLabel(bool hide, bool successful)
        {
            if (hide)
            {
                this.searchFnlnErrorLabel.Text = "";
                this.searchFnlnErrorLabel.Visible = false;
                this.searchFnlnErrorLabel.ForeColor = Color.Black;
            }
            else if (!hide && successful)
            {
                this.searchFnlnErrorLabel.Text = "Search Successful!";
                this.searchFnlnErrorLabel.Visible = true;
                this.searchFnlnErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.searchFnlnErrorLabel.Text = "No Patient Found";
                this.searchFnlnErrorLabel.Visible = true;
                this.searchFnlnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideSearchDoblnErrorLabel(bool hide, bool successful)
        {
            if (hide && !successful)
            {
                this.searchDoblnErrorLabel.Text = "";
                this.searchDoblnErrorLabel.Visible = false;
                this.searchDoblnErrorLabel.ForeColor = Color.Black;
            }
            else if (!hide && successful)
            {
                this.searchDoblnErrorLabel.Text = "Search Successful!";
                this.searchDoblnErrorLabel.Visible = true;
                this.searchDoblnErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.searchDoblnErrorLabel.Text = "No Patient Found";
                this.searchDoblnErrorLabel.Visible = true;
                this.searchDoblnErrorLabel.ForeColor = Color.Red;
            }
        }
       
        private void DobSearchButtonClick(object sender, EventArgs e)
        {
            this.patients = this.patientController.GetPatientsByDob(this.dobSearchDateTimePicker.Value);
            
            if (this.patients.Count == 0)
            {
                if (MessageBox.Show("No Patients match the search criteria.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.HideSearchDobErrorLabel(false, false);
                }
            } 
            else
            {
                this.patientDataGridView.DataSource = this.patients;
                this.HideSearchDobErrorLabel(false, true);
            }  
        }

        private void DobSearchDateTimePickerValueChanged(object sender, EventArgs e)
        {
            this.HideSearchDobErrorLabel(true, false);
        }

        private void ValidateFnln()
        {
            if (this.firstNameFnlnSearchTextBox.Text.Equals(""))
            {
                this.HideFirstNameFnlnErrorLabel(false);
            } 
            else if (this.lastNameFnlnSearchTextBox.Text.Equals(""))
            {
                this.HideLastNameFnlnErrorLabel(false);
            } 
            else
            {
                this.patients = this.patientController.GetPatientsByFnln(this.firstNameFnlnSearchTextBox.Text, this.lastNameFnlnSearchTextBox.Text);

                if (this.patients.Count == 0)
                {
                    if (MessageBox.Show("No Patients match the search criteria.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSearchFnlnErrorLabel(false, false);
                    }
                }
                else
                {
                    this.patientDataGridView.DataSource = this.patients;
                    this.HideSearchFnlnErrorLabel(false, true);
                }
            }
        }

        private void FnlnSearchButtonClick(object sender, EventArgs e)
        {
            this.ValidateFnln();
        }

        private void FirstNameFnlnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.HideFirstNameFnlnErrorLabel(true);
            this.HideSearchFnlnErrorLabel(true, false);
        }

        private void LastNameFnlnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.HideLastNameFnlnErrorLabel(true);
            this.HideSearchFnlnErrorLabel(true, false);
        }

        private void ValidateDobln()
        {
            if (this.lastNameDoblnSearchTextBox.Text.Equals(""))
            {
                this.HideLastNameDoblnErrorLabel(false);
            }
            else
            {
                this.patients = this.patientController.GetPatientsByDobln(this.dobDoblnSearchDateTimePicker.Value, this.lastNameDoblnSearchTextBox.Text);

                if (this.patients.Count == 0)
                {
                    if (MessageBox.Show("No Patients match the search criteria.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSearchDoblnErrorLabel(false, false);
                    }
                }
                else
                {
                    this.patientDataGridView.DataSource = this.patients;
                    this.HideSearchDoblnErrorLabel(false, true);
                }
            }
        }

        private void DoblnSearchButtonClick(object sender, EventArgs e)
        {
            this.ValidateDobln();
        }

        private void LastNameDoblnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.HideLastNameDoblnErrorLabel(true);
            this.HideSearchDoblnErrorLabel(true, false);
        }

        private void DobDoblnSearchDateTimePickerValueChanged(object sender, EventArgs e)
        {
            this.HideSearchDoblnErrorLabel(true, false);
        }

        private void PatientDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (patientDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = patientDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patientDataGridView.Rows[selectedrowindex];

                int id = (int)selectedRow.Cells["Id"].Value;
                int personsId = (int)selectedRow.Cells["PersonsId"].Value;
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                DateTime dateOfBirth = (DateTime)selectedRow.Cells["DateOfBirth"].Value;
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string ssn = selectedRow.Cells["SSN"].Value.ToString();
                string address1 = selectedRow.Cells["Address1"].Value.ToString();
                string address2 = selectedRow.Cells["Address2"].Value.ToString();
                string city = selectedRow.Cells["City"].Value.ToString();
                string state = selectedRow.Cells["State"].Value.ToString();
                string zipCode = selectedRow.Cells["ZipCode"].Value.ToString();
                string phoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();

                this.patient = new Patient(id, personsId, firstName, lastName, dateOfBirth, gender,
                            ssn, address1, address2, city, state, zipCode, phoneNumber);
                this.patientLoadedMessage.Text = this.patient.FirstName + " " + this.patient.LastName + " loaded!";
                this.patientLoadedMessage.Visible = true;
            }
        }
    }
}
