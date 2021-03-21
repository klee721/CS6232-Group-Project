using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// Controller for handling the Persons table from the Clinic DB
    /// </summary>
    public class PersonsController
    {
        PersonsDBDAL personsDBSource;

        /// <summary>
        /// Loads the Persons controller
        /// </summary>
        public PersonsController()
        {
            this.personsDBSource = new PersonsDBDAL();
        }

        /// <summary>
        /// Adds a Persons object to the DB
        /// </summary>
        public void AddPerson(Persons person)
        {
            if (person == null)
            {
                throw new ArgumentException("person cannot be null");
            }
            this.personsDBSource.AddPerson(person);
        }
    }
}
