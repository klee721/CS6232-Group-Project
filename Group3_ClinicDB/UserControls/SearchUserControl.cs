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

            this.dobLastNameSearchRadioButton.Checked = false;
            this.dobDoblnSearchDateTimePicker.Enabled = false;
            this.lastNameDoblnSearchTextBox.ReadOnly = true;
            this.doblnSearchButton.Enabled = false;

            this.fnlnSearchRadioButton.Checked = false;
            this.firstNameFnlnSearchTextBox.ReadOnly = true;
            this.lastNameFnlnSearchTextBox.ReadOnly = true;
            this.fnlnSearchButton.Enabled = false;
        }

        private void SearchUserControlLoad(object sender, EventArgs e)
        {
            this.InitSearches();
        }
    }
}
