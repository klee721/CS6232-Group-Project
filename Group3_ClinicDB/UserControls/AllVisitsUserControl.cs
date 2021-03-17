using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_ClinicDB.Controller;

namespace Group3_ClinicDB.UserControls
{
    public partial class AllVisitsUserControl : UserControl
    {
        /// <summary>
        /// The constructor
        /// </summary>

        public AllVisitsUserControl()
        {
            InitializeComponent();
            this.controller = new VisitsController();
        }

        private readonly VisitsController controller;

 


        private void AllVisitsUserControl_Load(object sender, EventArgs e)
        {
            //visitsDALDataGridView.DataSource = null;
            visitsDALDataGridView.DataSource = this.controller.GetVisits();
        }
    }
}
