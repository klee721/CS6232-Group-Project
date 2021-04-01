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
    }
}
