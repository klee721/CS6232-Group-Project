using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.DAL
{
    class AppointmentsDAL
    {


        /// <summary>
        /// Public method to retrieve a list of all a patient's appointments via their patient ID number
        /// </summary>
        /// <param name="patientID">the patient ID of the patient whos appointments are being retrieved</param>
        /// <returns>a List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsByPatient(int patientID)
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement = "SELECT Id, patientID, doctor_id, AppointmentDateTime, reasons, status FROM appointments "
                + "WHERE patientid = @patientID";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@patientID", patientID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appt = new Appointment();
                            appt.ID = (int)reader["Id"];
                            appt.PatientID = (int)reader["patientID"];
                            appt.DoctorID = (int)reader["doctor_id"];
                            appt.AppointmentDate = (DateTime)reader["AppointmentDateTime"];
                            appt.Reason = reader["reasons"].ToString();
                            appt.Status = reader["status"].ToString();
                            appointments.Add(appt);
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Public method to retrieve a List of ALL appointments in the DB
        /// </summary>
        /// <returns>a List object with every Appointment scheduled in the DB</returns>
        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement = "SELECT Id, patientID, doctor_id, AppointmentDateTime, reasons, status FROM appointments";
             

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                   
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appt = new Appointment();
                            appt.ID = (int)reader["Id"];
                            appt.PatientID = (int)reader["patientID"];
                            appt.DoctorID = (int)reader["doctor_id"];
                            appt.AppointmentDate = (DateTime)reader["AppointmentDateTime"];
                            appt.Reason = reader["reasons"].ToString();
                            appt.Status = reader["status"].ToString();
                            appointments.Add(appt);
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Method to add a new appointment to the database 
        /// </summary>
        /// <param name="appointment">an Appointment object containing the data that will be written to the DB</param>
        /// <returns>a bool flag indicating write success</returns>
        public bool AddAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("Appointment cannot be null");
                
            }

            string insertStatement = "INSERT INTO appointments "
                +"VALUES (@patientID, @doctorID, @apptDate, @reason, @status)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@patientID", appointment.PatientID);
                    insertCommand.Parameters.AddWithValue("@doctorID", appointment.DoctorID);
                    insertCommand.Parameters.AddWithValue("@apptDate", appointment.AppointmentDate);
                    insertCommand.Parameters.AddWithValue("@reason", appointment.Reason);
                    insertCommand.Parameters.AddWithValue("@status", appointment.Status);
                    insertCommand.ExecuteNonQuery();

                }

            }

                    return true;
        }

        /// <summary>
        /// Method to retrieve a List of Appointment objects by using a specific Doctor's ID number
        /// </summary>
        /// <param name="doctorID">ID number of the doctor whose appointments we wish to retrieve</param>
        /// <returns>List of Appointment objects</returns>
        public List<Appointment> GetAppointmentsByDoctor(int doctorID)
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement = "SELECT Id, patientID, doctor_id, AppointmentDateTime, reasons, status FROM appointments "
                + "WHERE doctor_id = @doctorID";


            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@doctorID", doctorID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appt = new Appointment();
                            appt.ID = (int)reader["Id"];
                            appt.PatientID = (int)reader["patientID"];
                            appt.DoctorID = (int)reader["doctor_id"];
                            appt.AppointmentDate = (DateTime)reader["AppointmentDateTime"];
                            appt.Reason = reader["reasons"].ToString();
                            appt.Status = reader["status"].ToString();
                            appointments.Add(appt);
                        }
                    }
                }
            }
            return appointments;


        }






    }
}
