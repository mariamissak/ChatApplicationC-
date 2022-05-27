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

        public User Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        private void ContactDiscriptor_Load(object sender, EventArgs e)
        {
            _fullName = _contact.FirstName + " " + _contact.LastName;
            contactName.Text = _fullName;
            _img = _contact.UserDescription.ProfilePicture;
            //requestImageFromUrl(_img);

            _phoneNumber = _contact.MobileNumber;
            _description = _contact.UserDescription.AboutDescription;
            bio.Text = _description;
            mobileNumber.Text = _phoneNumber;
            profilePicture.BackgroundImage = _img;
            if (_contact.UserStories.empty())
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
            int chatroomIndex = MainForm.mainUser.ChatRoomsList.findPrivateChatroom(_contact.UserId);
            ChatRoom newChatRoom;
            if ( chatroomIndex == -1) 
            {
                List<User> users = new List<User>();
                users.Insert(0,MainForm.mainUser);
                users.Insert(1, _contact);

                newChatRoom = new ChatRoom(true , users);
                MainForm.mainUser.ChatRoomsList.InsertAt(0,newChatRoom);
                chatroomIndex = 0;

                //opening sql connection
                MySqlConnection con;
 
                con = new MySqlConnection(MainForm.dbConnStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "insert into chatrooms values(@chatroomId,@private,@lastDate);";
                cmd.Parameters.AddWithValue("@chatroomId", newChatRoom.chatRoomId);
                cmd.Parameters.AddWithValue("@private", 1);
                cmd.Parameters.AddWithValue("@lastDate", newChatRoom.LastDate.ToString());
                

                int r = cmd.ExecuteNonQuery();
                // if (r != -1)
                // {
                //     MessageBox.Show("Contact added successfully");
                // }

                cmd.CommandText = "insert into chatroomusers values(@chatroomId,@userId,@lastSeen);";
                cmd.Parameters.AddWithValue("@chatroomId", newChatRoom.chatRoomId);
                cmd.Parameters.AddWithValue("@userId", MainForm.mainUser.UserId);
                cmd.Parameters.AddWithValue("@lastSeen", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "insert into chatroomusers values(@chatroomId,@userId,@lastSeen);";
                cmd.Parameters.AddWithValue("@chatroomId", newChatRoom.chatRoomId);
                cmd.Parameters.AddWithValue("@userId", _contact.UserId);
                cmd.Parameters.AddWithValue("@lastSeen", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();

                con.Dispose();

            } else {
                newChatRoom = MainForm.mainUser.ChatRoomsList.At(chatroomIndex);
            }

            


            //goes to new form 
            //for when we open new chatroom form
            //ChatRoom contactChatroom = MainForm.mainUser.getChatRoomsList().At(chatroomIndex);
            //ViewChatRooms vCR = new ViewChatRooms();
        }
    }
}
