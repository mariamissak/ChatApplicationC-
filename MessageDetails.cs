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
    public partial class MessageDetails : Form
    {
        private ChatRoom c;
        public MessageDetails()
        {
            InitializeComponent();
        }
        public MessageDetails(ChatRoom ch)
        {
            c = ch;
            InitializeComponent();
        }

        private void message_time_label_Click(object sender, EventArgs e)
        {
            message_time_label.Text=MainForm.mainUser.ChatRoomsList.At(c.chatRoomId)
        }
    }
}
