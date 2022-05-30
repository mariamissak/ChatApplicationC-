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
namespace ChatApplication
{
    public partial class ListItem : UserControl
    {
        MySqlConnection con;
        
        public ListItem()
        {
            InitializeComponent();
        }
        #region Properties
        private long chatRoomId;
        public long ChatRoomId
        {
            get { return chatRoomId; }
            set { chatRoomId = value;}
        }
        private ChatRoom chatRoom;
        public ChatRoom curChatRoom
        {
            get { return chatRoom; }
            set { chatRoom = value; }
        }
        private int chatRoomPos;
        public int ChatRoomPos
        {
            get { return chatRoomPos; }
            set { chatRoomPos = value; }
        }
        private string chatRoomTitle;
        [Category ("Custom Props")]
        public string ChatRoomTitle
        {
            get { return chatRoomTitle; }
            set { chatRoomTitle = value; chatRoomName_label.Text = value; }
        }
        private DateTime lastDate;
        [Category("Custom Props")]
        public DateTime LastDate
        {
            get { return lastDate; }
            set { lastDate = value; date_label.Text = value.ToString(); }
        }
        private string lastMessage;
        [Category("Custom Props")]
        public  string LastMessage
        {
            get { return lastMessage; }
            set { lastMessage = value; message_label.Text = value; }
        }
        private Image profileImage;
        [Category("Custom Props")]
        public Image ProfileImage
        {
            get { return profileImage; }
            set { profileImage = value; circularPictureBox1.Image = value;   }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.mainUser.ChatRoomsList.At(chatRoomPos).ChatRoomInfo.LastSeen[MainForm.mainUser.UserId] = DateTime.Now;
            if (MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack != null)
            {
                for (int i = 0; i < MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack.Length() + 1; i++)
                {
                    if(!MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack.Empty())
                    MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack.Pop();
                }
                //if (MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack.Length() == 0)
                con = new MySqlConnection(MainForm.dbConnStr);
                con.Open();
                MySqlCommand cmd5 = new MySqlCommand();
                cmd5.Connection = con;
                cmd5.CommandText = "select * from messages where chatroomid = @chatroomid";
                cmd5.CommandType = CommandType.Text;
                cmd5.Parameters.AddWithValue("@chatroomid", chatRoomId);

                MySqlDataReader dr = cmd5.ExecuteReader();

                while (dr.Read())
                {
                    MainForm.mainUser.ChatRoomsList.At(chatRoomPos).LastDate = Convert.ToDateTime(dr["timeSent"]);
                    MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack.Push(new
                          Message(Convert.ToInt64(dr[0].ToString()),
                                  Convert.ToInt64(dr[1].ToString()),
                                  dr[3].ToString(),
                                  Convert.ToInt64(dr[2].ToString()),
                                  Convert.ToDateTime(dr["timeSent"]),
                                  Convert.ToBoolean(dr["isSeen"]))
                          );
                }

                dr.Close();

            }
            ViewChatRooms pForm = (ViewChatRooms)ParentForm;
                pForm
                    .populateMessages(
                                      MainForm.mainUser.ChatRoomsList.At(chatRoomPos), chatRoomTitle);

                pForm.cur = chatRoom;
                MainForm.mainUser.ChatRoomsList.At(chatRoomPos).ChatRoomInfo.updateLastSeen(MainForm.mainUser.UserId);
                pForm.updateStatus(chatRoom);
                 ViewChatRooms.listItemSelected = this;
     
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void contactName_Click(object sender, EventArgs e)
        {

        }

        public void sendToTop()
        {
            ChatRoom chat = MainForm.mainUser.ChatRoomsList.At(chatRoomPos);
            MainForm.mainUser.ChatRoomsList.At(chatRoomPos).LastDate = DateTime.Now;

            MainForm.mainUser.ChatRoomsList.DeleteAt(chatRoomPos);
            MainForm.mainUser.ChatRoomsList.InsertAt(0, chat);

            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update chatrooms set lastdate = @lastdate where chatroomid = @chid";
            cmd.Parameters.AddWithValue("@lastdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@chid", chat.chatRoomId);
            cmd.ExecuteNonQuery();

            con.Dispose();
        }
    }



}
