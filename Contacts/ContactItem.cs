using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;

using ChatApplication.Contacts;

namespace ChatApplication.Contacts
{
    public partial class ContactItem : UserControl
    {
        public ContactItem()
        {
            InitializeComponent();
        }

        #region Properties
        private User _contact;
        private Image _img;
        private string _name;
        private string _lastSeen;

        public User Contact 
        {
            get { return _contact; }
            set { _contact = value; }
        }

        [Category("Contacts Card")]
        public string Name
        {
            get { return _name; }
            set { _name = value; contactName.Text = value; }
        }

        [Category("Contacts Card")]
        public string LastSeen
        {
            get { return _lastSeen; }
            set { _lastSeen = value; lastSeen.Text = value; }
        }

        [Category("Contacts Card")]
        public Image Img
        {
            get { return _img; }
            set {
                _img = value;

               // requestImageFromUrl(value);
            }
        }

        #endregion

        private void contactName_Click(object sender, EventArgs e)
        {
            
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {    

        }

        private void ContactItem_Load(object sender, EventArgs e)
        {
            contactName.Text = _contact.FirstName;
            lastSeen.Text = "last seen yesterday";
            Img = _contact.UserDescription.ProfilePicture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactList pForm = (ContactList)ParentForm;
            pForm.populateContactInfo(_contact);
        }
    }
}
