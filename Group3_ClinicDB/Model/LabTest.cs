using System;

namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// The model for an LabTest from the DB
    /// </summary>
    public class LabTest
    {
        public int PatientID { get; set; }

        public DateTime OrderDateTime { get; set; }

        public DateTime PerformedDateTime { get; set; }

        public string TestCode { get; set; }

        public string Results { get; set; }

        public string Normal { get; set; }

        public int visitId { get; set; }


    }
}
