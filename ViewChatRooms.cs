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
        public ChatRoom cur;
        public static ListItem listItemSelected;
        MySqlConnection con;
        MySqlConnection con2;
        MySqlConnection con3;
        MySqlConnection con4;
        MySqlConnection con5;

        public ViewChatRooms()
        {
            InitializeComponent();
        }

        private void ViewChatRooms_Load(object sender, EventArgs e)
        {
            populateList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //mf.Show();
            //this.Hide();
            //MainForm.mainUser = null;
        }

        public void populateMessages( ChatRoom chatRoom, string chatRoomTitle)
        {
            flowLayoutPanel2.Controls.Clear();

            label1.Text = chatRoomTitle;
            if  (chatRoom.MessageStack == null) 
                chatRoom.MessageStack = new MessageStack<Message>();

            if (chatRoom.MessageStack.ViewAll() != null)
            {
                Message[] msgs = chatRoom.MessageStack.ViewAll();
                for (int i = 0; i < chatRoom.MessageStack.Length() + 1; i++)
                {
                    if (msgs[i] == null)
                        continue;
                    //Console.WriteLine(msgs[0].Text);
                    MessageItem messageItem = new MessageItem();
                    messageItem.Message = msgs[i];
                    messageItem.initializeMessageItem();
                    //messagesList.Items.Add(msgs[i].MessageStatus.DateTime + " " + userNames[msgs[i].UserId] + ": " + msgs[i].Text + " " + msgs[i].MessageStatus.IsSeen);
                    flowLayoutPanel2.Controls.Add(messageItem);
                }
            }
        }

        public void populateList()
        {
            if (MainForm.mainUser.ChatRoomsList != null)
            {
                ListItem[] listItems = new ListItem[MainForm.mainUser.ChatRoomsList.Length()];
                Node tmp = MainForm.mainUser.ChatRoomsList.head;
                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < listItems.Length; i++)
                {
                    string parts = "You";
                    listItems[i] = new ListItem();
                    listItems[i].ProfileImage = ProfImage.userprofilepicturedefault;
                    for (int j = 0; j < tmp.value.ChatRoomInfo.ListUsers.Count(); j++)
                    {
                        if (MainForm.mainUser.UserId != tmp.value.ChatRoomInfo.ListUsers[j].UserId)
                        {
                            if (MainForm.checkMutualContact(tmp.value.ChatRoomInfo.ListUsers[j]))
                            {
                                listItems[i].ProfileImage = tmp.value.ChatRoomInfo.ListUsers[j].UserDescription.ProfilePicture;
                            }
                            parts += ", " + tmp.value.ChatRoomInfo.ListUsers[j].FirstName;
                        }
                        if (!tmp.value.IsPrivate)
                        {
                            listItems[i].ProfileImage = ProfImage.userprofilepicturedefault;
                        }
                    }

                    cur = tmp.value;
                    listItems[i].curChatRoom = tmp.value;
                    listItems[i].ChatRoomPos = i;
                    string x = "New Chatroom";
                    if(tmp.value.MessageStack != null)
                    {
                        if (!tmp.value.MessageStack.Empty())
                            x = tmp.value.MessageStack.Top().Text;
                    }
                    
                    listItems[i].LastMessage =x;

                    if (tmp.value.LastDate.CompareTo( DateTime.Parse("01-01-2022")) > 0) 
                        listItems[i].LastDate = tmp.value.LastDate;

                    listItems[i].ChatRoomId = tmp.value.chatRoomId;
                    listItems[i].ChatRoomTitle = parts;

                    flowLayoutPanel1.Controls.Add(listItems[i]);
                    tmp = tmp.next;

                }
            }
        }

        public void updateStatus(ChatRoom ch)
        {
            
            if(ch.MessageStack != null)
            {
                Message[] msgs = ch.MessageStack.ViewAll();
                for (int i = ch.MessageStack.Length(); i > +0; i--)
                {
                    bool seen = true;
                    foreach (KeyValuePair<long, DateTime> td in ch.ChatRoomInfo.LastSeen)
                    {
                      if  (td.Key == MainForm.mainUser.UserId) continue;
                        if(msgs[i] != null)
                        {
                            if (msgs[i].MessageStatus.DateTime >= td.Value)
                            {
                                seen = false;
                                break;
                            }
                        }
                    }
                    if (msgs[i] != null)
                    {
                        if (seen)
                        {
                            msgs[i].MessageStatus.IsSeen = true;
                            con = new MySqlConnection(MainForm.dbConnStr);
                            con.Open();

                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "update messages set IsSeen = 1 where messageid = @msgid";
                            cmd.Parameters.AddWithValue("@msgid", msgs[i].MessageId);
                            cmd.ExecuteNonQuery();

                            con.Dispose();
                        }
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MainForm.dbConnStr);
            conn.Open();
            //Load stories into stories queue for users who have stories
            foreach (User sContact in MainForm.mainUser.Contacts.Values)
            {
                if (MainForm.checkMutualContact(sContact))
                {
                    getStories(sContact, conn);
                }
            }
            getStories(MainForm.mainUser, conn);

            ContactsStories cs = new ContactsStories();
            cs.Show();
            this.Hide();
            conn.Dispose();
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

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(MainForm.dbConnStr);
            conn.Open();
            //Load stories into stories queue for users who have stories
            foreach (User sContact in MainForm.mainUser.Contacts.Values)
            {
                getStories(sContact, conn);
            }
            getStories(MainForm.mainUser, conn);


            ContactsStories cs = new ContactsStories();
            cs.Show();
            this.Hide();
            conn.Dispose();

        }
        public void getStories(User sUser, MySqlConnection conn)
        {
            if (sUser.UserStories.Empty())
            {
                MySqlCommand cmd = new MySqlCommand("select * from stories where userid=@userid order by timepublished", conn);
                cmd.Parameters.AddWithValue("@userid", sUser.UserId);
                MySqlDataReader dr = cmd.ExecuteReader();
                int imageNumber = 1;
                while (dr.Read())
                {
                    //label1.Text = dr["storytext"].ToString();
                    byte[] img = (byte[])dr["photo"];
                    MemoryStream ms = new MemoryStream(img);
                    //pictureBox1.Image = Image.FromStream(ms);
                    //string x = dr["photopath"].ToString();


                    Story mystory = new Story(sUser.UserId, Image.FromStream(ms), dr["storytext"].ToString());
                    mystory.PublishedStoryTime = Convert.ToDateTime(dr["timepublished"].ToString());
                    imageNumber++;
                    sUser.UserStories.Enqueue(mystory);

                }
                dr.Close();
                //remove stories that are more than 24h ago

                while (!(sUser.UserStories.Empty()) && sUser.UserStories.Front().PublishedStoryTime <= DateTime.Now.AddDays(-1))
                {
                    sUser.UserStories.Dequeue();
                }
                //add remove from db
            }
        }

        

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            label2.Show();

        }

        private void logout_btn_MouseHover(object sender, EventArgs e)
        {
            label3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void user_prof_btn_MouseHover(object sender, EventArgs e)
        {
            label4.Show();
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            label6.Show();
        }

        private void iconButton3_MouseHover(object sender, EventArgs e)
        {
            label7.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Contacts.ContactList cl = new Contacts.ContactList();
            cl.Show();
            this.Hide();
        }

        private void participants_btn_MouseHover(object sender, EventArgs e)
        {
            label5.Show();
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageDetails md = new MessageDetails(cur);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
            MainForm.mainUser = null;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            Contacts.ContactList cl = new Contacts.ContactList();
            cl.Show();
            this.Hide();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void send_icon_btn_Click(object sender, EventArgs e)
        {
            string message_text = message_box.textBox1.Text;

            //messagesList.View = View.Details;
            Message message = new Message(MainForm.mainUser.UserId, message_text, cur.chatRoomId);
            MessageItem messageItem = new MessageItem();

            cur.MessageStack.Push(message);

            messageItem.Message = message;
            
            messageItem.initializeMessageItem();
            message_box.textBox1.Text = "";
            flowLayoutPanel2.Controls.Add(messageItem);
            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into messages values(@userid,@messageid,@chatroomid,@messagetext,@isSeen,@sentTime);";
            cmd.Parameters.AddWithValue("@userid", MainForm.mainUser.UserId);
            cmd.Parameters.AddWithValue("@messageid", message.MessageId);
            cmd.Parameters.AddWithValue("@chatroomid", cur.chatRoomId);
            cmd.Parameters.AddWithValue("@messagetext", message.Text);
            cmd.Parameters.AddWithValue("@isSeen", message.MessageStatus.IsSeen);
            cmd.Parameters.AddWithValue("@sentTime", message.MessageStatus.DateTime);

            cmd.ExecuteNonQuery();

            cmd.CommandText = "update chatrooms set lastDate  =  @lastDate where chatroomid = @chid;";
            cmd.Parameters.AddWithValue("@lastDate", message.MessageStatus.DateTime);
            cmd.Parameters.AddWithValue("@chid", cur.chatRoomId);

            cmd.ExecuteNonQuery();

            con.Dispose();
            listItemSelected.sendToTop();
            populateList();
        }

        private void Undo_button_Click(object sender, EventArgs e)
        {
            int index = cur.MessageStack.LastSentIndex();

            if (index > -1)
            {
                long undonMId = cur.MessageStack.Undo(index);
                con = new MySqlConnection(MainForm.dbConnStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from messages where messageid = @undonMId";
                cmd.Parameters.AddWithValue("@undonMId", undonMId);

                cmd.ExecuteNonQuery();

                con.Dispose();

                flowLayoutPanel2.Controls.RemoveAt(index);
            }
        }
    }
}
