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

namespace ChatApplication
{
    public partial class StoryContact : UserControl
    {
        public StoryContact()
        {
            InitializeComponent();
        }


        #region Properties
        private User _sContact;
        private string _ScontactName;
        private string _timepublished;
        private Image _icon;


        [Category("Contacts Card")]
        public User SContact
        {
            get { return _sContact; }
            set { _sContact = value; datepublished.Text = value.UserStories.Back().PublishedStoryTime.ToString();
                profilePicture.Image = value.UserDescription.ProfilePicture;
                
                if (SContact == MainForm.mainUser)
                {
                    contactName.Text = "My Story";
                }
                else
                contactName.Text = value.FirstName + " " + _sContact.LastName;
            }
        }

        [Category("Contacts Card")]
        public string SContactName
        {
            get { return _ScontactName; }
            set { _ScontactName = value; contactName.Text=value; }
        }

        [Category("Contacts Card")]
        public string TimePublished
        {
            get { return _timepublished; }
            set {_timepublished= value; datepublished.Text = value; }
        }


        [Category("Contacts Card")]
        public Image Icon
        {
            get { return _icon; }
            set {_icon = value; profilePicture.Image = value; }
        }
        #endregion




       
        private void ContactItem_Load(object sender, EventArgs e)
        {
            //contactName.Text = _sContact.FirstName + " " + _sContact.LastName;
            //datepublished.Text=_sContact.UserStories.Back().PublishedStoryTime.ToString();
            //profilePicture.Image =_sContact.UserDescription.ProfilePicture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsStories pForm = (ContactsStories)ParentForm;
            pForm.showStories(_sContact);
            

        }

        private void datepublished_Click(object sender, EventArgs e)
        {

        }
    }
}
