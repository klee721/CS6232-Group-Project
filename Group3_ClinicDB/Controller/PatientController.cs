﻿using Group3_ClinicDB.DAL;
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
        /// Retrieves the patient id with the date of birth specified
        /// </summary>
        /// <param name="dateOfBirth">The date of birth for the patient</param>
        /// <returns>The patient with the date of birth specified</returns>
        public Patient GetPatientByDob(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new Exception("Date of birth cannot be null");
            }

            return this.patientDBSource.GetPatientByDob(dateOfBirth);
        }

        /// <summary>
        /// Adds a Patient to the table based on the Id
        /// </summary>
        /// <param name="personId"></param>
        public void AddPatient(int personId)
        {
            if (personId <= 0)
            {
                throw new ArgumentException("Patient ID cannot be less than or equal to 0");
            }

            this.patientDBSource.AddPatient(personId);
        }


    }
}
