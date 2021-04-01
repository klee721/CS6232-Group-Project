using System;


namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// DB model for a Nurse
    /// </summary>
    public class Nurse
    {
        public int NurseID { get; set; }

        public int PersonID { get; set; }

        public string Status { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
