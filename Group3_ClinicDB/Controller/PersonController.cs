﻿using Group3_ClinicDB.DAL;
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

        public int GetPersonId(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("person cannot be null");
            }
            return this.personsDBSource.GetPersonId(person);
        }

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
    }
}
