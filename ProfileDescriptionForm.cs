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

        string c = "server=localhost;database=chat;uid=root;pwd=root;";
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
            phone_no_user_label.Text = CreateAccount.crmobileNumber;

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
            cmd.Parameters.AddWithValue("@id", MainForm.mainUser.UserId);
            cmd.Parameters.AddWithValue("@phone", MainForm.mainUser.MobileNumber);
            cmd.Parameters.AddWithValue("@pass", MainForm.mainUser.Password);
            cmd.Parameters.AddWithValue("@fname", MainForm.mainUser.FirstName);
            cmd.Parameters.AddWithValue("@lname", MainForm.mainUser.LastName);
            cmd.Parameters.AddWithValue("@AboutDescription", MainForm.mainUser.UserDescription.AboutDescription);
            cmd.Parameters.AddWithValue("@isVisible", MainForm.mainUser.UserDescription.IsVisible);
            cmd.Parameters.AddWithValue("@ProfilePicture", MainForm.mainUser.UserDescription.ProfilePicture);

            int r =cmd.ExecuteNonQuery();
            if (r != -1)
            {
                //open next form
                MessageBox.Show("Account added successfully");
            }
            con.Dispose();
            ViewChatRooms v= new ViewChatRooms();
            v.Show();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        private void profilePicture_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                   profilePicture.ImageLocation = dialog.FileName;


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error ocurred", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
