using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS321Project.ents
{
    internal class Admin : User
    {
        private int id;
        private string name;
        private string password;
        private string role;

        public Admin(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.role = "Admin";
        }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Role { get => role; }
    }
}
