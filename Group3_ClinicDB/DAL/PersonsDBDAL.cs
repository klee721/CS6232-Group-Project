using Group3_ClinicDB.Model;
using System;
using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// The DAL for the persons to connect to the DB
    /// </summary>
    public class PersonsDBDAL
    {
        /// <summary>
        /// Uses Clinic DB to add Person
        /// </summary>
        /// <param name="person">the person to be added to the DB</param>
        public void AddPerson(Persons person)
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
                    insertCommand.Parameters.AddWithValue("@lastName", person.FirstName);
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
