using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    class AdminDAL
    {

        /// <summary>
        /// Method to retrieve a persons_id for a given employee based on their admin ID
        /// </summary>
        /// <param name="id">admin ID for the user we want a persons ID for</param>
        /// <returns>int of the persons_id</returns>
        public int GetAdminByID(int id)
        {
            string selectStatement = "SELECT persons_id FROM clinicadmins " +
                "WHERE id = @id";
                

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
                            return reader.GetInt32(reader.GetOrdinal("persons_id"));

                        }
                        else
                        {
                            return 0;
                        }


                    }
                }
            }


        }


    }
}
