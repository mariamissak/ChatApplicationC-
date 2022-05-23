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

        private void ContactList_Load(object sender, EventArgs e)
        {
            Dictionary<string, User> myDict = new Dictionary<string, User>();
            User user = new User("1", "2", "omar", "4", "ccd91d6b0cdc49189602b4fef80a8c8c.jpg", "https://i.pinimg.com/236x/cc/d9/1d/", "7", "8", true);
            myDict.Add("1", user);
            myDict.Add("2", user);
            myDict.Add("3", user);
            myDict.Add("4", user);
            myDict.Add("5", user);
            myDict.Add("6", user);

            populateList(myDict);

            Console.WriteLine("loaded dictionary");
        }

        private void populateList(Dictionary<string, User> contacts)
        {
            ContactItem[] contactItems = new ContactItem[contacts.Count];

            int i = 0;
            foreach (var contact in contacts)
            {
                contactItems[i] = new ContactItem();
                contactItems[i].Contact = contact.Value;
                //if (flowLayoutPanel1.Controls.Count > 0) 
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                //{
                    flowLayoutPanel1.Controls.Add(contactItems[i]);
                //}
                i++;
            }
        }

       
    }
}
