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
    public partial class addingFlight : Form
    {
        
        viewFlightsForm form;
        public addingFlight(viewFlightsForm form)
        {
            this.form = form;
            InitializeComponent();
            List<aircraft> list = aircraftCollection.getList();
            comboBox1.Items.Clear();
            foreach (aircraft ac in list)
            {
                comboBox1.Items.Add(ac);
            }
            this.Height = form.Height;
            this.Width = form.Width;
            this.Location = form.Location;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            this.Close();
            form.loadFlightsDB();
            form.Show();

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            backButton.ForeColor = SystemColors.ControlDark;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.SteelBlue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            addButton.ForeColor = SystemColors.ControlDark;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.SteelBlue;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text=="" || textBox2.Text == "" || dateTimePicker1.Value == null || textBox5.Text == "")
                {
                    throw new Exception(); 
                }
                aircraft aircraft1 = (aircraft)comboBox1.SelectedItem;
                flight fl = new flight(int.Parse(textBox5.Text), textBox1.Text, textBox2.Text, dateTimePicker1.Value, aircraft1.getTotalSeats(), aircraft1.Id);

                flightCollection.add(fl);
                fl.createClasses(500, 750, 1000);
                fl.Coll = new ticketCollection(fl.Id);

                form.Height = this.Height;
                form.Width = this.Width;
                form.Location = this.Location;
                this.Close();
                form.loadFlightsDB();
                form.fillcomboBox();
                form.Show();

            }
            catch
            {
                MessageBox.Show("please fill the blanks with appropriate values");
            }

        }
    }
}
