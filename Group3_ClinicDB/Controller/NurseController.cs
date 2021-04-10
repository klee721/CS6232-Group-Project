using System;
using System.Collections.Generic;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    class NurseController
    {
        NurseDAL NurseSource;

        public NurseController()
        {
            this.NurseSource = new NurseDAL();
        }

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of all Nurses in the DB
        /// </summary>
        /// <returns>a List of Nurse objects for all Nurses in the DB</returns>
        public List<Nurse> GetAllNurses()
        {
            return this.NurseSource.GetAllNurses();

        }

        /// <summary>
        /// Method to get the persons_id of a user based on their employee (nurse) id number
        /// </summary>
        /// <param name="id">nurse ID of the user we need more info for</param>
        /// <returns>the persons ID for the employee</returns>
        public int GetNurseByID(int id)
        {
            return this.NurseSource.GetNurseByID(id);
        }

    }
}
