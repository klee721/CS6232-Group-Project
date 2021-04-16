using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.DAL;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// This the DAL class that deals with incidents.
    /// </summary>
    public class LabTestDAL
    {
        /// <summary>
        ///method to get all test codes
        /// </summary>
        /// <returns>a List containing all of the tests in the DB</returns>
        public List<Test> GetAllTests()
        {
            List<Test> testList = new List<Test>();

            string selectStatement = "SELECT testCode,Name,description from dbo.tests";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test();
                            test.TestCode = reader["testCode"].ToString();
                            test.Name = reader["Name"].ToString();
                            test.Description = reader["description"].ToString();
                            testList.Add(test);
                        }
                    }
                }
            }
            return testList;


        }

        /// <summary>
        /// Method to retrieve a Tests for a given code 
        /// </summary>
        /// <param name="id">nurse ID for the user we want a persons ID for</param>
        /// <returns>int of the persons_id</returns>
        public Test GetTestByCode(string code)
        {
            string selectStatement = " select testcode, Name, description " +
                "from dbo.tests where testCode = @code";
            Test test = new Test();
               
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@code", code);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            test.TestCode = reader["testCode"].ToString();
                            test.Name = reader["Name"].ToString();
                            test.Description = reader["description"].ToString();


                            
                        }
                        return test;

                    }
                }
            }
                       
        }

        /// <summary>
        /// Method to add a new appointment to the database 
        /// </summary>
        /// <param name="appointment">an Appointment object containing the data that will be written to the DB</param>
        /// <returns>a bool flag indicating write success</returns>
        /// 

        public bool OrderLabTest(LabTest labTest)
        {
            if (labTest == null)
            {
                throw new ArgumentNullException("Test cannot be null");

            }

            string insertStatement = "INSERT INTO labtests (patientId ,testCode,orderDateTime, normal) "
                + "VALUES (@patientID, @testCode, @orderDateTime, @normal)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@patientID", labTest.PatientID);
                    insertCommand.Parameters.AddWithValue("@orderDateTime", labTest.OrderDateTime);
                    insertCommand.Parameters.AddWithValue("@testCode", labTest.TestCode);
                    insertCommand.Parameters.AddWithValue("@normal", "Y"); 
                    insertCommand.ExecuteNonQuery();

                }

            }

            return true;
        }


        /// <summary>
        ///method to get labtests which are open
        /// </summary>
        /// <returns>a list of Incidents</returns>

        public List<LabTest> GetLabTestsByPatient(int patient_Id)
        {
            List<LabTest> labList = new List<LabTest>();

            string selectStatement =
                " SELECT lab.patientId,lab.orderDateTime,lab.performedDateTime,lab.testCode,lab.results,lab.normal,tes.Name " +
                "FROM labtests lab, tests tes where tes.testCode = lab.testCode and patientId = @patient_Id";
            
            int patientId;
            DateTime orderDateTime;
            DateTime performedDateTime;
            string testCode;
            string results;
            string normal;
            string name;

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patient_Id", patient_Id);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
              
                        while (reader.Read())
                        {

                            LabTest labTest = new LabTest();
                        
                            labTest.PatientID = (int)reader["patientId"]; ;
                            labTest.OrderDateTime = (DateTime)reader["orderDateTime"];
                            if (reader["performedDateTime"] != DBNull.Value)
                            {
                                labTest.PerformedDateTime = (DateTime)reader["performedDateTime"];
                            }
                            
                            labTest.TestCode = reader["testCode"].ToString() ;
                            labTest.Results = reader["results"].ToString();
                            labTest.Normal = reader["normal"].ToString();
                            labTest.Name = reader["Name"].ToString();
                           
                            labList.Add(labTest);
                        }
                    }
                }

            }
            return labList;
        }

        /// <summary>
        ///method to get labtests which are open
        /// </summary>
        /// <returns>boolean </returns>

        public bool GetOpenLabTestByPatient(int patient_Id, string testCode)
        {
            
            string selectStatement =
                " SELECT testCode " +
                "FROM labtests lab where patientId = @patient_Id and testCode = @testCode and performedDateTime is null ";

            
            string code = "";
            
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patient_Id", patient_Id);
                    selectCommand.Parameters.AddWithValue("@testCode", testCode);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            code = reader["testCode"].ToString();
                           
                        }

                       
                    }
                }

            }

            if (code == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
