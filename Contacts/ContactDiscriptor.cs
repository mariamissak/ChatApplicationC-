using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ChatApplication.Contacts
{
    public partial class ContactDiscriptor : UserControl
    {
        public ContactDiscriptor()
        {
            InitializeComponent();
        }

        private User _contact;
        private Image _img;
        private string _fullName;
        private string _description;
        private string _phoneNumber;



        //profilePicture
        //contactName
        //bio
        //story button
        /*void requestImageFromUrl(string value)
        {
            Stream tempStream = null;
            HttpWebResponse imgResponse = null;
            try
            {
                HttpWebRequest imgRequest = (HttpWebRequest)HttpWebRequest.Create(value);
                imgRequest.AllowWriteStreamBuffering = true;
                imgResponse = (HttpWebResponse)imgRequest.GetResponse();
                tempStream = imgResponse.GetResponseStream();
                Bitmap avatarBitMap;
                //set Background image
                if (tempStream != null)
                {
                    avatarBitMap = new Bitmap(tempStream);
                    avatarBitMap = new Bitmap(avatarBitMap, profilePicture.Width, profilePicture.Height);

                    profilePicture.BackgroundImage = avatarBitMap;
                }
            }
            catch { }
            finally
            {
                if (tempStream != null)
                    tempStream.Close();
                if (imgResponse != null)
                {
                    imgResponse.Close();
                }
            }
        }*/

        public User Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        private void ContactDiscriptor_Load(object sender, EventArgs e)
        {
            _fullName = _contact.getFirstName() + " " + _contact.getLastName();
            contactName.Text = _fullName;
            _img = _contact.GetUserProfileDescription().getProfilePicture() ;
            //requestImageFromUrl(_img);

            _phoneNumber = _contact.getMobileNumber();
            _description = _contact.GetUserProfileDescription().getAboutDescription();
            bio.Text = _description;
            mobileNumber.Text = _phoneNumber;
            profilePicture.BackgroundImage = _img;
            if (_contact.getStoriesQueue().empty())
            {
                storyViewButton.Visible = false;
            }
        }

        private void bio_Click(object sender, EventArgs e)
        {

        }

        private void contactName_Click(object sender, EventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        private void storyViewButton_Click(object sender, EventArgs e)
        {
            //move to storyViewform
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            int chatroomIndex = MainForm.mainUser.getChatRoomsList().findPrivateChatroom(_contact.getUserId());
            if ( chatroomIndex == -1) 
            {
                List<User> users = new List<User>();
                users.Insert(0,MainForm.mainUser);
                users.Insert(1, _contact);

                ChatRoom newChatRoom = new ChatRoom("private", users);
                MainForm.mainUser.getChatRoomsList().InsertAt(0,newChatRoom);
                chatroomIndex = 0;
            }

            //opening sql connection
            MySqlConnection con;

            string c = "server=localhost;database=sakila;uid=root;pwd=root;";

            con = new MySqlConnection(c);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "insert into Users values(@id,@phone,@IsVisible,@ProfilePicture);";
            cmd.Parameters.AddWithValue("@id", MainForm.mainUser.getUserId());
            cmd.Parameters.AddWithValue("@phone", MainForm.mainUser.getMobileNumber());
            cmd.Parameters.AddWithValue("@pass", MainForm.mainUser.getPassword());
            cmd.Parameters.AddWithValue("@fname", MainForm.mainUser.getFirstName());
            cmd.Parameters.AddWithValue("@ProfilePicture", MainForm.mainUser.GetUserProfileDescription().getProfilePicture());

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Contact added successfully");
            }
            con.Dispose();


            //goes to new form 
            //for when we open new chatroom form
            //ChatRoom contactChatroom = MainForm.mainUser.getChatRoomsList().At(chatroomIndex);
            //ViewChatRooms vCR = new ViewChatRooms();
        }
    }
}
