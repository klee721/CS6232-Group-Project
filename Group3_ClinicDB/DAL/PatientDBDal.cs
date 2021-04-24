using Group3_ClinicDB.Controller;
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
        /// Retrieves the patients id with the date of birth specified
        /// </summary>
        /// <param name="dateOfBirth">The date of birth for the patients</param>
        /// <returns>The patients with the date of birth specified</returns>
        public List<Patient> GetPatientsByDob(DateTime dateOfBirth)
        {
            List<Patient> patientsList = new List<Patient>();

            string selectStatement = "SELECT Patients.id, Patients.persons_id, Persons.firstName, " +
                                        "Persons.lastName, Persons.dateOfBirth, Persons.gender, " +
                                        "Persons.SSN, Persons.Address1, ISNULL(Persons.Address2,'') as Address2, Persons.city, " +
                                        "Persons.state, Persons.zipcode, Persons.phoneNumber " +
                                        "FROM Patients " +
                                        "JOIN Persons ON Patients.persons_id = Persons.id " +
                                        "WHERE Persons.dateOfBirth = @dateOfBirth";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.ToShortDateString());

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
        /// Retrieves the patients with the first and last name specified
        /// </summary>
        /// <param name="firstName">The first name for the patients</param>
        /// <param name="lastName">The last name for the patients</param>
        /// <returns>The patients with the first and last name specified</returns>
        public List<Patient> GetPatientsByFnln(string firstName, string lastName)
        {
            List<Patient> patientsList = new List<Patient>();

            string selectStatement = "SELECT Patients.id, Patients.persons_id, Persons.firstName, " +
                                        "Persons.lastName, Persons.dateOfBirth, Persons.gender, " +
                                        "Persons.SSN, Persons.Address1, ISNULL(Persons.Address2,'') as Address2, Persons.city, " +
                                        "Persons.state, Persons.zipcode, Persons.phoneNumber " +
                                        "FROM Patients " +
                                        "JOIN Persons ON Patients.persons_id = Persons.id " +
                                        "WHERE Persons.firstName = @firstName AND Persons.lastName = @lastName";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstName);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);

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
        /// Retrieves the patients with the date of birth and last name specified
        /// </summary>
        /// <param name="dateOfBirth">The date of birth for the patients</param>
        /// <param name="lastName">The last name for the patients</param>
        /// <returns>The patients with the date of birth and last name specified</returns>
        public List<Patient> GetPatientsByDobln(DateTime dateOfBirth, string lastName)
        {
            List<Patient> patientsList = new List<Patient>();

            string selectStatement = "SELECT Patients.id, Patients.persons_id, Persons.firstName, " +
                                        "Persons.lastName, Persons.dateOfBirth, Persons.gender, " +
                                        "Persons.SSN, Persons.Address1, ISNULL(Persons.Address2,'') as Address2, Persons.city, " +
                                        "Persons.state, Persons.zipcode, Persons.phoneNumber " +
                                        "FROM Patients " +
                                        "JOIN Persons ON Patients.persons_id = Persons.id " +
                                        "WHERE Persons.dateOfBirth = @dateOfBirth AND Persons.lastName = @lastName";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.ToShortDateString());
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);

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
        /// Adds a Patient to the table that already exists as a person
        /// </summary>
        /// <param name="person">The person the nurse has entered</param>
        public void AddPatientExistingPerson(Person person)
        {
            int personID = 0;

            string selectStatement =
                "SELECT id " +
                    "FROM persons " +
                    "WHERE firstName = @firstName " +
                    "AND lastName = @lastName " +
                    "AND dateOfBirth = @dateOfBirth " +
                    "AND gender = @gender " +
                    "AND SSN = @ssn " +
                    "AND Address1 = @address1 " +
                    "AND ISNULL(Address2,'') = @address2 " +
                    "AND city = @city " +
                    "AND state = @state " +
                    "AND zipcode = @zipCode " +
                    "AND phoneNumber = @phoneNumber";

            string insertStatementPatient =
                "INSERT Patients " +
                    "(persons_id) " +
                "VALUES (@personId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection, transaction);
                    selectCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                    selectCommand.Parameters.AddWithValue("@lastName", person.LastName);
                    selectCommand.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
                    selectCommand.Parameters.AddWithValue("@gender", person.Gender);
                    selectCommand.Parameters.AddWithValue("@ssn", person.Ssn);
                    selectCommand.Parameters.AddWithValue("@address1", person.Address1);
                    selectCommand.Parameters.AddWithValue("@address2", person.Address2);
                    selectCommand.Parameters.AddWithValue("@city", person.City);
                    selectCommand.Parameters.AddWithValue("@state", person.State);
                    selectCommand.Parameters.AddWithValue("@zipCode", person.ZipCode);
                    selectCommand.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personID = (int)reader["id"];
                        }
                    }

                    SqlCommand insertCommandPatient = new SqlCommand(insertStatementPatient, connection, transaction);
                    insertCommandPatient.Parameters.AddWithValue("@personId", personID);
                    insertCommandPatient.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }

        /// <summary>
        /// Adds a new Patient to the table that does not exist as a person
        /// </summary>
        /// <param name="person">The person the nurse has entered</param>
        public void AddPatientNewPerson(Person person)
        {
            string insertStatementPerson =
                "INSERT Persons " +
                    "(firstName, lastName, dateOfBirth, gender, ssn, address1, address2, city, state, zipCode, phoneNumber) " +
                "VALUES (@firstName, @lastName, @dateOfBirth, @gender, @ssn, @address1, @address2, @city, @state, @zipcode, @phoneNumber)";

            int personID = 0;

            string selectStatement =
                "SELECT id " +
                    "FROM persons " +
                    "WHERE firstName = @firstName " +
                    "AND lastName = @lastName " +
                    "AND dateOfBirth = @dateOfBirth " +
                    "AND gender = @gender " +
                    "AND SSN = @ssn " +
                    "AND Address1 = @address1 " +
                    "AND ISNULL(Address2,'') = @address2 " +
                    "AND city = @city " +
                    "AND state = @state " +
                    "AND zipcode = @zipCode " +
                    "AND phoneNumber = @phoneNumber";

            string insertStatementPatient =
                "INSERT Patients " +
                    "(persons_id) " +
                "VALUES (@personId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand insertCommandPerson = new SqlCommand(insertStatementPerson, connection, transaction);
                    insertCommandPerson.Parameters.AddWithValue("@firstName", person.FirstName);
                    insertCommandPerson.Parameters.AddWithValue("@lastName", person.LastName);
                    insertCommandPerson.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth.ToShortDateString());
                    insertCommandPerson.Parameters.AddWithValue("@gender", person.Gender);
                    insertCommandPerson.Parameters.AddWithValue("@ssn", person.Ssn);
                    insertCommandPerson.Parameters.AddWithValue("@address1", person.Address1);
                    if (person.Address2.Equals(""))
                    {
                        insertCommandPerson.Parameters.AddWithValue("@address2", DBNull.Value);
                    }
                    else
                    {
                        insertCommandPerson.Parameters.AddWithValue("@address2", person.Address2);
                    }
                    insertCommandPerson.Parameters.AddWithValue("@city", person.City);
                    insertCommandPerson.Parameters.AddWithValue("@state", person.State);
                    insertCommandPerson.Parameters.AddWithValue("@zipcode", person.ZipCode);
                    insertCommandPerson.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                    insertCommandPerson.ExecuteNonQuery();

                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection, transaction);
                    selectCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                    selectCommand.Parameters.AddWithValue("@lastName", person.LastName);
                    selectCommand.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
                    selectCommand.Parameters.AddWithValue("@gender", person.Gender);
                    selectCommand.Parameters.AddWithValue("@ssn", person.Ssn);
                    selectCommand.Parameters.AddWithValue("@address1", person.Address1);
                    selectCommand.Parameters.AddWithValue("@address2", person.Address2);
                    selectCommand.Parameters.AddWithValue("@city", person.City);
                    selectCommand.Parameters.AddWithValue("@state", person.State);
                    selectCommand.Parameters.AddWithValue("@zipCode", person.ZipCode);
                    selectCommand.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personID = (int)reader["id"];
                        }
                    }

                    SqlCommand insertCommandPatient = new SqlCommand(insertStatementPatient, connection, transaction);
                    insertCommandPatient.Parameters.AddWithValue("@personId", personID);
                    insertCommandPatient.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
