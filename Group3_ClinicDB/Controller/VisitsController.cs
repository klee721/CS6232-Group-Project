using System;
using System.Collections.Generic;
using Group3_ClinicDB.DAL;
using Group3_ClinicDB.Model;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// IncidentController class for the Incidents. This serves as the controller
    /// </summary>
    public class VisitsController
    {
        private VisitsDAL visitsSource;

       
        private int patientId;

        /// <summary>
        /// Constructor
        /// </summary>

        public VisitsController()
        {
            this.visitsSource = new VisitsDAL();
            

            this.patientId = new int();

        }

        /// <summary>
        /// GetCustomers method to list the customers
        /// </summary>
        public List<Visits> GetVisits()
        {
            return this.visitsSource.GetVisits();
        }

        /// <summary>
        /// GetVisitsByPatient method to list the visits of a patient
        /// </summary>
        public List<Visits> GetVisitsByPatient(int patient_id)
        {
            return this.visitsSource.GetVisitsByPatient(patient_id);
        }

        /// <summary>
        /// GetVisitsByID method to get the visit 
        /// </summary>
        public Visits GetVisitsByID(int visitID)
        {
            return this.visitsSource.GetVisitDetails(visitID);
        }

        /// <summary>
        /// Add method to add the visit to the database
        /// </summary>
        public bool AddVisit(Visits visit)
        {

            if (visit == null)
            {
                throw new ArgumentNullException("visit cannot be null");
            }

            return this.visitsSource.Add(visit);

        }

        /// <summary>
        /// Add method to add the visit to the database
        /// </summary>

        public bool UpdateVisit(Visits oldVisit, Visits newVisit)
        {

            if (oldVisit == null)
            {
                throw new ArgumentNullException("Old visit cannot be null");
            }

            if (newVisit == null)
            {
                throw new ArgumentNullException("New visit cannot be null");
            }

            return this.visitsSource.UpdateVisit(oldVisit, newVisit);

        }

    }
}
