using System;
using System.Collections.Generic;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    class AdminController
    {
        AdminDAL adminSource;

        public AdminController()
        {
            this.adminSource = new AdminDAL();
        }

        /// <summary>
        /// Method to get the persons_id of a user based on their employee (nurse) id number
        /// </summary>
        /// <param name="id">nurse ID of the user we need more info for</param>
        /// <returns>the persons ID for the employee</returns>
        public int GetAdminByID(int id)
        {
            return this.adminSource.GetAdminByID(id);
        }
    }

}
