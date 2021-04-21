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
            Load_report();
        }

        /// <summary>
        /// Method to load report
        /// </summary>
        /// 
        public void Load_report()
        {
            if ((this.StartDatePicker.Value != null) && (this.EndDatePicker.Value != null))
            {
                //LabTestPerformedReportGrid.date = this.controller.GetLabTestReport(this.StartDatePicker.Value, this.EndDatePicker.Value);
                
            }
            DateTime fromDate = new DateTime(2021, 04, 01);
            DateTime toDate = new DateTime(2021, 04, 30);
            this.getLabtestReportTableAdapter.Fill(this._cs6232_g3DataSetStoredProcedure.GetLabtestReport, fromDate, toDate);
            this.reportViewer1.RefreshReport();
        }
    }
}
