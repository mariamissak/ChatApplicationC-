using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ChatApplication.Contacts
{
    public partial class ContactDiscriptor : UserControl
    {
        public ContactDiscriptor()
        {
            InitializeComponent();
        }

        private User _contact;
        private string _imgUrl;
        private string _fullName;
        private string _description;
        private string _phoneNumber;



        //profilePicture
        //contactName
        //bio
        //story button
        void requestImageFromUrl(string value)
        {
            Stream tempStream = null;
            HttpWebResponse imgResponse = null;
            try
            {
                HttpWebRequest imgRequest = (HttpWebRequest)HttpWebRequest.Create(value);
                imgRequest.AllowWriteStreamBuffering = true;
                imgResponse = (HttpWebResponse)imgRequest.GetResponse();
                tempStream = imgResponse.GetResponseStream();
                Bitmap avatarBitMap;
                //set Background image
                if (tempStream != null)
                {
                    avatarBitMap = new Bitmap(tempStream);
                    avatarBitMap = new Bitmap(avatarBitMap, profilePicture.Width, profilePicture.Height);

                    profilePicture.BackgroundImage = avatarBitMap;
                }
            }
            catch { }
            finally
            {
                if (tempStream != null)
                    tempStream.Close();
                if (imgResponse != null)
                {
                    imgResponse.Close();
                }
            }
        }

        public User Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        private void ContactDiscriptor_Load(object sender, EventArgs e)
        {
            _fullName = _contact.FirstName + " " + _contact.LastName;
            contactName.Text = _fullName;
            _imgUrl = _contact.UserDescription.getPhotoPath() + _contact.UserDescription.getPhotoName();
            requestImageFromUrl(_imgUrl);

            _phoneNumber = _contact.MobileNumber;
            _description = _contact.UserDescription.getAboutDescription();
            bio.Text = _description;
            mobileNumber.Text = _phoneNumber;
        }

        private void bio_Click(object sender, EventArgs e)
        {

        }

        private void contactName_Click(object sender, EventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        private void storyViewButton_Click(object sender, EventArgs e)
        {
            //move to storyViewform
        }
    }
}
