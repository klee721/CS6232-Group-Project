using Group3_ClinicDB.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class GetLabTestReportUserControl : UserControl
    {
        private readonly LabTestController controller;
        public GetLabTestReportUserControl()
        {
            InitializeComponent();
            this.controller = new LabTestController();
        }

        /// <summary>
        /// Method to load report
        /// </summary>
        /// 
        public void Load_report()
        {
            
            
            if ((this.StartDatePicker.Value != null) && (this.EndDatePicker.Value != null))
            {
                LabTestPerformedReportGrid.date = this.controller.GetLabTestReport(this.StartDatePicker.Value, this.EndDatePicker.Value);
            }
            
        }
    }
}
