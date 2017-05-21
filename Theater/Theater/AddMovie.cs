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
    public partial class AddMovie : Form
    {
       
        public AddMovie()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = textBox2.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter the movie");
                return;
            }
            if (String.IsNullOrEmpty(text1))
            {
                MessageBox.Show("Please enter the time of movie");
                return;
            }

            try
            { 
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "INSERT into movie1(movieName1,movieTime1) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Movie saved!");
               
                while (MyReader2.Read())
                    {
                    
                    }
                    MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form1 form1 = new Form1();
            form1.buttonUpdate();
            Form2 form2 = new Form2();
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = textBox2.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter the movie");
                return;
            }
            if (String.IsNullOrEmpty(text1))
            {
                MessageBox.Show("Please enter the time of movie");
                return;
            }
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT into movie2(movieName2,movieTime2) values('" + this.textBox6.Text + "','" + this.textBox5.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Movie saved!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = textBox2.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter the movie");
                return;
            }
            if (String.IsNullOrEmpty(text1))
            {
                MessageBox.Show("Please enter the time of movie");
                return;
            }
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT into movie3(movieName3,movieTime3) values('" + this.textBox9.Text + "','" + this.textBox8.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Movie saved!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = textBox2.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter the movie");
                return;
            }
            if (String.IsNullOrEmpty(text1))
            {
                MessageBox.Show("Please enter the time of movie");
                return;
            }
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT into movie4(movieName4,movieTime4) values('" + this.textBox12.Text + "','" + this.textBox11.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Movie saved!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
