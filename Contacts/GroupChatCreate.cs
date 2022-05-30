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
    public partial class GroupChatCreate : Form
    {
        Dictionary<string, User> contactInfos = MainForm.mainUser.Contacts;
        public GroupChatCreate()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateGroupChatButton_Click(object sender, EventArgs e)
        {

            List<User> users = new List<User>();
            users.Insert(0,MainForm.mainUser);
            User contact;
            string[] mobnum;
            foreach (var li in CheckContactsCheckBoxsList.CheckedItems)
            {
               
                mobnum = li.ToString().Split(':');
                contactInfos.TryGetValue(mobnum[1], out contact);
                users.Add(contact);
            }
            /*for (int i = 0; i < CheckContactsCheckBoxsList.SelectedItems.Count; i++ ) 
            {
                CheckContactsCheckBoxsList.SelectedItems[i].ToString().Split(':');
                contactInfos.TryGetValue(mobnum[1],out contact);
                users.Add(contact);
            }*/
            ChatRoom newChatRoom = new ChatRoom(false, users);
            MainForm.mainUser.ChatRoomsList.InsertAt(0,newChatRoom);

            

            MySqlConnection con;

            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into chatrooms values(@chatroomId,@private,@lastDate);";
            cmd.Parameters.AddWithValue("@chatroomId", newChatRoom.chatRoomId);
            cmd.Parameters.AddWithValue("@private", 0);
            cmd.Parameters.AddWithValue("@lastDate", newChatRoom.LastDate.ToString());

            int r = cmd.ExecuteNonQuery();


            con.Dispose();


            foreach(User user in users)
            {
                con = new MySqlConnection(MainForm.dbConnStr);
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into chatroomusers values(@chatroomId,@userId,@lastSeen);";
                cmd.Parameters.AddWithValue("@chatroomId", newChatRoom.chatRoomId);
                cmd.Parameters.AddWithValue("@userId", user.UserId);
                cmd.Parameters.AddWithValue("@lastSeen", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                con.Dispose();
            }

           
            ViewChatRooms VCR = new ViewChatRooms();
            VCR.Show();
            this.Hide();
        }
        private void GroupChatCreate_Load(object sender, EventArgs e)
        {


            foreach(KeyValuePair<string , User > contactInfo in contactInfos)
            {
                CheckContactsCheckBoxsList.Items.Add(contactInfo.Value.FirstName + " " + contactInfo.Value.LastName + ":" + contactInfo.Key);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            ContactList CL = new ContactList();
            CL.Show();
            this.Hide();
        }
    }
}
