using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
using System;
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
        private Patient patient;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public SearchUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
            this.patient = null;
        }

        private void InitSearches()
        {
            this.dobSearchRadioButton.Checked = true;
            this.dobSearchDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
            this.dobSearchDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);
            this.dobDoblnSearchDateTimePicker.MaxDate = DateTime.Now.Date.AddDays(-1);
            this.dobDoblnSearchDateTimePicker.MinDate = DateTime.Now.Date.AddYears(-150);
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
        /// Retireves the patient object from the search specified
        /// </summary>
        /// <returns>patient object from the search specified</returns>
        public Patient GetPatient()
        {
            return patient;
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
                this.DisableDobSearch(false);
                this.DisableFirstNameLastNameSearch(true);
                this.DisableDobLastNameSearch(true);
            } else
            {
                this.DisableDobSearch(true);
            }
        }

        private void FnlnSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.fnlnSearchRadioButton.Checked)
            {
                this.DisableDobSearch(true);
                this.DisableFirstNameLastNameSearch(false);
                this.DisableDobLastNameSearch(true);
            }
            else
            {
                this.DisableFirstNameLastNameSearch(true);
            }
        }

        private void DobLastNameSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.dobLastNameSearchRadioButton.Checked)
            {
                this.DisableDobSearch(true);
                this.DisableFirstNameLastNameSearch(true);
                this.DisableDobLastNameSearch(false);
            }
            else
            {
                this.DisableDobLastNameSearch(true);
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
            this.patient = this.patientController.GetPatientByDob(this.dobSearchDateTimePicker.Value);
            
            if (this.patient == null)
            {
                if (MessageBox.Show("No Patients match the date of birth.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.HideSearchDobErrorLabel(false, false);
                }
            } 
            else
            {
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
                this.patient = this.patientController.GetPatientByFnln(this.firstNameFnlnSearchTextBox.Text, this.lastNameFnlnSearchTextBox.Text);

                if (this.patient == null)
                {
                    if (MessageBox.Show("No Patients match the first and last name.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSearchFnlnErrorLabel(false, false);
                    }
                }
                else
                {
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
                //this.patient = this.patientController.GetPatientByDobln(this.dobDoblnSearchDateTimePicker.Value, this.lastNameDoblnSearchTextBox);

                if (this.patient == null)
                {
                    if (MessageBox.Show("No Patients match the date of birth and last name.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSearchDoblnErrorLabel(false, false);
                    }
                }
                else
                {
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
    }
}
