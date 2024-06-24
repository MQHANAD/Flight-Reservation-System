using MySql.Data.MySqlClient;
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
    public partial class takePassID : Form
    {
        private AdminForm ad;
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");

        public takePassID(AdminForm f)
        {
            InitializeComponent();
            this.Height = f.Height;
            this.Width = f.Width;
            this.Location = f.Location;
            this.ad = f;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlDark;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SteelBlue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlDark;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SteelBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ad.Height = this.Height;
            ad.Width = this.Width;
            ad.Location = this.Location;
            this.Close();
            ad.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                mycon.Open();
                int id = Convert.ToInt32(textBox1.Text);
                string query = "select count(PID) from passenger where PID = "+id;
                MySqlCommand command = new MySqlCommand(query,mycon);
                MySqlDataReader reader = command.ExecuteReader();
                int isInDB = 0;
                while(reader.Read())
                {
                    isInDB = Convert.ToInt32(reader["count(PID)"]);
                }
                mycon.Close();
                reader.Close();
                if (isInDB==1)
                {
                    viewFlightsForm vff = new viewFlightsForm(ad, false, id);
                    viewTicketsForm vtf = new viewTicketsForm(ad, id, vff, true);
                    this.Hide();
                    vtf.Show();
                }
                else
                {
                    MessageBox.Show("There is No Such ID");
                }

                
            }
            catch 
            {
                MessageBox.Show("Something Went Wrong!"); 
                mycon.Close();
            }
            finally
            {
                mycon.Close();
            }
        }
    }
}
