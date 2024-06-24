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
    public partial class ReportsForm : Form
    {
        private AdminForm Aform;
        private int clicked = 0;
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        public ReportsForm(AdminForm Aform)
        {
            InitializeComponent();
            SearchButton.Hide();
            textBox1.Hide();
            label8.Hide();
            dateTimePicker1.Hide();
            this.Aform = Aform;
            this.Height = Aform.Height;
            this.Width = Aform.Width;
            this.Location = Aform.Location;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            //current flights report
            clicked = 1;

            SearchButton.Hide();
            textBox1.Hide();
            label8.Hide();
            dateTimePicker1.Hide();

            label1.BackColor = Color.MintCream;
            label3.BackColor = Color.LightCyan;
            label4.BackColor = Color.LightCyan;
            label5.BackColor = Color.LightCyan;
            label6.BackColor = Color.LightCyan;
            label7.BackColor = Color.LightCyan;


            mycon.Open();
            panel1.Controls.Clear();
            string query2 = "select * from flight f left join aircraft a on f.AircraftID = a.SerialNo Where Date = @Date";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            command2.Parameters.AddWithValue("@Date", DateTime.Today);

            MySqlDataReader reader2 = command2.ExecuteReader();
            int i = 0;

            while (reader2.Read())
            {
                Label label = new Label();
                label.Text = "Flight-ID: " + reader2["FID"] + ",     Source-City: " + reader2["SRCCity"] + ",     Destenation: " + reader2["Destination"] + ",     Date: " + reader2["Date"] + ",     Seats: " + reader2["NumTickets"] + ",     Aircraft-Serial-Number: " + reader2["SerialNo"] + ",     Aircraft: " + reader2["Type"] + ",     Business-Seats: " + reader2["NumOfSeatsBuss"] + ",     First-Seats: " + reader2["NumOfSeatsFirs"] + ",     Economy-Seats: " + reader2["NumOfSeatsEcon"];
                label.AutoSize = true;
                label.Height = 30;
                label.Location = new Point(10, i * 40);
                panel1.Controls.Add(label);
                i++;
            }
            mycon.Close();
            reader2.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //bookig %
            clicked = 3;
            panel1.Controls.Clear();


            label8.Text = "Date";
            label8.Location = new Point(350, 21);
            label8.Show();
            textBox1.Hide();
            dateTimePicker1.Show();
            SearchButton.Show();

            label3.BackColor = Color.MintCream;
            label1.BackColor = Color.LightCyan;
            label4.BackColor = Color.LightCyan;
            label5.BackColor = Color.LightCyan;
            label6.BackColor = Color.LightCyan;
            label7.BackColor = Color.LightCyan;

            loadBookingPers();
        }
        private void loadBookingPers()
        {
            mycon.Open();
            panel1.Controls.Clear();
            string query2 = "select f.FID, f.NumTickets, count(T.FID) as flights from flight f join ticket t on f.FID = t.FID where t.Status = 'Booked' and FlightDate = @Date Group by t.FID";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            command2.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date) ;
            MySqlDataReader reader2 = command2.ExecuteReader();
            int i = 0;

            while (reader2.Read())
            {
                Label label = new Label();
                decimal booked = Convert.ToInt32(reader2["flights"]);
                decimal total = Convert.ToInt32(reader2["NumTickets"]);
                decimal percent = (booked / total) * 100;
                label.Text = "Flight Number:      "+reader2["FID"] + "             Booking Percent:      " + percent.ToString("0.0") +"%" ;
                label.AutoSize = true;
                label.Height = 30;
                label.Location = new Point(10, i * 40);
                panel1.Controls.Add(label);
                i++;
            }
            mycon.Close();
            reader2.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //payments
            clicked = 4;
            panel1.Controls.Clear();

            SearchButton.Hide();
            textBox1.Hide();
            label8.Hide();
            dateTimePicker1.Hide();

            label4.BackColor = Color.MintCream;
            label3.BackColor = Color.LightCyan;
            label1.BackColor = Color.LightCyan;
            label5.BackColor = Color.LightCyan;
            label6.BackColor = Color.LightCyan;
            label7.BackColor = Color.LightCyan;

            mycon.Open();
            panel1.Controls.Clear();
            string query2 = "select * from transaction";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            int i = 0;

            while (reader2.Read())
            {
                Label label = new Label();
                label.Text = "Transaction Number:      " + reader2["TNO"] + ",      Credit Card:      " + reader2["CreditCardNum"]+ ",      Date:      " + reader2["Date"]+ ",      Time:      " + reader2["Time"]+ ",      Price:      " + reader2["Amount"]+ ",      Ticket Number:      " + reader2["TicketID"];
                label.AutoSize = true;
                label.Height = 30;
                label.Location = new Point(10, i * 40);
                panel1.Controls.Add(label);
                i++;
            }
            mycon.Close();
            reader2.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //waitlist
            clicked = 5;
            panel1.Controls.Clear();


            label8.Text = "Flight Number";
            label8.Location = new Point(287, 21);
            label8.Show();
            textBox1.Show();
            dateTimePicker1.Hide();
            SearchButton.Show();

            label5.BackColor = Color.MintCream;
            label3.BackColor = Color.LightCyan;
            label4.BackColor = Color.LightCyan;
            label1.BackColor = Color.LightCyan;
            label6.BackColor = Color.LightCyan;
            label7.BackColor = Color.LightCyan;


            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //loadFactor
            clicked = 6;
            panel1.Controls.Clear();

            label8.Text = "Date";
            label8.Location = new Point(350, 21);
            label8.Show();
            textBox1.Hide();
            dateTimePicker1.Show();
            SearchButton.Show();

            label6.BackColor = Color.MintCream;
            label3.BackColor = Color.LightCyan;
            label4.BackColor = Color.LightCyan;
            label5.BackColor = Color.LightCyan;
            label1.BackColor = Color.LightCyan;
            label7.BackColor = Color.LightCyan;

            countLoadFactor();
        }
        private void countLoadFactor()
        {
            mycon.Open();
            panel1.Controls.Clear();
            string query2 = "select SUM(M.NumTickets) as allTickets, SUM(M.flights) as occupied from (select f.FID, f.NumTickets, count(T.FID) as flights from flight f join ticket t on f.FID = t.FID where (t.Status = 'Booked' or t.Status = 'Payed') and FlightDate = @Date Group by t.FID) AS M";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            command2.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
            MySqlDataReader reader2 = command2.ExecuteReader();



            try
            {
                while (reader2.Read())
                {


                    Label label = new Label();
                    decimal booked = Convert.ToInt32(reader2["occupied"]);
                    decimal total = Convert.ToInt32(reader2["allTickets"]);
                    decimal percent = (booked / total) * 100;
                    label.Text = "Date:      " + DateOnly.FromDateTime(dateTimePicker1.Value.Date) + "             Load Factor Percent:      " + percent.ToString("0.0") + "%";
                    label.AutoSize = true;
                    label.Height = 30;
                    label.Location = new Point(10, 0);
                    panel1.Controls.Add(label);
                }
                mycon.Close();
                reader2.Close();
            }
            catch
            {
                Label label = new Label();
                label.Text = "Date:      " + DateOnly.FromDateTime(dateTimePicker1.Value.Date) + "             Load Factor Percent:      " + "0" + "%";
                label.AutoSize = true;
                label.Height = 30;
                label.Location = new Point(10, 0);
                panel1.Controls.Add(label);
            }
            finally
            {
                mycon.Close();
                reader2.Close();
            }
                
        }
           

        

        private void label7_Click(object sender, EventArgs e)
        {
            //cancelled tickets
            clicked = 7;
            panel1.Controls.Clear();

            SearchButton.Hide();
            textBox1.Hide();
            label8.Hide();
            dateTimePicker1.Hide();


            label7.BackColor = Color.MintCream;
            label3.BackColor = Color.LightCyan;
            label4.BackColor = Color.LightCyan;
            label5.BackColor = Color.LightCyan;
            label6.BackColor = Color.LightCyan;
            label1.BackColor = Color.LightCyan;

            mycon.Open();
            string query2 = "select * from ticket where status ='canceld';";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            int i = 0;

            while (reader2.Read())
            {
                Label label = new Label();
                label.Text = "Ticket Number:      " + reader2["TicketID"] + ",      Flight Date:      " + reader2["FlightDate"] + ",      Time:      " + reader2["Time"] + ",      Credit Card:      " + reader2["CreditCardNumber"] + ",      Passenger ID:      " + reader2["PID"] + ",      Flight ID:      " + reader2["FID"] + ",      Class:      " + reader2["ClassType"];
                label.AutoSize = true;
                label.Height = 30;
                label.Location = new Point(10, i * 40);
                panel1.Controls.Add(label);
                i++;
            }
            mycon.Close();
            reader2.Close();



        }

        private void label9_Click(object sender, EventArgs e)
        {
            clicked = 9;
            panel1.Controls.Clear();
            Aform.Height = this.Height;
            Aform.Width = this.Width;
            Aform.Location = this.Location;
            this.Close();
            Aform.Show();
        }







        private void label1_MouseEnter(object sender, EventArgs e)
        {

            label1.BackColor = Color.LightBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == 1)
            {
                label1.BackColor = Color.MintCream;
            }
            else
            {
                label1.BackColor = Color.LightCyan;
            }

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {

            label3.BackColor = Color.LightBlue;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == 3)
            {
                label3.BackColor = Color.MintCream;
            }
            else
            {
                label3.BackColor = Color.LightCyan;
            }

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {

            label4.BackColor = Color.LightBlue;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == 4)
            {
                label4.BackColor = Color.MintCream;
            }
            else
            {
                label4.BackColor = Color.LightCyan;
            }

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.LightBlue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == 5)
            {
                label5.BackColor = Color.MintCream;
            }
            else
            {
                label5.BackColor = Color.LightCyan;
            }

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.LightBlue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == 6)
            {
                label6.BackColor = Color.MintCream;
            }
            else
            {
                label6.BackColor = Color.LightCyan;
            }

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.LightBlue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == 7)
            {
                label7.BackColor = Color.MintCream;
            }
            else
            {
                label7.BackColor = Color.LightCyan;
            }

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.LightBlue;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.LightCyan;
        }

        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            SearchButton.ForeColor = SystemColors.ControlDark;
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            SearchButton.ForeColor = Color.SteelBlue;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //generate clicked
            if (clicked==3)
            {
                loadBookingPers();
            }
            else if (clicked == 5)
            {
                try
                {
                    mycon.Open();
                    panel1.Controls.Clear();
                    string query2 = "select * from waitlistedfor w join flight f on w.FID = f.FID where W.FID =" + textBox1.Text;
                    MySqlCommand command2 = new MySqlCommand(query2, mycon);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    int i = 0;

                    while (reader2.Read())
                    {
                        Label label = new Label();
                        label.Text = "Passenger ID:      " + reader2["PID"] + ",      Flight ID:      " + reader2["FID"] + ",      Class:      " + reader2["ClassType"] + ",      Date:      " + reader2["Date"] + ",      From:      " + reader2["SRCCity"] + ",      To:      " + reader2["Destination"] + ",      Aircraft ID:      " + reader2["AircraftID"] + ",      Seats:      " + reader2["NumTickets"];
                        label.AutoSize = true;
                        label.Height = 30;
                        label.Location = new Point(10, i * 40);
                        panel1.Controls.Add(label);
                        i++;
                    }
                    mycon.Close();
                    reader2.Close();
                }
                catch
                {
                    MessageBox.Show("Plaese Enter Valid Flight ID");
                }
                finally
                {
                    mycon.Close();
                }
                
            }else if (clicked == 6)
            {
                countLoadFactor();
            }
        }
    }
}
