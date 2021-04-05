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
        /// Retrieves the patients with the date of birth and ssn specified
        /// </summary>
        /// <param name="dateOfBirth">The date of birth for the patients</param>
        /// <param name="ssn">The SSN for the patients</param>
        /// <returns>The patients with the date of birth and ssn specified</returns>
        public Patient GetPatientByDobWithSsn(DateTime dateOfBirth, string ssn)
        {
            if (dateOfBirth == null)
            {
                throw new Exception("Date of birth cannot be null");
            }

            if (ssn.Length == 0)
            {
                throw new Exception("SSN cannot be empty");
            }

            return this.patientDBSource.GetPatientByDobWithSsn(dateOfBirth, ssn);
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
        /// Retrieves the patients with the first, last name, and ssn specified
        /// </summary>
        /// <param name="firstName">The first name for the patients</param>
        /// <param name="lastName">The last name for the patients</param>
        /// <param name="ssn">The SSN for the patients</param>
        /// <returns>The patients with the first, last name, and ssn specified</returns>
        public Patient GetPatientByFnlnWithSsn(string firstName, string lastName, string ssn)
        {
            if (firstName.Length == 0)
            {
                throw new Exception("First Name cannot be empty");
            }

            if (lastName.Length == 0)
            {
                throw new Exception("Last Name cannot be empty");
            }

            return this.patientDBSource.GetPatientByFnlnWithSsn(firstName, lastName, ssn);
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
        /// Adds a Patient to the table based on the Id
        /// </summary>
        /// <param name="personId"></param>
        public void AddPatient(int personId)
        {
            if (personId < 0)
            {
                throw new ArgumentException("Patient ID cannot be less than or equal to 0");
            }

            this.patientDBSource.AddPatient(personId);
        }
    }
}
