using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.IO;


namespace ChatApplication
{
    public partial class LogIn : Form
    {
        MySqlConnection con; 

       string c = "server=localhost;database=sakila;uid=root;pwd=root;";


        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(c);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from users where phoneNumber = @ph and password = @pass;";
            cmd.Parameters.AddWithValue("@ph", phoneNumber_txt.textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", password_txt.textBox1.Text);

            MySqlDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read())
            {
                byte[] img = (byte[])dr[7];
                MessageBox.Show("Logged In!");
                MemoryStream ms = new MemoryStream(img);

                Image prof = Image.FromStream(ms);
                MainForm.mainUser = new User(Convert.ToInt64(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), prof , dr[5].ToString(), Convert.ToBoolean(dr[6]));
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            dr.Close();
            con.Dispose();
        }
    }
}
