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

        public Nurse GetNurseStatus(Nurse nurse)
        {
            return this.NurseSource.GetNurseStatus(nurse);
        }

        public bool UpdateNurseStatus(Nurse nurse, string status)
        {
            return this.NurseSource.UpdateNurseStatus(nurse, status);
        }

        /// <summary>
        /// Adds a Nurse to the table that already exists as a person
        /// </summary>
        /// <param name="person">The person the admin has entered</param>
        public void AddNurseExistingPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("Person cannot be null");
            }

            this.NurseSource.AddNurseExistingPerson(person);
        }


        /// <summary>
        /// Adds a Nurse to the table that does not exist as a person
        /// </summary>
        /// <param name="person">The person the admin has entered</param>
        public void AddNurseNewPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("Person cannot be null");
            }

            this.NurseSource.AddNurseNewPerson(person);
        }



    }
}
