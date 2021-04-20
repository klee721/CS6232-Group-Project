using System;

namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// The model for an LabTest from the DB
    /// </summary>
    public class LabTestReport
    {
        public string TestCode { get; set; }

        public string Name { get; set; }

        public int QualifiedTests { get; set; }

        public int TotalTests { get; set; }

        public Decimal Totalpct { get; set; }

        public int NormalCount { get; set; }
        public int AbNormalCount { get; set; }

        public Decimal Pct1929 { get; set; }

        public Decimal Pct3039 { get; set; }

        public Decimal OtherAgePct { get; set; }


    }
}
