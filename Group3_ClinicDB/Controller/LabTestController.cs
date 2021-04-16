﻿using System;
using System.Collections.Generic;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    class LabTestController
    {
        LabTestDAL testSource;

        public LabTestController()
        {
            this.testSource = new LabTestDAL();
        }

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of all Tests in the DB
        /// </summary>
        /// <returns>a List of Test objects for all Nurses in the DB</returns>
        public List<Test> GetAllTests()
        {
            return this.testSource.GetAllTests();

        }

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of all Tests in the DB
        /// </summary>
        ///  Test objects for the code in the DB</returns>
        public Test GetTestByCode(string code)
        {
            return this.testSource.GetTestByCode(code);

        }

        /// <summary>
        /// Method to add a new labtest to the DB
        /// </summary>
        /// <param name="labtest">Labtest object to be added to the DB</param>
        /// <returns>a bool true if successful</returns>
        public bool OrderLabTest(LabTest labTest)
        {
            if (labTest == null)
            {
                throw new ArgumentNullException("labTest cannot be null");
            }

            return this.testSource.OrderLabTest(labTest);

        }

        /// <summary>
        /// GetLabsByPatient method to list the labs of a patient
        /// </summary>
        public List<LabTest> GetLabsByPatient(int patient_id)
        {
            return this.testSource.GetLabTestsByPatient(patient_id);
        }

        /// <summary>
        /// GetLabsByPatient method to list the labs of a patient
        /// </summary>
        public bool GetOpenLabTestByPatient(int patient_id, string testCode)
        {
            return this.testSource.GetOpenLabTestByPatient(patient_id,testCode);
        }

        

    }
}
