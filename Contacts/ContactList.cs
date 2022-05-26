using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.Contacts
{
    public partial class ContactList : Form
    {
        public ContactList()
        {
            InitializeComponent();
        }

        private User selectedUser;

        private void ContactList_Load(object sender, EventArgs e)
        {
            Dictionary<string, User> myDict = new Dictionary<string, User>();
            /*User user = new User("1", "2", "omar", "1", "ccd91d6b0cdc49189602b4fef80a8c8c.jpg", "https://i.pinimg.com/236x/cc/d9/1d/", "7", "8", true);
            User user2 = new User("1", "2", "omar", "2", "Ware_Amanda_The+Cold+Wind+of+Death_RGB+copy.jpeg", "https://images.squarespace-cdn.com/content/v1/5029c68d84ae261e07fb86ec/1634494946122-K5547RVNTBHBDCA0P2D9/", "7", "8", true);
            User user3 = new User("1", "2", "omar", "3", "Maynard_Alyssa_LadyMacbeth_websq.jpg", "https://images.squarespace-cdn.com/content/v1/5029c68d84ae261e07fb86ec/1635459831746-ZHG21QXD60YUKKJWR14R/", "7", "8", true);
            User user4 = new User("1", "2", "omar", "4", "ShinYeonMoon_JeoSeung-Saja_Websize.jpeg", "https://images.squarespace-cdn.com/content/v1/5029c68d84ae261e07fb86ec/1635459941394-ARGV455ZG29GHGJHZI41/", "7", "8", true);
            myDict.Add("1", user);
            myDict.Add("2", user2);
            myDict.Add("3", user3);
            myDict.Add("4", user4);
            myDict.Add("5", user);
            myDict.Add("6", user);*/
            myDict = MainForm.mainUser.getContactsList();
            populateList(myDict);

            populateContactInfo(selectedUser);
        }

        public void populateContactInfo(User cont)
        {
            if (cont != null)
            {
                flowLayoutPanel2.Controls.Clear();
                ContactDiscriptor desc = new ContactDiscriptor();
                desc.Contact = cont;
                flowLayoutPanel2.Controls.Add(desc);
            }
        }

        private void populateList(Dictionary<string, User> contacts)
        {
            ContactItem[] contactItems = new ContactItem[contacts.Count];

            int i = 0;
            foreach (var contact in contacts)
            {
                contactItems[i] = new ContactItem();
                contactItems[i].Contact = contact.Value;
                flowLayoutPanel1.Controls.Add(contactItems[i]);
                i++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ViewChatRooms cForm = new ViewChatRooms();
            cForm.Show();
            this.Hide();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddNewContactForm ancf = new AddNewContactForm();
            ancf.Show();
        }
    }
}
