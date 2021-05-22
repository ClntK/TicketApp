using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3StudentTicketApp
{
    public abstract class Tickets
    {
        private string location;
        private string time;
        private string price;
        private string seat;

        // properties
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;   
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Seat
        {
            get
            {
                return seat;
            }
            set
            {
                seat = value;
            }
        }

        // methods
        override public string ToString()
        {
            string temp;
            temp = "Location: " + location + "\n" +
                   "Time: " + time + "\n" +
                   "Price: " + price + "\n" +
                   "Seat Number: " + seat;
            return (temp);
        }
    }

}
