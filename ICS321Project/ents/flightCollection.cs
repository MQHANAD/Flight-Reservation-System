using MySql.Data.MySqlClient;


namespace ICS321Project.ents
{

    internal static class flightCollection
    {
        private static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private static List<flight> flights = new List<flight>();
        public static List<flight> GetCollection()
        {
            readFromDB();
            return flights;
        }
        public static List<flight> GetCollection1(string from, string to)
        {
            readFromDB1(from , to);
            return flights;
        }
        public static List<flight> GetCollection2(string from)
        {
            readFromDB2(from);
            return flights;
        }
        public static void add(flight flt)
        {
            mycon.Open();
            flights.Add(flt);
            string insertQuery = "INSERT INTO flight (FID, SRCCity, Date, NumTickets, AircraftID, Destination) VALUES (@Value1, @Value2, @Value3, @Value4 ,@Value5 ,@Value6)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1", flt.Id);
            insertCommand.Parameters.AddWithValue("@Value2", flt.SrcCity);
            insertCommand.Parameters.AddWithValue("@Value3", flt.Date);
            insertCommand.Parameters.AddWithValue("@Value4", flt.NumTickets);
            insertCommand.Parameters.AddWithValue("@Value5", flt.AircraftID);
            insertCommand.Parameters.AddWithValue("@Value6", flt.DestCity);
            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();
        }
        public static void remove(flight flt)
        {
            try
            {
                mycon.Open();
                string deleteQuery = "DELETE FROM flight WHERE FID = @Value";
                MySqlCommand command = new MySqlCommand(deleteQuery, mycon);
                command.Parameters.AddWithValue("@Value", flt.Id);
                int rowsAffected = command.ExecuteNonQuery();
                flights.Remove(flt);
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("You Can't Delete This Flight\nPassengers Booked For This Flight");
                mycon.Close() ;
            }
            finally
            {
                mycon.Close() ;
            }
            
        }
        private static void readFromDB ()
        {
            flights.Clear();
            mycon.Open();
            try
            {
                string query2 = "SELECT FID, SRCCity, Date, NumTickets, AircraftID, Destination  FROM flight";
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    flight fl = new flight((int)reader2["FID"], (string)reader2["SRCCity"], (string)reader2["Destination"], (DateTime)reader2["Date"], (int)reader2["NumTickets"], (int)reader2["AircraftID"]);
                    flights.Add(fl);
                }
                reader2.Close();
            }
            catch
            {
                MessageBox.Show("something went wrong!");
            }
            mycon.Close();

        }
        private static void readFromDB1(string from , string to)
        {
            flights.Clear();
            mycon.Open();
            try
            {
                string query2 = "SELECT FID, SRCCity, Date, NumTickets, AircraftID, Destination  FROM flight where SRCCity = "+"'"+from+"'"+ " and Destination = " + "'" + to + "'";
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    flight fl = new flight((int)reader2["FID"], (string)reader2["SRCCity"], (string)reader2["Destination"], (DateTime)reader2["Date"], (int)reader2["NumTickets"], (int)reader2["AircraftID"]);
                    flights.Add(fl);
                }
                reader2.Close();
            }
            catch
            {
                MessageBox.Show("something went wrong!");
            }
            mycon.Close();

        }
        private static void readFromDB2(string from)
        {
            flights.Clear();
            mycon.Open();
            try
            {
                string query2 = "SELECT FID, SRCCity, Date, NumTickets, AircraftID, Destination  FROM flight where SRCCity = " + "'" + from + "'";
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    flight fl = new flight((int)reader2["FID"], (string)reader2["SRCCity"], (string)reader2["Destination"], (DateTime)reader2["Date"], (int)reader2["NumTickets"], (int)reader2["AircraftID"]);
                    flights.Add(fl);
                }
                reader2.Close();
            }
            catch
            {
                MessageBox.Show("something went wrong!");
            }
            mycon.Close();

        }
    }
}
