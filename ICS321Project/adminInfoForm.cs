using ICS321Project.ents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS321Project
{
    public partial class adminInfoForm : Form
    {
        AdminForm f;
        string name;
        int id;
        string role;
        Boolean isPassenger;
        public adminInfoForm(string name, string role, AdminForm f , int id, bool isPassenger)
        {
            InitializeComponent();
            this.Width = f.Width;
            this.Height = f.Height;
            this.Location = f.Location;
            nameLable.Text = "Name: " + name;
            roleLabel.Text = "Role: " + role;
            this.f = f;
            this.id = id;
            this.name = name;
            this.isPassenger = isPassenger;
        }



        private void label8_Click(object sender, EventArgs e)
        {
            f.Width = this.Width;
            f.Height = this.Height;
            f.Location = this.Location;
            this.Close();
            f.Show();

        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = SystemColors.ControlDark;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.SteelBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPassenger)
            {
                AddingPayment form = new AddingPayment(this, name, id);
                this.Hide();
                form.Show();

            }
            
        }
    }
}
