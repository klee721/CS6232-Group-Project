using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.DAL
{
    class LoginDAL
    {
        /// <summary>
        /// Public DAL method to retrieve a List of all registered users and their associated ID numbers if they have any
        /// </summary>
        /// <returns>a List of User objects</returns>
        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            string selectStatement = "SELECT userName, password, admin_id, nurse_id, doctor_id, patient_id from login";
             
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.userName = reader["userName"].ToString();
                            if (reader["admin_id"].ToString() == "null")
                            {
                                user.adminID = (int)reader["admin_id"];
                            }
                            if (reader["nurse_id"].ToString() == "null")
                            {
                                user.nurseID = (int)reader["nurse_id"];
                            }
                            if (reader["doctor_id"].ToString() == "null")
                            {
                                user.doctorID = (int)reader["doctor_id"];
                            }
                            if (reader["patient_id"].ToString() == "null")
                            {
                                user.patientID = (int)reader["patient_id"];
                            }
                        
                            userList.Add(user);
                        }
                    }
                }
            }
           
            return userList;
        }

        public List<User> GetUserByNameAndPassword(string name, string password)
        {
            List<User> userList = new List<User>();

            string selectStatement = "SELECT userName, admin_id, nurse_id, doctor_id, patient_id from login " +
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
                            User user = new User();
                            user.userName = reader["userName"].ToString();
                            if (reader["admin_id"].ToString() == "null")
                            {
                                user.adminID = (int)reader["admin_id"];
                            }
                            if (reader["nurse_id"].ToString() == "null")
                            {
                                user.nurseID = (int)reader["nurse_id"];
                            }
                            if (reader["doctor_id"].ToString() == "null")
                            {
                                user.doctorID = (int)reader["doctor_id"];
                            }
                            if (reader["patient_id"].ToString() == "null")
                            {
                                user.patientID = (int)reader["patient_id"];
                            }

                            userList.Add(user);
                        }
                    }
                }
            }

            return userList;
        }



    }
}
