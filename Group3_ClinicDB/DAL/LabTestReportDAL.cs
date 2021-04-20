using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.DAL
{
    /// <summary>
    /// This the DAL class that deals with lab tests.
    /// </summary>
    public class LabTestReportDAL
    {
        /// <summary>
        ///method to get all test codes
        /// </summary>
        /// <returns>a List containing all of the tests in the DB</returns>
        public List<LabTestReport> GetLabTestReport(DateTime fromDate, DateTime toDate)
        {
            List<LabTestReport> testList = new List<LabTestReport>();

            string selectStatement = "GetLabtestReport";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    selectCommand.Parameters.AddWithValue("@FromDate", fromDate);
                    selectCommand.Parameters.AddWithValue("@ToDate", toDate);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTestReport test = new LabTestReport();
                            test.TestCode = reader["testCode"].ToString();
                            test.Name = reader["Name"].ToString();
                            test.QualifiedTests = int.Parse(reader["qualified_test_counts"].ToString());
                            test.TotalTests = int.Parse(reader["total_tests"].ToString());
                            test.Totalpct = decimal.Parse(reader["total_pct"].ToString());
                            test.NormalCount = int.Parse(reader["normal_count"].ToString());
                            test.AbNormalCount = int.Parse(reader["Abnormal_count"].ToString());
                            test.Pct1929 = decimal.Parse(reader["pct_19_29"].ToString());
                            test.Pct3039 = decimal.Parse(reader["pct_30_39"].ToString());
                            test.OtherAgePct = decimal.Parse(reader["other_age_pct"].ToString());
                            testList.Add(test);
                        }
                    }
                }
            }
            return testList;
        }

       

        
    }
}
