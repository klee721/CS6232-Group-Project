using System;
using System.Collections.Generic;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    class LabTestController
    {
        LabTestDAL testSource;

        //LabTestReportDAL testReportSource;
        public LabTestController()
        {
            this.testSource = new LabTestDAL();
            //this.testReportSource = new LabTestReportDAL();
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
        /// Controller method to call on DAL method to retrieve report List of all Tests in the DB
        /// </summary>
        /// <returns>a List of report Test objects </returns>
       // public List<LabTestReport> GetLabTestReport(DateTime fromDate, DateTime toDate)
        //{
            //return this.testReportSource.GetLabTestReport(fromDate, toDate);

        //}

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of non-performed LabTests in the DB for a patient
        /// </summary>
        /// <returns>a List of Test objects for all Nurses in the DB</returns>
        public List<LabTest> GetAllLabTestsForPatientNotPerformed(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentException("patient cannot be null");
            }

            return this.testSource.GetAllLabTestsForPatientNotPerformed(patient);
        }

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of performed LabTests in the DB for a patient
        /// </summary>
        /// <returns>a List of Test objects for all Nurses in the DB</returns>
        public List<LabTest> GetAllLabTestsForPatientPerformed(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentException("patient cannot be null");
            }

            return this.testSource.GetAllLabTestsForPatientPerformed(patient);
        }

        /// <summary>
        /// Controller method to call on DAL method to retrieve List of performed based on visit id LabTests in the DB for a patient
        /// </summary>
        /// <returns>a List of Test objects for all Nurses in the DB</returns>
        public List<LabTest> GetAllLabTestsForPatientPerformedByVisitId(Patient patient, int visitId)
        {
            if (patient == null)
            {
                throw new ArgumentException("patient cannot be null");
            }

            return this.testSource.GetAllLabTestsForPatientPerformedByVisitId(patient, visitId);
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
        /// Deletes a Patient from the table
        /// </summary>
        /// <param name="patient">The patient the nurse wants to delete</param>
        /// <returns>If a patient was deleted or not</returns>
        public bool DeleteLabtest(LabTest labTest)
        {
            if (labTest == null)
            {
                throw new ArgumentException("labTest cannot be null");
            }

            return this.testSource.DeleteLabTest(labTest);
        }

        /// <summary>
        /// GetLabsByPatient method to list the labs of a patient
        /// </summary>
        public bool GetOpenLabTestByPatient(int patient_id, string testCode)
        {
            return this.testSource.GetOpenLabTestByPatient(patient_id,testCode);
        }

        /// <summary>
        /// Updates the lab test entered in the UC to the DB
        /// </summary>
        /// <param name="oldLabTest">The old lab test</param>
        /// <param name="newLabTest">The new lab test</param>
        public bool UpdateLabTest(LabTest oldLabTest, LabTest newLabTest)
        {
            if (oldLabTest == null || newLabTest == null)
            {
                throw new ArgumentException("A lab test cannot be null");
            }

            return this.testSource.UpdateLabTest(oldLabTest, newLabTest);
        }

    }
}
