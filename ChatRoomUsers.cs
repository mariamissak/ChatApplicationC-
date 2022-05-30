using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class ChatRoomUsers : Form
    {
        ChatRoom chatRoom;
        public ChatRoomUsers(ChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
            InitializeComponent();
        }

        private void ChatRoomUsers_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < chatRoom.ChatRoomInfo.ListUsers.Count; i++)
            {
                listView1.Items.Add(chatRoom.ChatRoomInfo.ListUsers[i].FirstName + " " + chatRoom.ChatRoomInfo.ListUsers[i].LastName + " \n" + chatRoom.ChatRoomInfo.ListUsers[i].MobileNumber);
            }
        }

        private void add_particip_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
