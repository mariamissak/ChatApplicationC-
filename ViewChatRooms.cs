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
using System.IO;

namespace ChatApplication
{
    public partial class ViewChatRooms : Form
    {
        private ChatRoom cur;
        MySqlConnection con;

        string c = "server=localhost;database=sakila;uid=root;pwd=root;";
        public ViewChatRooms()
        {
            InitializeComponent();
        }
        private void populateItems()
        {
            //    //ListItem[] listItems = new ListItem[MainForm.mainUser.getChatRoomsList().Length()];
            ListItem mem = new ListItem();
            mem.ChatRoomTitle = "hello";
            mem.LastMessage = "mariam";
            //panel2.Controls.Add(mem);

            //    ListItem[] listItems = new ListItem[5];
            ////    //Node tmp = MainForm.mainUser.getChatRoomsList().head;
            //    for (int i=0;i<listItems.Length;i++)
            //    {

            ////        string parts="";
            //        listItems[i] = new ListItem();
            ////        //for (int j = 0; j < tmp.value.chatRoomInfo.listOfUsers.Count();j++)
            ////        //{
            ////        //    if(MainForm.mainUser.getUserId()!= tmp.value.chatRoomInfo.listOfUsers[j].getUserId())
            ////        //    parts = tmp.value.chatRoomInfo.listOfUsers[j].getFirstName() + ", ";
            ////        //}
            ////        //listItems[i].ChatRoomTitle = parts;
            ////        //listItems[i].LastMessage = tmp.value.GetMessageStack().Top().getMessage();
            //listItems[i].ChatRoomTitle = "hello";
            //        listItems[i].LastMessage = "mymessage";
            //        //        //tmp = tmp.next;

            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            else
                panel2.Controls.Add(mem);

        }

    
            private void ViewChatRooms_Load(object sender, EventArgs e)
        {
            //to make messages vertical
            messagesList.View = View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            messagesList.Columns.Add(header);
            
           // messagesList.cLayoutColumnHeaders.MaximumTextLines = messagesList.LayoutItemsCurrent.MaximumTextLines = 3;
            //    con = new MySqlConnection(c);
            //    con.Open();
            //    MySqlCommand cmd = new MySqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "select * from chatroomusers where userid = @userid";
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@userid", MainForm.mainUser.UserId);

            //    MySqlDataReader chatroomsOfMainUser = cmd.ExecuteReader();

            //    while(chatroomsOfMainUser.Read())
            //    {
            //        MySqlCommand cmd2 = new MySqlCommand();
            //        cmd2.Connection = con;
            //        cmd2.CommandText = "select * from chatrooms where chatroomid = @chid";
            //        cmd2.CommandType = CommandType.Text;
            //        cmd2.Parameters.AddWithValue("@chid", chatroomsOfMainUser[0]);
            //        MySqlDataReader detailsOfChatRoom = cmd2.ExecuteReader();
            //        if(detailsOfChatRoom.Read())
            //        {
            //            MySqlCommand cmd3 = new MySqlCommand();
            //            cmd3.Connection = con;
            //            cmd3.CommandText = "select * from chatroomusers where chatroomid = @chid";
            //            cmd3.CommandType = CommandType.Text;
            //            cmd3.Parameters.AddWithValue("@chid", detailsOfChatRoom[0]);
            //            MySqlDataReader allUsersInChatRoom = cmd3.ExecuteReader();
            //            List<User> listOfUsers = new List<User>();
            //            while (allUsersInChatRoom.Read())
            //            {
            //                MySqlCommand cmd4 = new MySqlCommand();
            //                cmd4.Connection = con;
            //                cmd4.CommandText = "select * from users where userid = @uid";
            //                cmd4.CommandType = CommandType.Text;
            //                cmd4.Parameters.AddWithValue("@uid", allUsersInChatRoom[1]);
            //                MySqlDataReader userDetailsInChatROOM = cmd4.ExecuteReader();
            //                if (userDetailsInChatROOM.Read())
            //                {
            //                    byte[] img = (byte[])userDetailsInChatROOM[7];
            //                    MemoryStream ms = new MemoryStream(img);

            //                    Image prof = Image.FromStream(ms);
            //                    listOfUsers.Add(new User(Convert.ToInt64(userDetailsInChatROOM[0].ToString()), userDetailsInChatROOM[1].ToString(), userDetailsInChatROOM[2].ToString(), userDetailsInChatROOM[3].ToString(), userDetailsInChatROOM[4].ToString(), prof, userDetailsInChatROOM[5].ToString(), Convert.ToBoolean(userDetailsInChatROOM[6])));
            //                }
            //            }
            //            ChatRoom ch = new ChatRoom(Convert.ToInt64(detailsOfChatRoom[0].ToString()), Convert.ToBoolean(detailsOfChatRoom[1]),listOfUsers);
            //            MainForm.mainUser.setChatRoomList(ch);
            //        }
            //    }
            //    populateList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //mf.Show();
            //this.Hide();
            //MainForm.mainUser = null;

        }
        //public void populateMessages(MessageStack<Message> messages, ChatRoom chatRoom, string chatRoomTitle)
        //{
        //    label1.Text = chatRoomTitle;
        //    Dictionary<long, string> userNames = new Dictionary<long, string>();
        //    for(int i = 0; i< chatRoom.chatRoomInfo.listOfUsers.Count(); i++)
        //    {
        //        userNames.Add(chatRoom.chatRoomInfo.listOfUsers[i].UserId, chatRoom.chatRoomInfo.listOfUsers[i].FirstName);
        //    }
        //    Message [] msgs = messages.ViewAll();
        //    for (int i = 0; i<msgs.Count(); i++)
        //    {
        //        messagesList.Items.Add(msgs[i].MessageStatus.DateTime+ " "+ userNames[msgs[i].UserId] +": " + msgs[i].getMessage() + " " + msgs[i].MessageStatus.IsSeen);
        //    }

        //}
        //private void populateList()
        //{
        //    ListItem[] listItems = new ListItem[MainForm.mainUser.ChatRoomsList.Length()];
        //    Node tmp = MainForm.mainUser.ChatRoomsList.head;
        //    for (int i = 0; i < listItems.Length; i++)
        //    {

        //        string parts = "(You)";
        //        listItems[i] = new ListItem();
        //        for (int j = 0; j < tmp.value.chatRoomInfo.listOfUsers.Count(); j++)
        //        {
        //            if (tmp.value.chatRoomInfo.listOfUsers.Count() > 2) listItems[i].ProfileImage = ProfImage.userprofilepicturedefault;

        //            if (MainForm.mainUser.UserId != tmp.value.chatRoomInfo.listOfUsers[j].UserId)
        //            {
        //                listItems[i].ProfileImage = tmp.value.chatRoomInfo.listOfUsers[j].UserDescription.ProfilePicture;
        //                parts += ", " + tmp.value.chatRoomInfo.listOfUsers[j].FirstName;
        //            }

        //        }
        //        cur = tmp.value;
        //        listItems[i].curChatRoom = tmp.value;
        //        listItems[i].ChatRoomPos = i;
        //        listItems[i].ChatRoomId = tmp.value.chatRoomId;
        //        listItems[i].ChatRoomTitle = parts;
        //        listItems[i].LastMessage = tmp.value.GetMessageStack().Top().getMessage();
        //        flowLayoutPanel1.Controls.Add(listItems[i]);
        //        tmp = tmp.next;


        //    }

        //}

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //ViewProfile prof = new ViewProfile();
            //prof.Show();
        }

        private void messagesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            //ChatRoomUsers ch = new ChatRoomUsers(cur);
            //ch.Show();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //string message_text = String.Format(@"{0}  - {1}
            //               {2}
            //               -----------------------------------", "Me:", message_box.textBox1.Text, DateTime.Now);
            ////string message_text = @"farah
            //                      hello";
            // string message_text =message_box.textBox1.Text;
            string message_text = "Me: " + message_box.textBox1.Text;
           
            messagesList.View = View.Details;
            //Message message = new Message(MainForm.mainUser.UserId, message_text, cur.chatRoomId);
            //messagesList.BeginUpdate();
            messagesList.Items.Add(message_text);
            messagesList.Items.Add(DateTime.Now.ToString());
            messagesList.Items.Add("--------------------------------------");
            //messagesList.EndUpdate();
            //this.Controls.Add(this.messagesList);
            // messagesList.Items.Add(message.MessageStatus.DateTime.ToString());
            //MessageBox.Show("Button clicked");
            messagesList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);

            //con = new MySqlConnection(c);
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "insert into messages values(@userid,@messageid,@chatroomid,@messagetext,@isSeen);";
            //cmd.Parameters.AddWithValue("@userid", MainForm.mainUser.UserId);
            //cmd.Parameters.AddWithValue("@messageid", message.MessageId);
            //cmd.Parameters.AddWithValue("@chatroomid", cur.chatRoomId);
            //cmd.Parameters.AddWithValue("@messagetext", message.Text);
            //cmd.Parameters.AddWithValue("@isSeen", message.MessageStatus.IsSeen);
            //cmd.ExecuteNonQuery();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
            MainForm.mainUser = null;
        }

        private void user_prof_btn_Click(object sender, EventArgs e)
        {
            ViewProfile prof = new ViewProfile();
            prof.Show();
        }

        private void participants_btn_Click(object sender, EventArgs e)
        {
            ChatRoomUsers ch = new ChatRoomUsers(cur);
            ch.Show();
        }

        private void ViewChatRooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Dispose();
        }
    }
    }
