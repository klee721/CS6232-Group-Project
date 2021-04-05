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

        public Visits GetVisitDetails(int visitID)
        {
            List<Visits> visitList = new List<Visits>();
            Visits visit = new Visits();

            string selectStatement =

            "SELECT Id,appointment_id,weight,height,bodyTemparature,pulse " +
      ",symptoms,nurseId,bloodPressureSystolic,bloodPressureDiastolic " +
      ",initialDiagnose,ISNULL(finalDiagnose, ' ') finalDiagnose " +
      " FROM dbo.visits Where ID = @ID";



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
                    selectCommand.Parameters.AddWithValue("@ID", visitID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
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

                        if (reader.Read())
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
                           // visitList.Add(visit);
                        }
                    }
                }


            }
            return visit;
        }

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
      ",initialDiagnose,ISNULL(finalDiagnose, ' ') finalDiagnose " +
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
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
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

        /// <summary>
        ///method to get incidents which are open
        /// </summary>
        /// <returns>a list of Incidents</returns>

        public List<Visits> GetVisitsByPatient(int patient_Id)
        {
            List<Visits> visitList = new List<Visits>();

            string selectStatement =
            "SELECT visit.Id," +
      " visit.appointment_id," +
      " visit.weight," +
      " visit.height," +
      " visit.bodyTemparature," +
      " visit.pulse" +
      ",visit.symptoms" +
	  ",visit.nurseId" +
	  ",visit.bloodPressureSystolic" +
	  ",visit.bloodPressureDiastolic" +
      ",visit.initialDiagnose" +
	  ",ISNULL(visit.finalDiagnose, ' ') finalDiagnose" +
      " FROM dbo.visits visit JOIN dbo.appointments app on(app.Id = visit.appointment_id)" +
      "where app.patientId = @patient_Id";


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
                    selectCommand.Parameters.AddWithValue("@patient_Id", patient_Id);
                    
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
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


        /// <summary>
        ///Method to insert Visit 
        ///
        /// </summary>
        /// <returns>none</returns>


        public bool Add(Visits visit)
        {


            if (visit == null)
            {
                throw new ArgumentNullException("visit cannot be null");
            }

            string selectStatement = "insert into visits(appointment_id, weight, height, bodyTemparature, pulse " +
      ", symptoms, nurseId, bloodPressureSystolic, bloodPressureDiastolic "+
      ", initialDiagnose, finalDiagnose) values "+
       " (@appointment_id, @weight, @height, @bodyTemparature, @pulse "+
        ", @symptoms, @nurseId, @bloodPressureSystolic, @bloodPressureDiastolic "+
        ", @initialDiagnose, @finalDiagnose) ";

           
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {

                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (String.IsNullOrEmpty(visit.symptoms))
                    {
                        selectCommand.Parameters.AddWithValue("@symptoms", DBNull.Value);
                    }
                    else
                        selectCommand.Parameters.AddWithValue("@symptoms", visit.symptoms);
                    if (String.IsNullOrEmpty(visit.initialDiagnose))
                    {
                        selectCommand.Parameters.AddWithValue("@initialDiagnose", DBNull.Value);
                    }
                    else
                        selectCommand.Parameters.AddWithValue("@initialDiagnose", visit.initialDiagnose);

                    if (String.IsNullOrEmpty(visit.finalDiagnose))
                    {
                        selectCommand.Parameters.AddWithValue("@finalDiagnose", DBNull.Value);
                    }
                    else
                        selectCommand.Parameters.AddWithValue("@finalDiagnose", visit.finalDiagnose);

                    selectCommand.Parameters.AddWithValue("@appointment_id", visit.appointment_id);
                    selectCommand.Parameters.AddWithValue("@weight", visit.weight);
                    selectCommand.Parameters.AddWithValue("@height", visit.height);
                    selectCommand.Parameters.AddWithValue("@bodyTemparature", visit.bodyTemparature);
                    selectCommand.Parameters.AddWithValue("@pulse", visit.pulse);
                    selectCommand.Parameters.AddWithValue("@nurseId", visit.nurseId);
                    selectCommand.Parameters.AddWithValue("@bloodPressureSystolic", visit.bloodPressureSystolic);
                    selectCommand.Parameters.AddWithValue("@bloodPressureDiastolic", visit.bloodPressureDiastolic); 
                    selectCommand.ExecuteNonQuery();

                }

                return true;

            }

        }

        /// <summary>
        ///Method to update Visit 
        ///
        /// </summary>
        /// <returns>none</returns>

        public bool UpdateVisit(Visits oldVisit, Visits newVisit)
        {
            string updateStatement = "";
            
            if (String.IsNullOrEmpty(oldVisit.finalDiagnose))
            {
                updateStatement = "Update Visits set finalDiagnose = @NewFinalDiagnose " +
             "where ID = @OldVisitID and finalDiagnose is null";
            } else
            {
                updateStatement = "Update Visits set finalDiagnose = @NewFinalDiagnose " +
             "where ID = @OldVisitID and ISNULL(finalDiagnose,'') = @OldFinalDiagnose";

            }


            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {

                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(updateStatement, connection))
                {
                    

                    if (newVisit.finalDiagnose == "")
                    {
                        selectCommand.Parameters.AddWithValue("@NewFinalDiagnose", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@NewFinalDiagnose", newVisit.finalDiagnose);
                    }

                    if (oldVisit.finalDiagnose == "")
                    {
                        selectCommand.Parameters.AddWithValue("@OldFinalDiagnose", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@OldFinalDiagnose", oldVisit.finalDiagnose);
                    }

                    
                    
                    selectCommand.Parameters.AddWithValue("@OldVisitID", oldVisit.Id);
                    
                    int count = selectCommand.ExecuteNonQuery();
                    if (count > 0)
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
    }
}
