using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ChatApplication.Contacts
{
    public partial class AddNewContactForm : Form
    {
        public AddNewContactForm()
        {
            InitializeComponent();
        }

        MySqlConnection con;

        string c = "server=localhost;database=sakila;uid=root;pwd=root;";

        private void AddContactbutton_Click(object sender, EventArgs e)
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
                //need to grab user found info 
                User contactUserFound = new User();// = user found
                KeyValuePair<string, User> contact = new KeyValuePair<string, User>(phoneNumber_txt.textBox1.Text, contactUserFound);
                MainForm.mainUser.getContactsList().Append(contact);
                //db set main user  new contact list
                //update DB
                //refresh parent form
                this.Close();
            }
            else
            {
                MessageBox.Show("This Phone Number does not exist.");
            }

            dr.Close();
            con.Dispose();
            
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
