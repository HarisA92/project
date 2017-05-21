using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Theater
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=movies"))
            {
                MySqlCommand command =
                new MySqlCommand("SELECT * FROM movie1", connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        button6.Text = (reader["movieName1"].ToString() + " " + reader["movieTime1"].ToString());

                    }
                MySqlCommand command1 =
                new MySqlCommand("SELECT * from movie2 ", connection);
               
                using (MySqlDataReader reader1 = command1.ExecuteReader())
                    while (reader1.Read())
                    {
                        button7.Text = (reader1["movieName2"].ToString() + " " + reader1["movieTime2"].ToString());
                    }
                MySqlCommand command2 =
               new MySqlCommand("SELECT * from movie3 ", connection);

                using (MySqlDataReader reader2 = command2.ExecuteReader())
                    while (reader2.Read())
                    {
                        button8.Text = (reader2["movieName3"].ToString() + " " + reader2["movieTime3"].ToString());
                    }
                MySqlCommand command3 =
               new MySqlCommand("SELECT * from movie4 ", connection);

                using (MySqlDataReader reader3 = command3.ExecuteReader())
                    while (reader3.Read())
                    {
                        button9.Text = (reader3["movieName4"].ToString() + " " + reader3["movieTime4"].ToString());
                    }
            }




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void buttonUpdate()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=movies"))
            {
                MySqlCommand command =
                new MySqlCommand("SELECT * FROM movie1", connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        button6.Text = (reader["movieName1"].ToString() + " " + reader["movieTime1"].ToString());

                    }
                MySqlCommand command1 =
                new MySqlCommand("SELECT * from movie2 ", connection);

                using (MySqlDataReader reader1 = command1.ExecuteReader())
                    while (reader1.Read())
                    {
                        button7.Text = (reader1["movieName2"].ToString() + " " + reader1["movieTime2"].ToString());
                    }
                MySqlCommand command2 =
               new MySqlCommand("SELECT * from movie3 ", connection);

                using (MySqlDataReader reader2 = command2.ExecuteReader())
                    while (reader2.Read())
                    {
                        button8.Text = (reader2["movieName3"].ToString() + " " + reader2["movieTime3"].ToString());
                    }
                MySqlCommand command3 =
               new MySqlCommand("SELECT * from movie4 ", connection);

                using (MySqlDataReader reader3 = command3.ExecuteReader())
                    while (reader3.Read())
                    {
                        button9.Text = (reader3["movieName4"].ToString() + " " + reader3["movieTime4"].ToString());
                    }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                       

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }


        private void button12_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.ShowDialog();
          

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddMovie form = new AddMovie();
            form.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //snacks
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
