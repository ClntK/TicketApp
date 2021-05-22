using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wk3StudentTicketApp;

namespace Wk3SportingEvent
{
    public class SportingEvent : Tickets
    {
        private string homeTeam;
        private string awayTeam;
        private string gameNum;

        // properties
        public string HomeTeam
        {
            get
            {
                return homeTeam;
            }
            set
            {
                homeTeam = value;
            }
        }

        public string AwayTeam
        {
            get
            {
                return awayTeam;
            }
            set
            {
                awayTeam = value;
            }
        }

        public string GameNum
        {
            get
            {
                return gameNum;
            }
            set
            {
                gameNum = value;
            }
        }

        // method

        public override string ToString()
        {
            return (base.ToString() + "\n" + homeTeam + "vs" + awayTeam +
                                      "\nGame Number: " + gameNum);
        }

    }
}
