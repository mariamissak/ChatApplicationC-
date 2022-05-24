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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        #region Properties
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

    }



}
