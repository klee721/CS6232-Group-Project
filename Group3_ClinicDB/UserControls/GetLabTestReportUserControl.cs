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
        public void LoadReport()
        {
            if ((this.StartDatePicker.Value != null) && (this.EndDatePicker.Value != null))
            {
                //LabTestPerformedReportGrid.date = this.controller.GetLabTestReport(this.StartDatePicker.Value, this.EndDatePicker.Value);
                DateTime fromDate = new DateTime(this.StartDatePicker.Value.Year, this.StartDatePicker.Value.Month, this.StartDatePicker.Value.Day);
                DateTime toDate = new DateTime(this.EndDatePicker.Value.Year, this.EndDatePicker.Value.Month, this.EndDatePicker.Value.Day);
                this.getLabtestReportTableAdapter.Fill(this._cs6232_g3DataSetStoredProcedure.GetLabtestReport, fromDate, toDate);
                this.reportViewer1.RefreshReport();
            }
        }

        private void GetReportButtonClick(object sender, EventArgs e)
        {
            this.LoadReport();
        }
    }
}
