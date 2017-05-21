using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Theater
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = textBox2.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter firstname");
                return;
            }
            if (String.IsNullOrEmpty(text1))
            {
                MessageBox.Show("Please enter lastname");
                return;
            }
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=reservation";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT into reservations(name,lastName,theater) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.label2.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Reservation saved");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form2 form2 = new Form2();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
