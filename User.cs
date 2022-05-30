using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace ChatApplication
{
	public class User
	{
        MySqlConnection con;
    
        private long userId;
        public long UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private String mobileNumber;
        public String MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        private String password;
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        private String firstName;
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private String lastName;
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private StoriesQueue<Story> userStories;
        public StoriesQueue<Story> UserStories
        {
            get { return userStories; }
            set { userStories = value; }
        }

        private UserProfileDescription userDescription;
        public UserProfileDescription UserDescription
        {
            get { return userDescription; }
            set { userDescription = value; }
        }

        private Dictionary<string, User> contacts; //pointer to user or userId
        public Dictionary<string, User> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }

        private ChatRoomsList chatRoomsList;
        public ChatRoomsList ChatRoomsList
        {
            get { return chatRoomsList; }
            set { chatRoomsList = value; }
        }

        public User(string mobileNumber, string password, string firstName, string lastName, Image ProfilePicture, string aboutDescription, bool isVisible)
        {
            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(userid) from users;";

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) userId = Convert.ToInt64(dr[0]) +  1;
            else userId = 1;

            //userId = counter;
            this.mobileNumber = mobileNumber;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            userStories = new StoriesQueue<Story>();
            contacts = new Dictionary<string, User>();
            chatRoomsList = new ChatRoomsList();

            userDescription = new UserProfileDescription(this.userId, ProfilePicture, aboutDescription, isVisible);
            dr.Close();
            con.Dispose();
        }

        public User(long userId, string mobileNumber, string password, string firstName, string lastName, Image ProfilePicture, string aboutDescription, bool isVisible)
        {
            this.userId = userId;
            this.mobileNumber = mobileNumber;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            userStories = new StoriesQueue<Story>();
            contacts = new Dictionary<string, User>();
            chatRoomsList = new ChatRoomsList();

            userDescription = new UserProfileDescription(this.userId, ProfilePicture, aboutDescription, isVisible);
        }
        public User(long userId, string mobileNumber, string password, string firstName, string lastName, string aboutDescription, bool isVisible)
        {
            this.userId = userId;
            this.mobileNumber = mobileNumber;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            userStories = new StoriesQueue<Story>();
            contacts = new Dictionary<string, User>();
            chatRoomsList = new ChatRoomsList();

            userDescription = new UserProfileDescription(this.userId, ProfImage.userprofilepicturedefault, aboutDescription, isVisible);
       
        }

        public void setChatRoomList(ChatRoom chatroom)
        {
            chatRoomsList.Append(chatroom);
        }
    }
}
