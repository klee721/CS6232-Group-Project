using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            string selectStatement = "SELECT userName, password, admin_id, nurse_id, doctor_id, patient_id from login " +
                "WHERE userName = @name AND password = @password";


            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@name", name);
                    selectCommand.Parameters.AddWithValue("@password", password);

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





    }
}
