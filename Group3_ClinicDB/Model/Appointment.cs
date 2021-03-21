using System;

namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// The model for an Appointment from the DB
    /// </summary>
    class Appointment
    {
        public int ID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }


    }
}
