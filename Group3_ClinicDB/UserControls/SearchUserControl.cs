using Group3_ClinicDB.Controller;
using Group3_ClinicDB.Model;
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
        private bool dobMessageBoxPresent;
        private bool fnlnMessageBoxPresent;
        private bool doblnMessageBoxPresent;

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        public SearchUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
            this.patients = new List<Patient>();
            this.patient = null;
            this.dobMessageBoxPresent = false;
            this.fnlnMessageBoxPresent = false;
            this.doblnMessageBoxPresent = false;
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
                this.DisableDobSearch(false);
                this.DisableFirstNameLastNameSearch(true);
                this.DisableDobLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
                this.HideAllSsnSearch();
            } else
            {
                this.DisableDobSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
                this.HideAllSsnSearch();
            }
        }

        private void FnlnSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.fnlnSearchRadioButton.Checked)
            {
                this.DisableDobSearch(true);
                this.DisableFirstNameLastNameSearch(false);
                this.DisableDobLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
                this.HideAllSsnSearch();
            }
            else
            {
                this.DisableFirstNameLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
                this.HideAllSsnSearch();
            }
        }

        private void DobLastNameSearchRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (this.dobLastNameSearchRadioButton.Checked)
            {
                this.DisableDobSearch(true);
                this.DisableFirstNameLastNameSearch(true);
                this.DisableDobLastNameSearch(false);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
                this.HideAllSsnSearch();
            }
            else
            {
                this.DisableDobLastNameSearch(true);
                this.HideSearchDobErrorLabel(true, false);
                this.HideSearchFnlnErrorLabel(true, false);
                this.HideSearchDoblnErrorLabel(true, false);
                this.HideAllSsnSearch();
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

        private void HideSsnDobSearch(bool hide)
        {
            if (hide)
            {
                this.ssnDobSearchLabel.Visible = false;
                this.ssnDobSearchTextBox.Visible = false;
                this.ssnDobErrorLabel.Visible = false;
            }
            else
            {
                this.ssnDobSearchLabel.Visible = true;
                this.ssnDobSearchTextBox.Visible = true;
                this.ssnDobErrorLabel.Visible = true;
                this.ssnDobErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideSsnFnlnSearch(bool hide)
        {
            if (hide)
            {
                this.ssnFnlnSearchLabel.Visible = false;
                this.ssnFnlnSearchTextBox.Visible = false;
                this.ssnFnlnErrorLabel.Visible = false;
                this.ssnFnlnErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.ssnFnlnSearchLabel.Visible = true;
                this.ssnFnlnSearchTextBox.Visible = true;
                this.ssnFnlnErrorLabel.Visible = true;
                this.ssnFnlnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideSsnDoblnSearch(bool hide)
        {
            if (hide)
            {
                this.ssnDoblnSearchLabel.Visible = false;
                this.ssnDoblnSearchTextBox.Visible = false;
                this.ssnDoblnErrorLabel.Visible = false;
                this.ssnDoblnErrorLabel.ForeColor = Color.Black;
            }
            else
            {
                this.ssnDoblnSearchLabel.Visible = true;
                this.ssnDoblnSearchTextBox.Visible = true;
                this.ssnDoblnErrorLabel.Visible = true;
                this.ssnDoblnErrorLabel.ForeColor = Color.Red;
            }
        }

        private void HideAllSsnSearch()
        {
            this.HideSsnDobSearch(true);
            this.HideSsnFnlnSearch(true);
            this.HideSsnDoblnSearch(true);
            this.HideAllMessageBox();
        }

        private void HideAllMessageBox()
        {
            this.dobMessageBoxPresent = false;
            this.fnlnMessageBoxPresent = false;
            this.doblnMessageBoxPresent = false;
        }

        private void DobSearchButtonClick(object sender, EventArgs e)
        {
            this.patients = this.patientController.GetPatientsByDob(this.dobSearchDateTimePicker.Value);
            
            if (this.patients.Count == 0)
            {
                if (MessageBox.Show("No Patients match the date of birth.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.HideSearchDobErrorLabel(false, false);
                }
            }  
            else if (this.patients.Count > 1)
            {
                if (!this.dobMessageBoxPresent) 
                {
                    if (MessageBox.Show("More than one patient found. Please find the specific patient by searching their Social Security Number.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSsnDobSearch(false);
                        this.ssnDobErrorLabel.Visible = false;
                        this.dobMessageBoxPresent = true;
                    }
                }
                else
                {
                    if (this.ssnDobSearchTextBox.Text.Length != 9)
                    {
                        this.ssnDobErrorLabel.Visible = true;
                    }
                    else
                    {
                        try
                        {
                            long ssnLong = Convert.ToInt64(this.ssnDobSearchTextBox.Text);

                            this.patient = this.patientController.GetPatientByDobWithSsn(this.dobSearchDateTimePicker.Value, this.ssnDobSearchTextBox.Text);

                            if (this.patient == null)
                            {
                                if (MessageBox.Show("No Patients match the date of birth.",
                                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    this.HideSearchDobErrorLabel(false, false);
                                }
                            } else
                            {
                                this.HideSearchDobErrorLabel(false, true);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Social security number can only contain whole numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.ssnDobErrorLabel.Visible = true;
                        }
                    }
                }
            }
            else
            {
                this.patient = this.patients[0];
                this.HideSearchDobErrorLabel(false, true);
            }
        }

        private void DobSearchDateTimePickerValueChanged(object sender, EventArgs e)
        {
            this.HideSearchDobErrorLabel(true, false);
            this.HideAllSsnSearch();
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
                    if (MessageBox.Show("No Patients match the first and last name.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSearchFnlnErrorLabel(false, false);
                    }
                }
                else if (this.patients.Count > 1)
                {
                    if (!this.fnlnMessageBoxPresent)
                    {
                        if (MessageBox.Show("More than one patient found. Please find the specific patient by searching their Social Security Number.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.HideSsnFnlnSearch(false);
                            this.ssnFnlnErrorLabel.Visible = false;
                            this.fnlnMessageBoxPresent = true;
                        }
                    }
                    else
                    {
                        if (this.ssnFnlnSearchTextBox.Text.Length != 9)
                        {
                            this.ssnFnlnErrorLabel.Visible = true;
                        }
                        else
                        {
                            try
                            {
                                long ssnLong = Convert.ToInt64(this.ssnFnlnSearchTextBox.Text);

                                this.patient = this.patientController.GetPatientByFnlnWithSsn(this.firstNameFnlnSearchTextBox.Text, this.lastNameFnlnSearchTextBox.Text, this.ssnFnlnSearchTextBox.Text);

                                if (this.patient == null)
                                {
                                    if (MessageBox.Show("No Patients match the date of birth.",
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
                            catch (Exception)
                            {
                                MessageBox.Show("Social security number can only contain whole numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.ssnFnlnErrorLabel.Visible = true;
                            }
                        }
                    }
                }
                else
                {
                    this.patient = this.patients[0];
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
            this.HideAllSsnSearch();
        }

        private void LastNameFnlnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.HideLastNameFnlnErrorLabel(true);
            this.HideSearchFnlnErrorLabel(true, false);
            this.HideAllSsnSearch();
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
                    if (MessageBox.Show("No Patients match the date of birth and last name.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.HideSearchDoblnErrorLabel(false, false);
                    }
                }
                else if (this.patients.Count > 1)
                {
                    if (!this.doblnMessageBoxPresent)
                    {
                        if (MessageBox.Show("More than one patient found. Please find the specific patient by searching their Social Security Number.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.HideSsnDoblnSearch(false);
                            this.ssnDoblnErrorLabel.Visible = false;
                            this.doblnMessageBoxPresent = true;
                        }
                    }
                    else
                    {
                        if (this.ssnDoblnSearchTextBox.Text.Length != 9)
                        {
                            this.ssnDoblnErrorLabel.Visible = true;
                        }
                        else
                        {
                            try
                            {
                                long ssnLong = Convert.ToInt64(this.ssnDoblnSearchTextBox.Text);

                                this.patient = this.patientController.GetPatientByDoblnWithSsn(this.dobDoblnSearchDateTimePicker.Value, this.lastNameDoblnSearchTextBox.Text, this.ssnDoblnSearchTextBox.Text);

                                if (this.patient == null)
                                {
                                    if (MessageBox.Show("No Patients match the date of birth.",
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
                            catch (Exception)
                            {
                                MessageBox.Show("Social security number can only contain whole numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.ssnDoblnErrorLabel.Visible = true;
                            }
                        }
                    }
                }
                else
                {
                    this.patient = this.patients[0];
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
            this.HideAllSsnSearch();
        }

        private void DobDoblnSearchDateTimePickerValueChanged(object sender, EventArgs e)
        {
            this.HideSearchDoblnErrorLabel(true, false);
            this.HideAllSsnSearch();
        }

        private void SsnDobSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ssnDobErrorLabel.Visible = false;
        }

        private void SsnFnlnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ssnFnlnErrorLabel.Visible = false;
        }

        private void SsnDoblnSearchTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ssnDoblnErrorLabel.Visible = false;
        }
    }
}
