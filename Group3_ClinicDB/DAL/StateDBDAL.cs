using Group3_ClinicDB.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// The DAL for the state to connect to the DB
    /// </summary>
    public class StateDBDAL
    {
        /// <summary>
        /// Returns a list of all states in the DB
        /// </summary>
        /// <returns>a list of all states in the DB</returns>
        public List<State> GetStates()
        {
            List<State> statesList = new List<State>();

            string selectStatement = "SELECT stateCode, name FROM state";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            State state = new State();
                            state.StateCode = reader["stateCode"].ToString();
                            state.Name = reader["name"].ToString();

                            statesList.Add(state);
                        }
                    }
                }
            }
            return statesList;
        }
    }
}
