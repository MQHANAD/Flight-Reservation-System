using MySql.Data.MySqlClient;


namespace ICS321Project.ents
{

    internal abstract class classes
    {   
    }
    class eco : classes
    {
        private static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private int FID;
        private string classType;
        private double price;
        private int numOfSeats;

        public eco(int fID, double price, int numOfSeats)
        {

            this.FID = fID;
            this.classType = "Economy Class";
            this.price = price;
            this.numOfSeats = numOfSeats;
            writeToDB();
        }
        public void writeToDB()
        {

            mycon.Open();
            string insertQuery = "INSERT INTO classes (ClassType, FID, Price, NumberSeats) VALUES (@Value1, @Value2, @Value3, @Value4)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1",ClassType);
            insertCommand.Parameters.AddWithValue("@Value2",FID);
            insertCommand.Parameters.AddWithValue("@Value3",price );
            insertCommand.Parameters.AddWithValue("@Value4",numOfSeats );
            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();


        }

        public string ClassType { get => classType; set => classType = value; }

        public int NumOfSeats { get => numOfSeats; set => numOfSeats = value; }
        public int FID1 { get => FID; set => FID = value; }
    }
    class buss : classes
    {
        private static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private int FID;
        private string classType;
        private double price;
        private int numOfSeats;

        public buss(int fID, double price, int numOfSeats)
        {
            this.FID = fID;
            this.ClassType = "Business Class";
            this.Price = price;
            this.NumOfSeats = numOfSeats;
            writeToDB();
        }
        public void writeToDB()
        {
            mycon.Open();
            string insertQuery = "INSERT INTO classes (ClassType, FID, Price, NumberSeats) VALUES (@Value1, @Value2, @Value3, @Value4)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1", ClassType);
            insertCommand.Parameters.AddWithValue("@Value2", FID1);
            insertCommand.Parameters.AddWithValue("@Value3", price);
            insertCommand.Parameters.AddWithValue("@Value4", numOfSeats);
            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();

        }


        public string ClassType { get => classType; set => classType = value; }
        public double Price { get => price; set => price = value; }
        public int NumOfSeats { get => numOfSeats; set => numOfSeats = value; }
        public int FID1 { get => FID; set => FID = value; }
    }
    class first : classes   
    {
        private static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private int FID;
        private string classType;
        private double price;
        private int numOfSeats;
        public first(int fID, double price, int numOfSeats)
        {
            this.FID = fID;
            this.ClassType = "First Class";
            this.Price = price;
            this.NumOfSeats = numOfSeats;
            writeToDB();
        }
        public void writeToDB()
        {
            mycon.Open();
            string insertQuery = "INSERT INTO classes (ClassType, FID, Price, NumberSeats) VALUES (@Value1, @Value2, @Value3, @Value4)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
            insertCommand.Parameters.AddWithValue("@Value1", ClassType);
            insertCommand.Parameters.AddWithValue("@Value2", FID1);
            insertCommand.Parameters.AddWithValue("@Value3", price);
            insertCommand.Parameters.AddWithValue("@Value4", numOfSeats);
            int rowsAffected = insertCommand.ExecuteNonQuery();
            mycon.Close();

        }


        public string ClassType { get => classType; set => classType = value; }
        public double Price { get => price; set => price = value; }
        public int NumOfSeats { get => numOfSeats; set => numOfSeats = value; }
        public int FID1 { get => FID; set => FID = value; }
    }
}
