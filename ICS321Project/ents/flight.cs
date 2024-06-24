using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS321Project.ents
{
    internal class flight
    {
        private int id;
        private string srcCity;
        private string destCity;
        private DateTime date;
        private int numTickets;
        private int aircraftID;
        private ticketCollection coll;



        public flight(int id, string srcCity, string destCity, DateTime date, int numOfTickets, int aircraftID)
        {
            this.Id = id;
            this.srcCity = srcCity;
            this.destCity = destCity;
            this.Date = date;
            this.NumTickets = numOfTickets;
            this.AircraftID = aircraftID;
            
        }
        public void createClasses(double ecoPrice, double firstPrice, double busPrice )
        {
            List<aircraft> list = aircraftCollection.getList();
            aircraft ar = null;
            foreach (aircraft item in list)
            {
                if (item.Id == aircraftID)
                {
                    ar = item;
                }
            }
            
            if (ar != null )
            {

                new eco(id, ecoPrice, ar.EcoSeats);
                new first(id, firstPrice, ar.FirstSeats);
                new buss(id, busPrice, ar.BussSeats);
                
            }
        }

        public int Id { get => id; set => id = value; }
        public string SrcCity { get => srcCity; set => srcCity = value; }
        public string DestCity { get => destCity; set => destCity = value; }
        public int NumTickets { get => numTickets; set => numTickets = value; }
        public int AircraftID { get => aircraftID; set => aircraftID = value; }
        public DateTime Date { get => date; set => date = value; }
        internal ticketCollection Coll { get => coll; set => coll = value; }

        public override string ToString()
        {
            return "Flight ID: "+id + ",                From: " + srcCity + ",                To: " + destCity+ ",                Date: " + Date+ "                                                        ";
        }
    }

}
