using MySql.Data.MySqlClient;


namespace ICS321Project.ents
{

    internal class ticket
    {
        private static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private int ticketID;
        private DateTime date;
        private double weightAllowed;
        private string CreditCardNum;
        private int PID;
        private int FID;
        private string ClassType;
        private decimal price;
        private string status;

        public ticket(int ticketID, DateTime date, int fID, string classType, decimal price, string status)
        {
            this.ticketID = ticketID;
            this.date = date;
            FID = fID;
            ClassType = classType;
            this.price = price;
            this.status = status;   
        }

        public int PID1 { get => PID; set => PID = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }
        public string Status { get => status; set => status = value; }

        public void storeInDB()
        {
            mycon.Open();
            string insertQuery = "INSERT INTO ticket (TicketID, FlightDate, Time, FID, ClassType) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1", ticketID);
            insertCommand.Parameters.AddWithValue("@Value2", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@Value3", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@Value4", FID);
            insertCommand.Parameters.AddWithValue("@Value5", ClassType);
            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();
        }
    }
    
}
