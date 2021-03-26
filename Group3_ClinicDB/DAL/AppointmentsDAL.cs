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
        public List<Appointment> GetActiveAppointmentsByPatient(int patientID)
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement = "SELECT Id, patientID, doctor_id, AppointmentDateTime, reasons, status FROM appointments "
                + "WHERE patientid = @patientID "
                + "AND status = 'A' " 
                + "AND AppointmentDateTime > GETDATE() ";

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
        /// Public method to retrieve a list of all a patient's appointments via their patient ID number
        /// </summary>
        /// <param name="patientID">the patient ID of the patient whos appointments are being retrieved</param>
        /// <returns>a List of Appointment objects</returns>
        public List<Appointment> GetAllAppointmentsByPatient(int patientID)
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement = "SELECT Id, patientID, doctor_id, AppointmentDateTime, reasons, status FROM appointments "
                + "WHERE patientid = @patientID "
                + "ORDER BY AppointmentDateTime ASC ";

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
                + "WHERE doctor_id = @doctorID "
                + "AND status = 'A' ";


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
        /// <summary>
        /// Public method to update an appointment's details in the DB
        /// </summary>
        /// <param name="editedAppointment">an Appointment object containing the adjusted values for the appointment record</param>
        /// <returns>true after successfully updating</returns>
        public bool UpdateAppointment(Appointment editedAppointment)
        {
            string updateStatement = "UPDATE appointments " +
                      "SET patientId = @patientId, doctor_id = @doctorId, AppointmentDateTime = @aptDate, reasons = @reason " +
                      "WHERE Id = @Id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", editedAppointment.ID);
                    cmd.Parameters.AddWithValue("@patientId",editedAppointment.PatientID);
                    cmd.Parameters.AddWithValue("@doctorId", editedAppointment.DoctorID);
                    cmd.Parameters.AddWithValue("@aptDate", editedAppointment.AppointmentDate);
                    cmd.Parameters.AddWithValue("@reason", editedAppointment.Reason);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Appointment " + editedAppointment.ID + " has been edited.");
                }

                connection.Close();
                return true;

            }
           
        }


        /// <summary>
        /// Public method to adjust the status flag of an appointment from A (active) to C (cancelled)
        /// </summary>
        /// <param name="cancelledAppointment">an appointment that the user wishes to cancel</param>
        /// <returns>true when the command has executed</returns>
        public bool CancelAppointment(Appointment cancelledAppointment)
        {

            string updateStatement = "UPDATE appointments " +
                       "SET status = 'C'  " +
                       "WHERE Id = @Id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", cancelledAppointment.ID);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Appointment " + cancelledAppointment.ID + " has been cancelled.");
                }

                connection.Close();
                return true;

            }

        }








    }
}
