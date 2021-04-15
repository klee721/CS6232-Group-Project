using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;
using System;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// Controller for handling the Persons table from the Clinic DB
    /// </summary>
    public class PersonController
    {
        PersonDBDAL personsDBSource;

        /// <summary>
        /// Loads the Persons controller
        /// </summary>
        public PersonController()
        {
            this.personsDBSource = new PersonDBDAL();
        }

        /// <summary>
        /// Uses Clinic DB to retrieve the id of a person
        /// </summary>
        /// <param name="person">The person whose ID will be retrieved from the DB</param>
        /// <returns>The id of a person</returns>
        public int GetPersonId(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("person cannot be null");
            }
            return this.personsDBSource.GetPersonId(person);
        }

        /// <summary>
        /// Uses Clinic DB to check if a ssn already exists
        /// </summary>
        /// <param name="person">The person whose ssn will be retrieved from the DB</param>
        /// <returns>Where a ssn exists in the DB or not</returns>
        public bool SsnExists(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("person cannot be null");
            }
            return this.personsDBSource.SsnExists(person);
        }
        /*
        /// <summary>
        /// Adds a Persons object to the DB
        /// </summary>
        public void AddPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("person cannot be null");
            }
            this.personsDBSource.AddPerson(person);
        }
        */

        /// <summary>
        /// Updates personal info portion of an already existing patient
        /// </summary>
        /// <param name="oldPatient">The old patient</param>
        /// <param name="newPatient">The new patient</param>
        public bool UpdatePerson(Patient oldPatient, Patient newPatient)
        {
            if (oldPatient == null || newPatient == null)
            {
                throw new ArgumentException("a patient cannot be null");
            }

            return this.personsDBSource.UpdatePerson(oldPatient, newPatient);
        }

        public User GetUserFullName(User user)
        {
            return this.personsDBSource.GetUserFullName(user);
        }

    }
}
