using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_ClinicDB.Model
{
   public class Visits
    {


        /// <summary>
        /// The Visits DB model class.
        /// </summary>
        public int Id { get; set; }
        public int appointment_id { get; set; }
        public Decimal weight { get; set; }
        public Decimal height { get; set; }
        public int bodyTemparature { get; set; }

        public int pulse { get; set; }

        public string symptoms { get; set; }

        public int nurseId { get; set; }

        
        public int bloodPressureSystolic { get; set; }

        public int bloodPressureDiastolic { get; set; }
        public string initialDiagnose { get; set; }
        public string finalDiagnose { get; set; }


        /// <summary>
        /// constructor
        /// </summary>
        public Visits()
        {

        }
    }
}