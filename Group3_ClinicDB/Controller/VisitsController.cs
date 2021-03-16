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

       


    }
}
