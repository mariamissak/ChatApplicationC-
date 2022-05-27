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

        string c = "server=localhost;database=sakila;uid=root;pwd=root;";

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
            con = new MySqlConnection(c);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from messages where chatroomid = @chatroomid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@chatroomid", ChatRoomId);

            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                MainForm.mainUser.ChatRoomsList.At(chatRoomPos).MessageStack.Push(new Message(Convert.ToInt64(dr[0].ToString()), Convert.ToInt64(dr[1].ToString()), dr[3].ToString(),Convert.ToInt64(dr[2].ToString())));
            }
            ViewChatRooms pForm = (ViewChatRooms)ParentForm;
            //pForm.populateMessages(MainForm.mainUser.ChatRoomsList.At(chatRoomPos).GetMessageStack(), MainForm.mainUser.ChatRoomsList.At(chatRoomPos),chatRoomTitle);
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void contactName_Click(object sender, EventArgs e)
        {

        }
    }



}
