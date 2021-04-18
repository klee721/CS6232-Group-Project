using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.DAL
{
    class LoginDAL
    {
        /// <summary>
        /// Method to retrieve a List of Users based on a Username and Password. If a match is found, a List is returned with 1 element
        /// </summary>
        /// <param name="name">Username of the employee</param>
        /// <param name="password">Password of the employee</param>
        /// <returns>a List containing all (should be 1) users with the given username and password</returns>
        public List<User> GetUserByNameAndPassword(string name, string password)
        {
            List<User> userList = new List<User>();

            string selectStatement = "SELECT userName, passwordHash, admin_id, nurse_id, doctor_id, patient_id from login " +
                "WHERE userName = @name AND passwordHash = @password";


            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    Byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(password);
                    SHA512 shaM = new SHA512Managed();
                    Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

                    
                    selectCommand.Parameters.AddWithValue("@name", name);
                    selectCommand.Parameters.AddWithValue("@password", hashedBytes);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int adminIDOrd = reader.GetOrdinal("admin_id");
                            int nurseIDOrd = reader.GetOrdinal("nurse_id");
                            int doctorIDOrd = reader.GetOrdinal("doctor_id");
                            int patientIDOrd = reader.GetOrdinal("patient_id");



                            User user = new User();
                            user.userName = reader["userName"].ToString();
                            if (!reader.IsDBNull(reader.GetOrdinal("admin_id")))
                            {
                                user.adminID = reader.GetInt32(adminIDOrd);

                            }
                            if (!reader.IsDBNull(reader.GetOrdinal("nurse_id")))
                            {
                                user.nurseID = reader.GetInt32(nurseIDOrd);

                            }
                            if (!reader.IsDBNull(reader.GetOrdinal("doctor_id")))
                            {
                                user.doctorID = reader.GetInt32(doctorIDOrd);

                            }
                            if (!reader.IsDBNull(reader.GetOrdinal("patient_id")))
                            {
                                user.patientID = reader.GetInt32(patientIDOrd);

                            }







                            userList.Add(user);
                        }
                    }
                }
            }

            return userList;
        }


        public bool CreateNewUser(User user, string username, string password)
        {
            int idNumber;

            if (user.adminID != 0)
            {
                idNumber = user.adminID;

                string insertStatement =
                "INSERT INTO login " +
                    "(userName, passwordHash, admin_id) " +
                "VALUES (@username, @password, @adminID)";

                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        Byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(password);
                        SHA512 shaM = new SHA512Managed();
                        Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@password", hashedBytes);
                        insertCommand.Parameters.AddWithValue("@adminID", idNumber);

                        insertCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            if (user.nurseID != 0)
            {
                idNumber = user.nurseID;

                string insertStatement =
                "INSERT INTO login " +
                    "(userName, password, nurse_id) " +
                "VALUES (@username, @password, @nurseID)";

                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        Byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(password);
                        SHA512 shaM = new SHA512Managed();
                        Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@password", hashedBytes);
                        insertCommand.Parameters.AddWithValue("@nurseID", idNumber);

                        insertCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }

            return false;
        }



        /// <summary>
        /// Checks the table of Users to see if a given employee is already registered or not
        /// </summary>
        /// <param name="id">ID number of the employee in question</param>
        /// <returns>true if they are registered, false if not</returns>
        public bool IsNurseAUser(int id)
        {
            string selectStatement = "SELECT nurse_id FROM login " +
                "WHERE nurse_id = @id";


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
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Checks the table of Users to see if a given employee is already registered or not
        /// </summary>
        /// <param name="id">ID number of the employee in question</param>
        /// <returns>true if they are registered, false if not</returns>
        public bool IsAdminAUser(int id)
        {
            string selectStatement = "SELECT admin_id FROM login " +
                "WHERE admin_id = @id";


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
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Public that checks is a proposed username is unique to the DB
        /// </summary>
        /// <param name="username">a string the user is planning to use as a username</param>
        /// <returns>false if the name is NOT unique and can't be used, true if its unique and can be used</returns>
        public bool IsUsernameUnique(string username)
        {
            string selectStatement = "SELECT userName FROM login " +
                "WHERE userName = @username";


            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }

        }

        public string GetUsernameByNurseID(int nurseID)
        {
            string selectStatement = "SELECT userName FROM login WHERE nurse_id = @id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@id", nurseID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["userName"].ToString();

                        }
                        else
                        {
                            return "Not found.";
                        }


                    }


                }

            }
        }

        public bool UpdateUser(User user, string password)
        {
            string updateStatement = "UPDATE login " +
                                  "SET userName = @userName, passwordHash = @password " +
                                  "WHERE nurse_id = @Id";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    Byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(password);
                    SHA512 shaM = new SHA512Managed();
                    Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

                    cmd.Parameters.AddWithValue("@userName", user.userName);
                    cmd.Parameters.AddWithValue("@password", hashedBytes);
                    cmd.Parameters.AddWithValue("@Id", user.nurseID);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("User tied to NurseID " + user.nurseID + " has been updated.");
                }

                connection.Close();
                return true;

            }



        }
    }
}
