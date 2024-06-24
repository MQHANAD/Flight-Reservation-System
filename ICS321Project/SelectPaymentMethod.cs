using Google.Protobuf.WellKnownTypes;
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
    public partial class SelectPaymentMethod : Form
    {
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");

        private viewTicketsForm VTform;
        private int TicketID;
        private int id;
        private int TID;
        public SelectPaymentMethod(viewTicketsForm VTform, int id, int TicketID)
        {
            InitializeComponent();
            this.VTform = VTform;
            this.Height = VTform.Height;
            this.Width = VTform.Width;
            this.Location = VTform.Location;
            mycon.Open();
            string query2 = "SELECT * FROM paymentmethod WHERE PID =" + id;
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboBox1.Items.Add(reader2["CreditCardNum"]);
            }
            mycon.Close();
            this.TicketID = TicketID;
            this.id = id;
            this.TID = 10000;
            getMax();
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
            //back
            back();
        }
        private void back()
        {
            VTform.Height = this.Height;
            VTform.Width = this.Width;
            VTform.Location = this.Location;
            VTform.loadOnpanel();
            this.Close();
            VTform.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            //pay
            mycon.Open();
            string query2 = "update Ticket set PID = " + id + ", CreditCardNumber = " + comboBox1.SelectedItem + ", Status = 'Payed' WHERE TicketID = " + TicketID;
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            command2.ExecuteNonQuery();

            //reading price
            query2 = "select * from ticket t left join classes f on t.FID = f.FID and t.ClassType = f.ClassType where TicketID=" + TicketID;
            command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            decimal price = 0;
            while (reader2.Read())
            {
                price = (decimal)reader2["Price"];
            }
            reader2.Close();
            //inserting transaction


            string insertQuery = "INSERT INTO transaction (TNO, CreditCardNum, Date ,Time , Amount ,TicketID) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1", TID);
            insertCommand.Parameters.AddWithValue("@Value2", comboBox1.SelectedItem);
            insertCommand.Parameters.AddWithValue("@Value3", DateTime.Today);
            insertCommand.Parameters.AddWithValue("@Value4", DateTime.Now.TimeOfDay);
            insertCommand.Parameters.AddWithValue("@Value5", price);
            insertCommand.Parameters.AddWithValue("@Value6", TicketID);

            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();
            back();


        }

        private void getMax()
        {
            try
            {
                mycon.Open();
                string query = "SELECT MAX(TNO) FROM transaction";
                // Create a SqlCommand object with the query and the connection
                MySqlCommand command = new MySqlCommand(query, mycon);
                // Execute the query and get the result
                TID = Convert.ToInt32(command.ExecuteScalar()) + 1;

            }
            catch
            {
                

            }
            finally
            {
                mycon.Close();
            }
        }
    }
}
