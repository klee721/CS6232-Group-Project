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
        /*
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
        */
        /// <summary>
        /// Updates new patient information to the table on the old patient information
        /// </summary>
        /// <param name="oldPatient">The old patient</param>
        /// <param name="newPatient">The new patient</param>
        /// <returns>Whether or not the update completes</returns>
        public bool UpdatePerson(Patient oldPatient, Patient newPatient)
        {
            string updateStatement =
                "UPDATE Persons " +
                    "SET firstName = @newFirstName, lastName = @newLastName, dateOfBirth = @newDateOfBirth, " +
                    "gender = @newGender, ssn = @newSsn, address1 = @newAddress1, address2 = @newAddress2, " +
                    "city = @newCity, state = @newState, zipcode = @newZipCode, phoneNumber = @newPhoneNumber " +
                "WHERE id = @oldID " +
                "AND firstName = @oldFirstName " +
                "AND lastName = @oldLastName " +
                "AND dateOfBirth = @oldDateOfBirth " +
                "AND gender = @oldGender " +
                "AND ssn = @oldSsn " +
                "AND address1 = @oldAddress1 " +
                "AND ISNULL(address2,'') = @oldAddress2 " +
                "AND city = @oldCity " +
                "AND state = @oldState " +
                "AND zipcode = @oldZipCode " +
                "AND phoneNumber = @oldPhoneNumber";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newFirstName", newPatient.FirstName);
                    updateCommand.Parameters.AddWithValue("@newLastName", newPatient.LastName);
                    updateCommand.Parameters.AddWithValue("@newDateOfBirth", newPatient.DateOfBirth.ToShortDateString());
                    updateCommand.Parameters.AddWithValue("@newGender", newPatient.Gender);
                    updateCommand.Parameters.AddWithValue("@newSsn", newPatient.SSN);
                    updateCommand.Parameters.AddWithValue("@newAddress1", newPatient.Address1);

                    if (newPatient.Address2.Equals(""))
                    {
                        updateCommand.Parameters.AddWithValue("@newAddress2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@newAddress2", newPatient.Address2);
                    }
                    
                    updateCommand.Parameters.AddWithValue("@newCity", newPatient.City);
                    updateCommand.Parameters.AddWithValue("@newState", newPatient.State);
                    updateCommand.Parameters.AddWithValue("@newZipCode", newPatient.ZipCode);
                    updateCommand.Parameters.AddWithValue("@newPhoneNumber", newPatient.PhoneNumber);

                    updateCommand.Parameters.AddWithValue("@oldID", oldPatient.PersonsId);
                    updateCommand.Parameters.AddWithValue("@oldFirstName", oldPatient.FirstName);
                    updateCommand.Parameters.AddWithValue("@oldLastName", oldPatient.LastName);
                    updateCommand.Parameters.AddWithValue("@oldDateOfBirth", oldPatient.DateOfBirth.ToShortDateString());
                    updateCommand.Parameters.AddWithValue("@oldGender", oldPatient.Gender);
                    updateCommand.Parameters.AddWithValue("@oldSsn", oldPatient.SSN);
                    updateCommand.Parameters.AddWithValue("@oldAddress1", oldPatient.Address1);
                    updateCommand.Parameters.AddWithValue("@oldAddress2", oldPatient.Address2);
                    updateCommand.Parameters.AddWithValue("@oldCity", oldPatient.City);
                    updateCommand.Parameters.AddWithValue("@oldState", oldPatient.State);
                    updateCommand.Parameters.AddWithValue("@oldZipCode", oldPatient.ZipCode);
                    updateCommand.Parameters.AddWithValue("@oldPhoneNumber", oldPatient.PhoneNumber);

                    int count = updateCommand.ExecuteNonQuery();
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
        /// Public method to retrieve a User's first and last name and store it in a User object
        /// </summary>
        /// <param name="user">a User object that may only contain a nurseID or an adminID</param>
        /// <returns>the same user object with the first and last name updated </returns>
        public User GetUserFullName(User user)
        {
            User updatedUser = user;

            if (updatedUser.adminID != 0)
            {
                string selectStatement = "SELECT firstName, lastName FROM persons AS p " +
                    "INNER JOIN clinicadmins as c " + 
                    "ON p.id = c.persons_id " +
                    "WHERE c.id = @id";

                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@id", updatedUser.adminID);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                updatedUser.firstName = reader["firstName"].ToString();
                                updatedUser.lastName = reader["lastName"].ToString();

                            }
                        }
                    }
                }

                return updatedUser;
            }

            if (updatedUser.nurseID != 0)
            {
                string selectStatement = "SELECT firstName, lastName FROM persons AS p " +
                    "INNER JOIN nurses as n " +
                    "ON p.id = n.persons_id " +
                    "WHERE n.id = @id";

                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {

                        selectCommand.Parameters.AddWithValue("@id", updatedUser.nurseID);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                updatedUser.firstName = reader["firstName"].ToString();
                                updatedUser.lastName = reader["lastName"].ToString();

                            }
                        }
                    }
                }


                return updatedUser;
            }

            return updatedUser;
        }

    }
}
