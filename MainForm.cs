using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using ChatApplication;


namespace ChatApplication
{
    public partial class MainForm : Form
    {

        public static User mainUser;
        public static string dbConnStr = "server=sql11.freesqldatabase.com;database=sql11495725;uid=sql11495725;pwd=iDswq8DKc8;";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void creatAccount_btn_Click(object sender, EventArgs e)
        {
            CreateAccount CA = new CreateAccount();
            CA.Show();
            this.Hide();
        }

        public static bool checkMutualContact(User contact)
        {
            // handy lil null check
            if (mainUser == null || contact == null)
            {
                return false;
            }

            if (contact.UserDescription.IsVisible)
            {
                return true;
            }

            MySqlConnection con = new MySqlConnection(dbConnStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from contacts where userId = @id and phonenumber = @ph";
            cmd.Parameters.AddWithValue("@id", contact.UserId);
            cmd.Parameters.AddWithValue("@ph", mainUser.MobileNumber);

            MySqlDataReader dr = cmd.ExecuteReader();

            bool res = false;

            if (dr.Read())
            {
                res = true;
            }

            dr.Close();
            con.Dispose();


            return res;
        }
    }
}
