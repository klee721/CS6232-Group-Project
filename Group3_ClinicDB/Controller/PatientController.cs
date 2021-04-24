using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;
using System;
using System.Collections.Generic;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// Controller for handling the Patient table from the Clinic DB
    /// </summary>
    public class PatientController
    {
        PatientDBDAL patientDBSource;

        /// <summary>
        /// Loads the Patient controller
        /// </summary>
        public PatientController()
        {
            this.patientDBSource = new PatientDBDAL();
        }

        /// <summary>
        /// Retrieves all patients from the DB
        /// </summary>
        /// <returns>Returns a list of all Patients from the DB</returns>
        public List<Patient> GetAllPatients()
        {
            return this.patientDBSource.GetAllPatients();
        }

        /// <summary>
        /// Retrieves the patients with the date of birth specified
        /// </summary>
        /// <param name="dateOfBirth">The date of birth for the patients</param>
        /// <returns>The patients with the date of birth specified</returns>
        public List<Patient> GetPatientsByDob(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new Exception("Date of birth cannot be null");
            }

            return this.patientDBSource.GetPatientsByDob(dateOfBirth);
        }

        /// <summary>
        /// Retrieves the patients with the first and last name specified
        /// </summary>
        /// <param name="firstName">The first name for the patients</param>
        /// <param name="lastName">The last name for the patients</param>
        /// <returns>The patients with the first and last name specified</returns>
        public List<Patient> GetPatientsByFnln(string firstName, string lastName)
        {
            if (firstName.Length == 0)
            {
                throw new Exception("First Name cannot be empty");
            }

            if (lastName.Length == 0)
            {
                throw new Exception("Last Name cannot be empty");
            }

            return this.patientDBSource.GetPatientsByFnln(firstName, lastName);
        }

        /// <summary>
        /// Retrieves the patients with the date of birth and last name specified
        /// </summary>
        /// <param name="dateOfBirth">The date of birth for the patients</param>
        /// <param name="lastName">The last name for the patients</param>
        /// <returns>The patients with the date of birth and last name specified</returns>
        public List<Patient> GetPatientsByDobln(DateTime dateOfBirth, string lastName)
        {
            if (dateOfBirth == null)
            {
                throw new Exception("Date of birth cannot be null");
            }

            if (lastName.Length == 0)
            {
                throw new Exception("Last Name cannot be empty");
            }

            return this.patientDBSource.GetPatientsByDobln(dateOfBirth, lastName);
        }

        /// <summary>
        /// Adds a Patient to the table that already exists as a person
        /// </summary>
        /// <param name="person">The person the nurse has entered</param>
        public void AddPatientExistingPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("Person cannot be null");
            }

            this.patientDBSource.AddPatientExistingPerson(person);
        }

        /// <summary>
        /// Adds a Patient to the table that does not exist as a person
        /// </summary>
        /// <param name="person">The person the nurse has entered</param>
        public void AddPatientNewPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("Person cannot be null");
            }

            this.patientDBSource.AddPatientNewPerson(person);
        }

        /// <summary>
        /// Deletes a Patient from the table
        /// </summary>
        /// <param name="patient">The patient the nurse wants to delete</param>
        /// <returns>If a patient was deleted or not</returns>
        public bool DeletePatient(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentException("Person cannot be null");
            }

            return this.patientDBSource.DeletePatient(patient);
        }
    }
}
