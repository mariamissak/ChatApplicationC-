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
    public partial class ViewChatRooms : Form
    {
        public ViewChatRooms()
        {
            InitializeComponent();
        }
        private void populateItems()
        {
            //ListItem[] listItems = new ListItem[MainForm.mainUser.getChatRoomsList().Length()];
            ListItem[] listItems = new ListItem[5];
            //Node tmp = MainForm.mainUser.getChatRoomsList().head;
            for (int i=0;i< listItems.Length;i++)
            {

                string parts="";
                listItems[i] = new ListItem();
                //for (int j = 0; j < tmp.value.chatRoomInfo.listOfUsers.Count();j++)
                //{
                //    if(MainForm.mainUser.getUserId()!= tmp.value.chatRoomInfo.listOfUsers[j].getUserId())
                //    parts = tmp.value.chatRoomInfo.listOfUsers[j].getFirstName() + ", ";
                //}
                //listItems[i].ChatRoomTitle = parts;
                //listItems[i].LastMessage = tmp.value.GetMessageStack().Top().getMessage();
                listItems[i].ChatRoomTitle = "hello";
                listItems[i].LastMessage = "mymessage";
                //tmp = tmp.next;

                if(panel2.Controls.Count>0)
                {
                    panel2.Controls.Clear();
                }
                else
                panel2.Controls.Add(listItems[i]);

            }
        }

        private void ViewChatRooms_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
