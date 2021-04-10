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

            int adminID;
            int nurseID;
            int doctorID;
            int patientID;

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

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
                            adminID = reader.GetInt32(adminIDOrd);
                            nurseID = reader.GetInt32(nurseIDOrd);
                            doctorID = reader.GetInt32(doctorIDOrd);
                            patientID = reader.GetInt32(patientIDOrd);


                            user.adminID = adminID;
                            user.nurseID = nurseID;
                            user.doctorID = doctorID;
                            user.patientID = patientID;

                          
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



    }
}
