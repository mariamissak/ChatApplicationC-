using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ChatApplication
{
   
    public partial class CreateAccount : Form
    {
        MySqlConnection con;

        string c = "server=localhost;database=sakila;uid=root;pwd=root;";

        public static string crmobileNumber;
        public static string crpassword;
        public static string crfirstName;
        public static string crlastName;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void terms_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (terms_chk.Checked)
            {
                next_btn.Visible = true;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            next_btn.Visible = false;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {

            con = new MySqlConnection(c);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from users where phoneNumber = @ph";
            cmd.Parameters.AddWithValue("@ph", phoneNumber_txt.textBox1.Text);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("This Phone Number Already has an Account.");
            }
            else
            {
                
                crfirstName = fname_txt.textBox1.Text;
                crlastName = lname_txt.textBox1.Text;
                crmobileNumber = phoneNumber_txt.textBox1.Text;
                crpassword = password_txt.textBox1.Text;
                ProfileDescriptionForm pr = new ProfileDescriptionForm();
                pr.Show();
                this.Hide();
            }

            dr.Close();
            con.Dispose();
            
        }
    }
}
