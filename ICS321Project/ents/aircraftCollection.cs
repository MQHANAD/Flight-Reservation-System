using MySql.Data.MySqlClient;

namespace ICS321Project.ents
{
    internal class aircraftCollection
    {
        private static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private static List<aircraft> aircraftColl = new List<aircraft>();
        public static List<aircraft> getList()
        {
            readFromDB();
            return aircraftColl;
        }
        private static void readFromDB()
        {
            aircraftColl.Clear();
            mycon.Open();
            try
            {
                string query2 = "SELECT SerialNo, Type, NumOfSeatsBuss, NumOfSeatsFirs, NumOfSeatsEcon from aircraft";
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    aircraftColl.Add(new aircraft((int)reader2["SerialNo"], (string)reader2["Type"], (int)reader2["NumOfSeatsFirs"], (int)reader2["NumOfSeatsBuss"], (int)reader2["NumOfSeatsEcon"]));
                }
                reader2.Close();
            }
            catch
            {

            }
            mycon.Close();
        }
    }
}
