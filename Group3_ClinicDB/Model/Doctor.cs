using System;


namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// DB model for a Doctor
    /// </summary>
    public class Doctor
    {
        public int DoctorID { get; set; }

        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
