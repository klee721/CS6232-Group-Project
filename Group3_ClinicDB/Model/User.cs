using System;


namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// DB model for a User of the clinic system
    /// </summary>
    public class User
    {
        public string userName { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string password { get; set; }

        public int adminID { get; set; }

        public int nurseID { get; set; }

        public int doctorID { get; set; }

        public int patientID { get; set; }
    }
}
