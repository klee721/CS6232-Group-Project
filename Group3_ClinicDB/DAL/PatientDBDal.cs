using Group3_ClinicDB.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// The DAL for the Patient to connect to the DB
    /// </summary>
    public class PatientDBDAL
    {
        /// <summary>
        /// Retrieves all patients from the DB
        /// </summary>
        /// <returns>Returns a list of all Patients from the DB</returns>
        public List<Patient> GetAllPatients()
        {
            List<Patient> patientsList = new List<Patient>();

            string selectStatement = "SELECT Patients.id, Patients.persons_id, Persons.firstName, " +
                                        "Persons.lastName, Persons.dateOfBirth, Persons.gender, " +
                                        "Persons.SSN, Persons.Address1, ISNULL(Persons.Address2,'') as Address2, Persons.city, " +
                                        "Persons.state, Persons.zipcode, Persons.phoneNumber " +
                                        "FROM Patients " +
                                        "JOIN Persons ON Patients.persons_id = Persons.id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient((int)reader["id"], (int)reader["persons_id"], reader["firstName"].ToString(),
                                                        reader["lastName"].ToString(), (DateTime)reader["dateOfBirth"], reader["gender"].ToString(),
                                                        reader["SSN"].ToString(), reader["Address1"].ToString(), reader["Address2"].ToString(),
                                                        reader["city"].ToString(), reader["state"].ToString(), reader["zipcode"].ToString(), reader["phoneNumber"].ToString());

                            patientsList.Add(patient);
                        }
                    }
                }
            }
            return patientsList;
        }

        /// <summary>
        /// Adds a Patient to the table based on the Id
        /// </summary>
        /// <param name="personId"></param>
        public void AddPatient(int personId)
        {
            string insertStatement =
                "INSERT Patients " +
                    "(persons_id) " +
                "VALUES (@personId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@personId", personId);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
