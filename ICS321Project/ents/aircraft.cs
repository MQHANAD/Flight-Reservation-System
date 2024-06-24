using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS321Project.ents
{
    internal class aircraft
    {
        private int id;
        private string type;
        private int firstSeats;
        private int bussSeats;
        private int ecoSeats;


        public aircraft(int id, string type, int firstSeats,int bussSeats, int ecoSeats)
        {
            this.Id = id;
            this.Type = type;
            this.FirstSeats = firstSeats;
            this.BussSeats = bussSeats;
            this.EcoSeats = ecoSeats;
        }
        public int getTotalSeats()
        {
            return firstSeats + bussSeats + ecoSeats;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public int FirstSeats { get => firstSeats; set => firstSeats = value; }
        public int BussSeats { get => bussSeats; set => bussSeats = value; }
        public int EcoSeats { get => ecoSeats; set => ecoSeats = value; }

        public override string ToString()
        {
            return "aircraft ID: "+Id+", aircraft Type: "+Type;
        }

    }
}
