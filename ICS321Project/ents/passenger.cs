using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS321Project.ents
{
    internal class passenger : User
    {
        private int id;
        private string name;
        private string password;
        private double totalFines;
        private double totalWeight;
        private string role;

        public passenger(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.role = "User";
        }

        public double TotalWeight { get => totalWeight; set => totalWeight = value; }
        public double TotalFines { get => totalFines; set => totalFines = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Role { get => role; set => role = value; }
    }
}
