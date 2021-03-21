using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public static class ClinicDBConnection
    {
        /// <summary>
        /// The static getConnection for database connection
        /// </summary>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g3;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }


}
