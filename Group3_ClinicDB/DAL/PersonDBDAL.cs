using Group3_ClinicDB.Model;
using System;
using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// The DAL for the persons to connect to the DB
    /// </summary>
    public class PersonDBDAL
    {
        /// <summary>
        /// Uses Clinic DB to retrieve the id of a person
        /// </summary>
        /// <param name="person">The person whose ID will be retrieved from the DB</param>
        /// <returns>The id of a person</returns>
        public int GetPersonId(Person person)
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

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
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
                }
            }
            return personID;
        }

        /// <summary>
        /// Uses Clinic DB to check if a ssn already exists
        /// </summary>
        /// <param name="person">The person whose ssn will be retrieved from the DB</param>
        /// <returns>Where a ssn exists in the DB or not</returns>
        public bool SsnExists(Person person)
        {
            string selectStatement =
                  "SELECT count(id) " +
                    "FROM persons " +
                    "WHERE SSN = @ssn";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@ssn", person.Ssn);

                    int count = (int) selectCommand.ExecuteScalar();
                    
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Uses Clinic DB to add Person
        /// </summary>
        /// <param name="person">the person to be added to the DB</param>
        public void AddPerson(Person person)
        {
            string insertStatement =
                "INSERT Persons " +
                    "(firstName, lastName, dateOfBirth, gender, ssn, address1, address2, city, state, zipCode, phoneNumber) " +
                "VALUES (@firstName, @lastName, @dateOfBirth, @gender, @ssn, @address1, @address2, @city, @state, @zipcode, @phoneNumber)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                    insertCommand.Parameters.AddWithValue("@lastName", person.LastName);
                    insertCommand.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth.ToShortDateString());
                    insertCommand.Parameters.AddWithValue("@gender", person.Gender);
                    insertCommand.Parameters.AddWithValue("@ssn", person.Ssn);
                    insertCommand.Parameters.AddWithValue("@address1", person.Address1);

                    if (person.Address2.Equals(""))
                    {
                        insertCommand.Parameters.AddWithValue("@address2", DBNull.Value);
                    }
                    else
                    {
                        insertCommand.Parameters.AddWithValue("@address2", person.Address2);
                    }
                    
                    insertCommand.Parameters.AddWithValue("@city", person.City);
                    insertCommand.Parameters.AddWithValue("@state", person.State);
                    insertCommand.Parameters.AddWithValue("@zipcode", person.ZipCode);
                    insertCommand.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
