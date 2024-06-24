using MySql.Data.MySqlClient;


namespace ICS321Project
{
    public partial class Form2 : Form
    {
        Form1 form;
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        public Form2(Form1 form)
        {
            
            InitializeComponent();
            this.Width = form.Width;
            this.Height = form.Height;
            this.Location = form.Location;
            this.form = form;
        }



        private void signUpButton_Click(object sender, EventArgs e)
        {
            mycon.Open();
            try
            {
                int id;
                if (!(int.TryParse(IDTextBox.Text, out id)))
                {
                    MessageBox.Show("wrong id format");
                }
                else
                {
                    string insertQuery = "INSERT INTO passenger (PID, Name, Password) VALUES (@Value1, @Value2, @Value3)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
                    insertCommand.Parameters.AddWithValue("@Value1", id);
                    insertCommand.Parameters.AddWithValue("@Value2", NameTextBox.Text);
                    insertCommand.Parameters.AddWithValue("@Value3", PassTextBox.Text);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Rows inserted: " + rowsAffected);
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
            }
            catch
            {
                MessageBox.Show("the id is already taken");
            }
            
            mycon.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            form.Width = this.Width;
            form.Height = this.Height;
            form.Location = this.Location;
            this.Close();
            form.Show();
        }

    }
}
