using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wk3StudentTicketApp;

namespace Wk3ConventionEvent
{
    public class ConventionEvent : Tickets
    {
        private string eventName;
        private string companyName;

        //properties
        public string EventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        // method
        public override string ToString()
        {
            return (base.ToString() + "\nEvent: " + eventName +
                                      "\nAttending with: " + companyName);


        }

    }
}
