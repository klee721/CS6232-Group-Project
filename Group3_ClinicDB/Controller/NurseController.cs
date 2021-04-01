using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
