using System;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class SearchUserControl : UserControl
    {
        public SearchUserControl()
        {
            InitializeComponent();
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

        private void Validate()
        {
            if (this.firstNameFnlnSearchTextBox.Text.Equals(""))
            {

            }

            if (this.lastNameFnlnSearchTextBox.Text.Equals(""))
            {

            }
        }

        private void FnlnSearchButtonClick(object sender, EventArgs e)
        {

        }
    }
}
