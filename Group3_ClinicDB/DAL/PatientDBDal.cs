using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// The DAL for the Patient to connect to the DB
    /// </summary>
    public class PatientDBDAL
    {
        /// <summary>
        /// Adds a Patient to the table based on the Id
        /// </summary>
        /// <param name="patientId"></param>
        public void AddPatient(int patientId)
        {
            string insertStatement =
                "INSERT Patient " +
                    "(id) " +
                "VALUES (@patientId)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@patientId", patientId);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
