using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;
using System.Collections.Generic;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// Controller for handling the State table from the Clinic DB
    /// </summary>
    public class StateController
    {
        private StateDBDAL stateDBSource;

        /// <summary>
        /// Loads the State controller
        /// </summary>
        public StateController()
        {
            this.stateDBSource = new StateDBDAL();
        }

        /// <summary>
        /// Grabs all the states from the DB
        /// </summary>
        /// <returns></returns>
        public List<State> GetStates()
        {
            return this.stateDBSource.GetStates();
        }
    }
}
