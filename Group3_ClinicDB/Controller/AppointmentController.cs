using System;
using System.Collections.Generic;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// Controller class to handle access to the DAL for Appointments
    /// </summary>
    class AppointmentController
    {
        AppointmentsDAL appointmentSource;
        /// <summary>
        /// Constructor
        /// </summary>
        public AppointmentController()
        {
            this.appointmentSource = new AppointmentsDAL();
        }
        /// <summary>
        /// Method to retrieve a List of Appointments for a given patient by their ID number
        /// </summary>
        /// <param name="patientID">the patient ID of the patient whos appointments are being retrieved</param>
        /// <returns>a List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsByPatient(int patientID)
        {
            return this.appointmentSource.GetAppointmentsByPatient(patientID);

        }

        /// <summary>
        /// A method to retrieve a list of every scheduled appointment in the DB
        /// </summary>
        /// <returns>a List containing Appointment objects for every DB appointment</returns>
        public List<Appointment> GetAllAppointments()
        {
            return this.appointmentSource.GetAllAppointments();
        }


        /// <summary>
        /// Method to add a new appointment to the DB
        /// </summary>
        /// <param name="appointment">Appointment object to be added to the DB</param>
        /// <returns>a bool true if successful</returns>
        public bool AddAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("Appointment cannot be null");
            }

            return this.appointmentSource.AddAppointment(appointment);

        }

        /// <summary>
        /// Method to check if a Doctor is available for a given timeslot
        /// </summary>
        /// <param name="doctorID">ID number of the doctor whose availability needs to be checked</param>
        /// <param name="newAptTime">a DateTime that the proposed appointment will be on</param>
        /// <returns>a bool true if available, false if not</returns>
        public bool CheckAvailability(int doctorID, DateTime newAptTime)
        {
            List<Appointment> appointments = this.appointmentSource.GetAppointmentsByDoctor(doctorID);
        
            foreach (Appointment apt in appointments)
            {
                if (apt.AppointmentDate == newAptTime)
                {
                    return false;
                }
            }

            return true;
        }



    }
}
