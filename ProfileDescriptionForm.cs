using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChatApplication;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace ChatApplication
{
    
    public partial class ProfileDescriptionForm : Form
    {
        MySqlConnection con;

        string c = "server=localhost;database=sakila;uid=root;pwd=root;";
         Image ProfilePicture;
         String AboutDescription;
         Boolean IsVisible;
        public ProfileDescriptionForm()
        {
            InitializeComponent();
        }

        private void ProfileDescriptionForm_Load(object sender, EventArgs e)
        {
            fnameUser_label.Text = CreateAccount.crfirstName;
            lnameUser_label.Text = CreateAccount.crlastName;

        }

        private void createAccount_btn_Click(object sender, EventArgs e)
        {
            if (profilePicture!=null)
            {
                ProfilePicture = profilePicture.Image;
            }
           else
            {
                profilePicture.Image = ProfImage.userprofilepicturedefault;
            }
            
            IsVisible = Convert.ToBoolean(isVisible_toggle.Checked.ToString());
            AboutDescription = about_txt.textBox1.Text.ToString();
            //photo details to be continued
            MainForm.mainUser = new User(CreateAccount.crmobileNumber, CreateAccount.crpassword, CreateAccount.crfirstName, CreateAccount.crlastName, ProfilePicture, AboutDescription, IsVisible);
            con = new MySqlConnection(c);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Users values(@id,@phone,@pass,@fname,@lname, @AboutDescription, @IsVisible,@ProfilePicture);";
            cmd.Parameters.AddWithValue("@id", MainForm.mainUser.getUserId());
            cmd.Parameters.AddWithValue("@phone", MainForm.mainUser.getMobileNumber());
            cmd.Parameters.AddWithValue("@pass", MainForm.mainUser.getPassword());
            cmd.Parameters.AddWithValue("@fname", MainForm.mainUser.getFirstName());
            cmd.Parameters.AddWithValue("@lname", MainForm.mainUser.getLastName());
            cmd.Parameters.AddWithValue("@AboutDescription", MainForm.mainUser.GetUserProfileDescription().getAboutDescription());
            cmd.Parameters.AddWithValue("@isVisible", MainForm.mainUser.GetUserProfileDescription().getIsVisible());
            cmd.Parameters.AddWithValue("@ProfilePicture", MainForm.mainUser.GetUserProfileDescription().getProfilePicture());

            int r =cmd.ExecuteNonQuery();
            if (r != -1)
            {
                //open next form
                MessageBox.Show("Account added successfully");
            }
            con.Dispose();
        }
    }
}
