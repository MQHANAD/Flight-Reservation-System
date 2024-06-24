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
    public partial class AddingPayment : Form
    {
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");

        private adminInfoForm aif;
        private string name;
        private int PID;
        public AddingPayment(adminInfoForm aif, string name , int PID)
        {
            InitializeComponent();
            this.aif = aif;
            this.Height = aif.Height;
            this.Width = aif.Width;
            this.Location = aif.Location;
            this.name = name;
            this.PID = PID;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = SystemColors.ControlDark;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.SteelBlue;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlDark;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.SteelBlue;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //back
            back();
        }
        private void back()
        {
            aif.Height = this.Height;
            aif.Width = this.Width;
            aif.Location = this.Location;
            this.Close();
            aif.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Add

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text== "")
                {
                    MessageBox.Show("Please Fill the Text Boxes");
                }
                else
                {
                    mycon.Open();
                    string insertQuery = "INSERT INTO paymentmethod (CreditCardNum, EXPDate, Name, BillingAddress, PID) VALUES (@Value1, @Value2, @Value3, @Value4 , @Value5)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, mycon);
                    insertCommand.Parameters.AddWithValue("@Value1", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@Value2", textBox3.Text);
                    insertCommand.Parameters.AddWithValue("@Value3", name);
                    insertCommand.Parameters.AddWithValue("@Value4", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@Value5", PID);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    mycon.Close();
                    back();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
    }
}
