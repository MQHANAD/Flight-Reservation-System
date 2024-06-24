using MySql.Data.MySqlClient;
namespace ICS321Project

{
    public partial class Form1 : Form
    {
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            mycon.Open();
            try
            {
                string query2 = "SELECT AdminID,Password FROM admin WHERE AdminID =" + userNameTextBox.Text;
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    if (reader2["Password"] + "" == PasswordTextBox.Text)
                    {
                        label2.ForeColor = Color.Black;
                        this.Hide();
                        AdminForm form = new AdminForm((int)reader2["AdminID"],this,true);
                        form.Show();
                    }
                    else
                    {
                        label1.ForeColor = Color.Black;
                        label2.ForeColor=Color.DarkRed;
                    }

                }
                reader2.Close();
            }
            catch
            {
                label1.ForeColor = Color.DarkRed;
                label2.ForeColor = Color.DarkRed;
            }

            try
            {
                string query = "SELECT PID,Password FROM passenger WHERE PID =" + userNameTextBox.Text;
                MySqlCommand command = new MySqlCommand(query, mycon);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Password"] + "" == PasswordTextBox.Text)
                    {
                        label2.ForeColor = Color.Black;
                        this.Hide();
                        AdminForm form = new AdminForm((int)reader["PID"], this,false);
                        form.Show();
                    }
                    else
                    {
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.DarkRed;
                    }

                }
                reader.Close();
            }
            catch
            {
                label1.ForeColor = Color.DarkRed;
                label2.ForeColor = Color.DarkRed;
            }

            mycon.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            this.Hide();
            form2.Show();
        }
    }
}
