using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    class DoctorController
    {
        DoctorDAL doctorSource;

        public DoctorController()
        {
            this.doctorSource = new DoctorDAL();
        }

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of all Doctors in the DB
        /// </summary>
        /// <returns>a List of Doctor objects for all doctors in the DB</returns>
        public List<Doctor> GetAllDoctors()
        {
            return this.doctorSource.GetAllDoctors();

        }
    }
}
