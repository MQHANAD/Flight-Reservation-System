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
    public partial class bookingForm : Form
    {
        private flight flit;
        private int picked = 0;
        private viewFlightsForm vf;
        private ticketCollection e1;
        int PassengerID = 0;
        private MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");

        public bookingForm(viewFlightsForm f, int passengerID, Boolean booking)
        {
            InitializeComponent();
            this.Location = f.Location;
            this.Height = f.Height;
            this.Width = f.Width;
            this.vf = f;
            PassengerID = passengerID;
            if (booking)
            {
                bookButton.Show();
                waitlistButton.Hide();
            }
            else
            {
                bookButton.Hide();
                waitlistButton.Show();
            }

        }
        internal void setFlight(flight f)
        {
            flit = f;
            mycon.Open();
            string query2 = "SELECT * FROM classes WHERE ClassType = 'Economy Class' and FID =" + flit.Id;
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                label2.Text = reader2["Price"] + "";
                break;
            }
            reader2.Close();
            query2 = "SELECT * FROM classes WHERE ClassType = 'First Class' and FID =" + flit.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                label3.Text = reader2["Price"] + "";
                break;
            }
            reader2.Close();
            query2 = "SELECT * FROM classes WHERE ClassType = 'Business Class' and FID =" + flit.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                label4.Text = reader2["Price"] + "";
                break;
            }
            
            reader2.Close();
            e1 = new ticketCollection(f.Id);

            
            query2 = "select count(TicketID) as numTickets from ticket where ClassType ='Economy Class' and FID = "+f.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            string totalTicket="";
            while (reader2.Read())
            {
                totalTicket = " / " + reader2["numTickets"];
            }
            reader2.Close();
            query2 = "select count(TicketID) as numTickets from ticket where ClassType ='Economy Class' and (Status = 'Booked' or Status = 'Payed' )and FID = " + f.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                totalTicket = "Booked: " + reader2["numTickets"] + totalTicket;
            }
            //set Text
            reader2.Close();
            label5.Text = totalTicket;
            query2 = "select count(TicketID) as numTickets from ticket where ClassType ='First Class' and FID = " + f.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            totalTicket = "";
            while (reader2.Read())
            {
                totalTicket = " / " + reader2["numTickets"];
            }
            reader2.Close();
            query2 = "select count(TicketID) as numTickets from ticket where ClassType ='First Class' and (Status = 'Booked' or Status = 'Payed' )and FID = " + f.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                totalTicket = "Booked: " + reader2["numTickets"] + totalTicket;
            }
            //set Text
            reader2.Close();
            label6.Text =   totalTicket;
            query2 = "select count(TicketID) as numTickets from ticket where ClassType ='Business Class' and FID = " + f.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            totalTicket = "";
            while (reader2.Read())
            {
                totalTicket = " / " + reader2["numTickets"];
            }
            reader2.Close();
            query2 = "select count(TicketID) as numTickets from ticket where ClassType ='Business Class' and (Status = 'Booked' or Status = 'Payed' )and FID = " + f.Id;
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                totalTicket = "Booked: " + reader2["numTickets"] + totalTicket;
            }
            //set Text
            label7.Text = totalTicket;
            reader2.Close();
            mycon.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (picked == 1)
            {
                EconomyButton.ForeColor = Color.SteelBlue;
                picked = 0;
            }
            else
            {
                EconomyButton.ForeColor = Color.LimeGreen;
                firstClassButton.ForeColor = Color.SteelBlue;
                busClasButton.ForeColor = Color.SteelBlue;
                picked = 1;

            }

        }

        private void firstClassButton_Click(object sender, EventArgs e)
        {
            if (picked == 2)
            {
                firstClassButton.ForeColor = Color.SteelBlue;
                picked = 0;
            }
            else
            {
                firstClassButton.ForeColor = Color.LimeGreen;
                EconomyButton.ForeColor = Color.SteelBlue;
                busClasButton.ForeColor = Color.SteelBlue;
                picked = 2;

            }

        }

        private void busClasButton_Click(object sender, EventArgs e)
        {
            if (picked == 3)
            {
                busClasButton.ForeColor = Color.SteelBlue;
                picked = 0;
            }
            else
            {
                busClasButton.ForeColor = Color.LimeGreen;
                firstClassButton.ForeColor = Color.SteelBlue;
                EconomyButton.ForeColor = Color.SteelBlue;

                picked = 3;
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (picked == 1)
            {
                e1.bookEco(PassengerID);
                prevPage();
            }
            else if (picked == 2)
            {
                e1.bookfir(PassengerID);
                prevPage();
            }
            else if (picked == 3)
            {
                e1.bookBus(PassengerID);
                prevPage();
            }
            else
            {
                MessageBox.Show("Please Select a Class");
            }
        }
        private void prevPage()
        {
            vf.Height = this.Height;
            vf.Width = this.Width;
            vf.Location = this.Location;
            this.Hide();
            vf.Show();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            prevPage();
        }

        private void EconomyButton_MouseEnter(object sender, EventArgs e)
        {
            if (picked != 1)
            {
                EconomyButton.ForeColor = SystemColors.ControlDark;
            }

        }

        private void EconomyButton_MouseLeave(object sender, EventArgs e)
        {
            if (picked != 1)
            {
                EconomyButton.ForeColor = Color.SteelBlue;
            }

        }

        private void firstClassButton_MouseEnter(object sender, EventArgs e)
        {
            if (picked != 2)
            {
                firstClassButton.ForeColor = SystemColors.ControlDark;
            }

        }

        private void firstClassButton_MouseLeave(object sender, EventArgs e)
        {
            if (picked != 2)
            {
                firstClassButton.ForeColor = Color.SteelBlue;
            }

        }

        private void busClasButton_MouseEnter(object sender, EventArgs e)
        {
            if (picked != 3)
            {
                busClasButton.ForeColor = SystemColors.ControlDark;
            }

        }

        private void busClasButton_MouseLeave(object sender, EventArgs e)
        {
            if (picked != 3)
            {
                busClasButton.ForeColor = Color.SteelBlue;
            }

        }

        private void bookButton_MouseEnter(object sender, EventArgs e)
        {
            bookButton.ForeColor = SystemColors.ControlDark;
        }

        private void bookButton_MouseLeave(object sender, EventArgs e)
        {
            bookButton.ForeColor = Color.SteelBlue;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.ForeColor = SystemColors.ControlDark;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.SteelBlue;
        }

        private void waitlistButton_MouseEnter(object sender, EventArgs e)
        {
            waitlistButton.ForeColor = SystemColors.ControlDark;
        }

        private void waitlistButton_MouseLeave(object sender, EventArgs e)
        {
            waitlistButton.ForeColor = Color.SteelBlue;
        }

        private void waitlistButton_Click(object sender, EventArgs e)
        {
            if (picked == 1)
            {
                insertIntoWailist("Economy Class");
                prevPage();
            }
            else if (picked == 2)
            {
                insertIntoWailist("First Class");
                prevPage();
            }
            else if (picked == 3)
            {
                insertIntoWailist("Business Class");
                prevPage();
            }
            else
            {
                MessageBox.Show("Please Select a Class");
            }
        }
        private void insertIntoWailist(string classType)
        {
            mycon.Open();
            string insertQuery = "INSERT INTO waitlistedfor (PID, FID, ClassType) VALUES (@Value1, @Value2, @Value3)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1", PassengerID);
            insertCommand.Parameters.AddWithValue("@Value2", flit.Id);
            insertCommand.Parameters.AddWithValue("@Value3", classType);
            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();
        }
    }
}
