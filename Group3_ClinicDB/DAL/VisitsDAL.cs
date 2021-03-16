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
    public class VisitsDAL
    {
		/// <summary>
        ///method to get incidents which are open
        /// </summary>
        /// <returns>a list of Incidents</returns>


        public List<Visits> GetVisits()
        {
            List<Visits> visitList = new List<Visits>();

            string selectStatement =
			
			"SELECT Id,appointment_id,weight,height,bodyTemparature,pulse " +
      ",symptoms,nurseId,bloodPressureSystolic,bloodPressureDiastolic " +
      ",initialDiagnose,finalDiagnose " +
       " FROM dbo.visits ";


	  int id;
            int appointment_id;
            decimal weight;
            decimal height;
            int bodyTemparature;
            int pulse;
            string symptoms;
            int nurseId;
            int bloodPressureSystolic;
            int bloodPressureDiastolic;
      string initialDiagnose;
      string finalDiagnose;

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (System.Data.SqlClient.SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("Id");
                        int appointmentIdOrd = reader.GetOrdinal("appointment_id");
                        int weightOrd = reader.GetOrdinal("weight");
                        int heightOrd = reader.GetOrdinal("height");
                        int bodyTemparatureOrd = reader.GetOrdinal("bodyTemparature");
						int pulseOrd = reader.GetOrdinal("pulse");
                        int symptomsOrd = reader.GetOrdinal("symptoms");
                        int nurseIdOrd = reader.GetOrdinal("nurseId");
                        int bloodPressureSystolicOrd = reader.GetOrdinal("bloodPressureSystolic");
                        int bloodPressureDiastolicOrd = reader.GetOrdinal("bloodPressureDiastolic");
						int initialDiagnoseOrd = reader.GetOrdinal("initialDiagnose");
                        int finalDiagnoseOrd = reader.GetOrdinal("finalDiagnose");

                        while (reader.Read())
                        {
							
							 id = reader.GetInt32(idOrd);
      appointment_id = reader.GetInt32(appointmentIdOrd);
      weight = reader.GetDecimal(weightOrd);
      height = reader.GetDecimal(heightOrd);
      bodyTemparature = reader.GetInt32(bodyTemparatureOrd);
      pulse = reader.GetInt32(pulseOrd);
      symptoms = reader.GetString(symptomsOrd);
      nurseId = reader.GetInt32(nurseIdOrd);
      bloodPressureSystolic = reader.GetInt32(bloodPressureSystolicOrd);
      bloodPressureDiastolic = reader.GetInt32(bloodPressureDiastolicOrd);
      initialDiagnose = reader.GetString(initialDiagnoseOrd);
      finalDiagnose = reader.GetString(finalDiagnoseOrd);
	  
                            
                            Visits visit = new Visits();
                            visit.Id = id;
                            visit.appointment_id = appointment_id;
                            visit.weight = weight;
                            visit.height = height;
                            visit.bodyTemparature = bodyTemparature;
                            visit.pulse = pulse;
                            visit.symptoms = symptoms;
                            visit.nurseId = nurseId;
                            visit.bloodPressureSystolic = bloodPressureSystolic;
                            visit.bloodPressureDiastolic = bloodPressureDiastolic;
                            visit.initialDiagnose = initialDiagnose;
                            visit.finalDiagnose = finalDiagnose;
                            visitList.Add(visit);
                        }
                    }
                }


            }
            return visitList;
        }

	
    }
}
	