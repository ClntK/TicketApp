using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wk3SportingEvent;
using Wk3TheatreEvent;
using Wk3ConventionEvent;
using Wk3StudentTicketApp;

namespace Wk3_Form_To_Display_Ticket_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            this.lbl_Display.Text = "Great! you would now be" +
                                    "\ntaken to our payment form..." +
                                    "\nif we had one.";
        
        }

        private void btn_ViewEvent_Click(object sender, EventArgs e)
        {
            string eventType = cmbo_EventSelect.SelectedItem.ToString();

            if ((string)this.cmbo_EventSelect.SelectedItem == "Sporting Event")
            {
                SportingEvent mySportingEvent = new SportingEvent();

                mySportingEvent.Location = "WGU Stadium";
                mySportingEvent.Price = "$10.00";
                mySportingEvent.Time = "Fri, Mar 05 2021\n\t\t09:00 AM";
                mySportingEvent.Seat = "Row 21 \n\tSeat 01 \nSection 'B'";
                mySportingEvent.HomeTeam = "Huskies ";
                mySportingEvent.AwayTeam = " BadGuys";
                mySportingEvent.GameNum = "6";

                string temp = mySportingEvent.ToString();
                this.lbl_Display.Text = temp;
            }
            if ((string)this.cmbo_EventSelect.SelectedItem == "Theatre Event")
            {
                TheatreEvent myTheatreEvent = new TheatreEvent();

                myTheatreEvent.Location = "Neptune Theatre";
                myTheatreEvent.Price = "$5.00";
                myTheatreEvent.Time = "Sat, Apr 10 2021\n\t\t09:00 PM";
                myTheatreEvent.Seat = "Balcony 4 \n\t Seat 04";
                myTheatreEvent.ShowName = "The Great Eugene-O";
                myTheatreEvent.Rating = "R";

                string temp = myTheatreEvent.ToString();
                this.lbl_Display.Text = temp;
            }
            if ((string)this.cmbo_EventSelect.SelectedItem == "Convention Event")
            {
                ConventionEvent myConventionEvent = new ConventionEvent();

                myConventionEvent.Location = "WGU Convention Center";
                myConventionEvent.Price = "$50.00";
                myConventionEvent.Time = "Fri, Jun 07 - Sun, Jun 09 2021";
                myConventionEvent.EventName = "Seattle Seaweed Convention";
                myConventionEvent.CompanyName = "Ishmael's Bucket Restaurant";


                string temp = myConventionEvent.ToString();
                this.lbl_Display.Text = temp;
            }
        }
    }
}
