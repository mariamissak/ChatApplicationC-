using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                MemoryStream memoryStream = new MemoryStream((byte)dr[7]);
                
                //need to grab user found info 
                User contactUserFound = new User(Convert.ToInt64(dr[0]),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(),Image.FromStream(memoryStream),dr[5].ToString(),Convert.ToBoolean(dr[6]));// = user found
                KeyValuePair<string, User> contact = new KeyValuePair<string, User>(phoneNumber_txt.textBox1.Text, contactUserFound);
                MainForm.mainUser.Contacts.Append(contact);
                //db set main user  new contact list
                // MessageBox.Show("Contact Added Successfully.");
                //update DB

                cmd.CommandText = "insert into contacts values(@id,@phone);";
                cmd.Parameters.AddWithValue("@id", MainForm.mainUser.UserId);
                cmd.Parameters.AddWithValue("@phone", contactUserFound.MobileNumber);

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Contact added successfully");
                }

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
