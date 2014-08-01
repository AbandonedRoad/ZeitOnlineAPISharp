using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeitOnlineAPISharp
{
    public class API
    {
        public String APIKey { get; set; }


        private int limit = 1000;
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        private bool limitRate = true;

        /// <summary>
        /// Determines if the Requester should wait a period of time between multiple request
        /// </summary>
        public bool LimitRate
        {
            get { return limitRate; }
            set { limitRate = value; }
        }

        private int waitPeriodMilliseconds = 200;

        /// <summary>
        /// Defines the waiting period between multiple requests, if LimitRate is set to true
        /// </summary>
        public int WaitPeriodMilliseconds
        {
            get { return waitPeriodMilliseconds; }
            set { waitPeriodMilliseconds = value; }
        }

        public API(String APIKey) 
        {
            this.APIKey = APIKey;
        }

        
        
    }
}
