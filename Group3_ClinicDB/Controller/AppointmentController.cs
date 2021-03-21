using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Appointment> GetAllAppointments()
        {
            return this.appointmentSource.GetAllAppointments();
        }

        public bool AddAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("Appointment cannot be null");
            }

            return this.appointmentSource.AddAppointment(appointment);

        }



    }
}
