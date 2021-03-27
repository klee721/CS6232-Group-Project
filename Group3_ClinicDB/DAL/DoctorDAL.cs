using Group3_ClinicDB.Model;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Group3_ClinicDB.DAL
{
    class DoctorDAL
    {
        /// <summary>
        /// Public method for retrieving a list of all Doctors in the DB as a List of Doctor objects
        /// </summary>
        /// <returns>a List containing all of the Doctors in the DB</returns>
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> docList = new List<Doctor>();

            string selectStatement = "SELECT d.Id, d.persons_id, p.firstName, p.lastName FROM doctors as d "
                + "JOIN persons as p "
                + "ON d.persons_id = p.id";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor();
                            doctor.DoctorID = (int)reader["Id"];
                            doctor.PersonID = (int)reader["persons_id"];
                            doctor.FirstName = reader["firstName"].ToString();
                            doctor.LastName = reader["LastName"].ToString();
                            docList.Add(doctor);
                        }
                    }
                }
            }
            return docList;


        }
    }
}
