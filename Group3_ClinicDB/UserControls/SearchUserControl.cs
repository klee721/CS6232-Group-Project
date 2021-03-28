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

        private void SearchUserControlLoad(object sender, EventArgs e)
        {
            this.dobSearchRadioButton.Checked = true;
            this.fnlnSearchRadioButton.Checked = false;
            this.dobLastNameSearchRadioButton.Checked = false;

            this.fnlnSearchButton.Enabled = false;
            this.fnlnSearchButton.Enabled = false;
        }
    }
}
