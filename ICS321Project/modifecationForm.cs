using ICS321Project.ents;
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
    public partial class modifecationForm : Form
    {
        private MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private flight fl;
        private viewFlightsForm f;
        private List<aircraft> list;
        public modifecationForm(viewFlightsForm f)
        {
            this.f = f;
            InitializeComponent();
            this.Location = f.Location;
            this.Height = f.Height;
            this.Width = f.Width;
            list = aircraftCollection.getList();
            comboBox1.Items.Clear();
            foreach (aircraft ac in list)
            {
                comboBox1.Items.Add(ac);
            }

        }

        private void modifyButton_MouseEnter(object sender, EventArgs e)
        {
            modifyButton.ForeColor = SystemColors.ControlDark;
        }

        private void modifyButton_MouseLeave(object sender, EventArgs e)
        {
            modifyButton.ForeColor = Color.SteelBlue;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.ForeColor = SystemColors.ControlDark;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.SteelBlue;
        }

        internal void SetFlight(flight flight1)
        {
            this.fl = flight1;
            textBox1.Text = fl.SrcCity;
            textBox2.Text = fl.DestCity;
            dateTimePicker1.Value = fl.Date;
            foreach (aircraft air in list)
            {
                
                if (air.Id == fl.AircraftID)
                {
                    comboBox1.SelectedItem = air;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Width = this.Width;
            f.Height = this.Height;
            f.Location = this.Location;
            f.Show();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            mycon.Open();
            try
            {

                int prevID = fl.Id;
                string updateQuery = "UPDATE flight SET SRCCity = @NewValue1, Destination = @NewValue2, Date = @NewValue3, AircraftID = @NewValue4, NumTickets = @NewValue5  WHERE FID = @ConditionValue";
                MySqlCommand command = new MySqlCommand(updateQuery, mycon);
                fl.SrcCity = textBox1.Text;
                command.Parameters.AddWithValue("@NewValue1", fl.SrcCity);
                fl.DestCity = textBox2.Text;
                command.Parameters.AddWithValue("@NewValue2", fl.DestCity);
                fl.Date = dateTimePicker1.Value;
                command.Parameters.AddWithValue("@NewValue3", fl.Date);
                aircraft aircraft1 = (aircraft)comboBox1.SelectedItem;
                fl.AircraftID = aircraft1.Id;
                command.Parameters.AddWithValue("@NewValue4", fl.AircraftID);
                fl.NumTickets = aircraft1.getTotalSeats();
                command.Parameters.AddWithValue("@NewValue5", fl.NumTickets);
                command.Parameters.AddWithValue("@ConditionValue", prevID );
                int rowsAffected = command.ExecuteNonQuery();

                this.Close();
                f.Width = this.Width;
                f.Height = this.Height;
                f.Location = this.Location;
                f.loadFlightsDB();
                f.Show();
            }
            catch
            {
                MessageBox.Show("something went wrong!");
            }
            mycon.Close();      
        }
    }
}
