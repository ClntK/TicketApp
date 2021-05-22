using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wk3StudentTicketApp;

namespace Wk3TheatreEvent
{
    public class TheatreEvent : Tickets
    {
        private string showName;
        private string rating;

        // properties

        public string ShowName
        {
            get
            {
                return showName;
            }
            set
            {
                showName = value;
            }
        }
        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }


        public override string ToString()
        {
            return (base.ToString() + "\nAdmit One to: " + showName +
                                      "\nRated: " + rating);
        }

    }
}
