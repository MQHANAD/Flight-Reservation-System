using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ICS321Project.ents
{
    internal class ticketCollection
    {

        private MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private int FID;
        private List<ticket> collection;
        private List<ticket> ecoList;
        private List<ticket> busList;
        private List<ticket> firList;
        private int Max = 10000;
        private static Boolean fromModifecation= false;

        public ticketCollection(int id)
        {
            this.FID = id;
            getMax();
            GetTickets();
        }
        public void bookEco(int pid)
        {
            GetTickets();
            if (ecoList != null)
            {
                if (ecoList.Count == 0)
                {
                    MessageBox.Show("Sorry, there are no tickets");
                }
                foreach (ticket t in ecoList)
                {
                    if (t.Status == null || t.Status == "Canceld")
                    {
                        book(pid, t.TicketID);
                        break;
                    }
                }
            }

            
        }
        public void bookfir(int pid)
        {
            GetTickets();

            if (firList != null)
            {
                if (firList.Count==0)
                {
                    MessageBox.Show("Sorry, there are no tickets");
                }
                foreach (ticket t in firList)
                {
                    if (t.Status == null || t.Status == "Canceld")
                    {
                        book(pid, t.TicketID);
                        break;
                    }
                }
            }
        }
        public  void bookBus(int pid)
        {

            GetTickets();
            if (busList != null)
            {
                if (busList.Count == 0)
                {
                    MessageBox.Show("Sorry, there are no tickets");
                }
                foreach (ticket t in busList)
                {
                    if (t.Status == null || t.Status == "Canceld")
                    {
                        book(pid,t.TicketID);
                        break;
                    }
                }
            }

            
        }
        public void book(int pid,int fid )
        {
            mycon.Open();
            string updateQuery = "UPDATE ticket SET PID = @NewValue1 , Status = @NewValue2  WHERE TicketID = @ConditionValue";
            MySqlCommand command = new MySqlCommand(updateQuery, mycon);         
            command.Parameters.AddWithValue("@NewValue1", pid);
            command.Parameters.AddWithValue("@NewValue2", "booked");
            command.Parameters.AddWithValue("@ConditionValue", fid);
            int rowsAffected = command.ExecuteNonQuery();
            mycon.Close();
            if (fromModifecation)
            {
                //call the method from viewTickets
                viewTicketsForm.deleteTicket();
                fromModifecation=false; 
            }
        }
        public static void setFromModifecationTrue()
        {
            fromModifecation = true;
        }
        public static void setFromModifecationFalse()
        {
            fromModifecation = false;
        }

        private void getMax()
        {
            try
            {
                mycon.Open();
                string query = "SELECT MAX(TicketID) FROM ticket";
                // Create a SqlCommand object with the query and the connection
                MySqlCommand command = new MySqlCommand(query, mycon);
                // Execute the query and get the result
                Max = Convert.ToInt32(command.ExecuteScalar());
                               
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!!");
                
            }
            finally
            {
                mycon.Close();
            }
        }

        public List<ticket> GetTickets()
        {

            if (collection == null)
            {
                collection = new List<ticket>();
                ecoList = new List<ticket>();
                busList = new List<ticket>();
                firList = new List<ticket>();
            }
            else
            {
                collection.Clear();
                busList.Clear();
                firList.Clear();
                ecoList.Clear();
            }
            try
            {
                loadFromDB();
                if (collection.Count == 0)
                {
                    generateTickets();
                }
            }
            catch
            {
                    
            }
            
            return collection;
        }

        public void loadFromDB()
        {
            mycon.Open();
            string query2 = "select * from ticket t left join classes c on t.FID = c.FID and t.ClassType = c.ClassType";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();

            

            while (reader2.Read())
            {
                if ((int)reader2["FID"] == FID)
                {
                    if ((string)reader2["ClassType"]== "Economy Class")
                    {
                        if (reader2.IsDBNull(reader2.GetOrdinal("Status")))
                        {
                            ticket tic = new ticket((int)reader2["TicketID"], (DateTime)reader2["FlightDate"], FID, "Economy Class", (decimal)reader2["Price"], null);
                            ecoList.Add(tic);
                            collection.Add(tic);
                        }
                        else
                        {
                            ticket tic = new ticket((int)reader2["TicketID"], (DateTime)reader2["FlightDate"], FID, "Economy Class", (decimal)reader2["Price"], (string)reader2["Status"]);
                            ecoList.Add(tic);
                            collection.Add(tic);

                        }
                                                                       
                    }
                    else if ((string)reader2["ClassType"] == "First Class")
                    {
                        if (reader2.IsDBNull(reader2.GetOrdinal("Status")))
                        {
                            ticket tic = new ticket((int)reader2["TicketID"], (DateTime)reader2["FlightDate"], FID, "First Class", (decimal)reader2["Price"], null);
                            firList.Add(tic);
                            collection.Add(tic);
                        }
                        else
                        {
                            ticket tic = new ticket((int)reader2["TicketID"], (DateTime)reader2["FlightDate"], FID, "First Class", (decimal)reader2["Price"], (string)reader2["Status"]);
                            firList.Add(tic);
                            collection.Add(tic);

                        }

                        
                                                    
                    }
                    else if ((string)reader2["ClassType"] == "Business Class")
                    {
                        if (reader2.IsDBNull(reader2.GetOrdinal("Status")))
                        {
                            ticket tic = new ticket((int)reader2["TicketID"], (DateTime)reader2["FlightDate"], FID, "Business Class", (decimal)reader2["Price"], null);
                            busList.Add(tic);
                            collection.Add(tic);
                        }
                        else
                        {
                            ticket tic = new ticket((int)reader2["TicketID"], (DateTime)reader2["FlightDate"], FID, "Business Class", (decimal)reader2["Price"], (string)reader2["Status"]);
                            busList.Add(tic);
                            collection.Add(tic);

                        }
                        
                    }
                }

            }
            mycon.Close();

        }
        public void generateTickets()
        {
            //for loop with the number of seats in the plane
            try
            {
                List<flight> flist = flightCollection.GetCollection();
                flight fl = null;
                foreach (flight element in flist)
                {
                    if (element.Id == FID)
                    {
                        fl = element;
                    }
                }

                mycon.Open();
                string query2 = " select * from flight f left join classes c on f.FID = c.FID left join aircraft a on f.AircraftID =a.SerialNo;";
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                MySqlDataReader reader2 = command2.ExecuteReader();


                while (reader2.Read())
                {
                    
                    if ((int)reader2["FID"] == FID)
                    {

                        
                        if ((string)reader2["ClassType"]== "Economy Class")
                        {

                            int x = (int)reader2["NumberSeats"];
                            decimal price = (decimal)reader2["Price"];
                            for (int i = 0; i<x; i++)
                            {
                                Max++;
                                ticket tic = new ticket(Max, fl.Date, fl.Id, "Economy Class", price, null);
                                ecoList.Add(tic);
                                collection.Add(tic);
 
                            }
                        }
                        else if ((string)reader2["ClassType"] == "First Class")
                        {

                            int x = (int)reader2["NumberSeats"];
                            decimal price = (decimal)reader2["Price"];
                            for (int i = 0; i < x; i++)
                            {

                                Max++;
                                ticket tic = new ticket(Max, fl.Date, fl.Id, "First Class", price ,null);
                                firList.Add(tic);
                                collection.Add(tic);

                            }

                        }
                        else if ((string)reader2["ClassType"] == "Business Class")
                        {
                            int x = (int)reader2["NumberSeats"];
                            decimal price = (decimal) reader2["Price"];
                            for (int i = 0; i < x; i++)
                            {

                                Max++;


                                ticket tic = new ticket(Max, fl.Date, fl.Id, "Business Class", price, null);
                                busList.Add(tic);
                                collection.Add(tic);

                            }

                        }

                    }
                    
                }
                mycon.Close();
                reader2.Close();
                loop();
            }
            catch
            {
                MessageBox.Show("something went wrong!");
            }
            finally
            {
                mycon.Close();
            }


            
        }


        private void loop()
        {
            foreach (ticket t in collection)
            {
                t.storeInDB();
            }
        }
    }
}
