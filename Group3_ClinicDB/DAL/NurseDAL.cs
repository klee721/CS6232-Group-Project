using System;
using Group3_ClinicDB.Model;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Group3_ClinicDB.DAL
{
    class NurseDAL
    {
        /// <summary>
        /// Public method for retrieving a list of all Nurse in the DB as a List of Nurse objects
        /// </summary>
        /// <returns>a List containing all of the Nurse in the DB</returns>
        public List<Nurse> GetAllNurses()
        {
            List<Nurse> nurseList = new List<Nurse>();

            string selectStatement = "SELECT d.Id, d.persons_id, p.firstName, p.lastName FROM nurses as d "
                + "JOIN persons as p "
                + "ON d.persons_id = p.id where d.status='A'";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse();
                            nurse.NurseID = (int)reader["Id"];
                            nurse.PersonID = (int)reader["persons_id"];
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["LastName"].ToString();
                            nurseList.Add(nurse);
                        }
                    }
                }
            }
            return nurseList;


        }
        /// <summary>
        /// Method to retrieve a persons_id for a given employee based on their nurse ID. Only selects active employees
        /// </summary>
        /// <param name="id">nurse ID for the user we want a persons ID for</param>
        /// <returns>int of the persons_id</returns>
        public int GetNurseByID(int id)
        {
            string selectStatement = "SELECT persons_id FROM nurses WHERE id = @id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(reader.GetOrdinal("persons_id"));

                        }
                        else
                        {
                            return 0;
                        }


                    }
                }
            }


        }

        public Nurse GetNurseStatus(Nurse nurse)
        {
            string selectStatement = "SELECT status FROM nurses WHERE id = @id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@id", nurse.NurseID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nurse.Status = reader["status"].ToString();

                        }


                    }

                    return nurse;
                }

            }
        }

        public bool UpdateNurseStatus(Nurse nurse, string status)
        {
            string updateStatement = "UPDATE nurses " +
                                 "SET status = @status " +
                                 "WHERE Id = @Id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@Id", nurse.NurseID);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("NurseID " + nurse.NurseID + " has been updated.");
                }

                connection.Close();
                return true;

            }
        }

        /// <summary>
        /// Adds a Nurse to the table that already exists as a person
        /// </summary>
        /// <param name="person">The person the admin has entered</param>
        public void AddNurseExistingPerson(Person person)
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

            string insertStatementNurse =
                "INSERT nurses " +
                    "(status, persons_id) " +
                "VALUES ('A', @personId)";

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

                    SqlCommand insertCommandNurse = new SqlCommand(insertStatementNurse, connection, transaction);
                    insertCommandNurse.Parameters.AddWithValue("@personId", personID);
                    insertCommandNurse.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }

        /// <summary>
        /// Adds a new Nurse to the table that does not exist as a person
        /// </summary>
        /// <param name="person">The person the admin has entered</param>
        public void AddNurseNewPerson(Person person)
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

            string insertStatementNurse =
                "INSERT nurses " +
                    "(status, persons_id) " +
                "VALUES ('A', @personId)";

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

                    SqlCommand insertCommandNurse = new SqlCommand(insertStatementNurse, connection, transaction);
                    insertCommandNurse.Parameters.AddWithValue("@personId", personID);
                    insertCommandNurse.ExecuteNonQuery();

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
