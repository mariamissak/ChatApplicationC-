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

        /*Image cropToCircle(Bitmap src)
        {
            PointF imgCenter = new PointF(profilePicture.Location.X, profilePicture.Location.Y);
            float radius = profilePicture.Width / 2;
            Image img = new Bitmap(profilePicture.Image.Width, profilePicture.Image.Height, src.PixelFormat);
            using (Graphics g = Graphics.FromImage(img)) {
                Color clipingFrame = Color.FromArgb(0, 0, 0, 0);
                RectangleF r = new RectangleF(imgCenter.X - radius, imgCenter.Y - radius,
                                                radius * 2, radius * 2);

                // enables smoothing of the edge of the circle (less pixelated)
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // fills background color
                using (Brush br = new SolidBrush(clipingFrame))
                {
                    g.FillRectangle(br, 0, 0, img.Width, img.Height);
                }

                // adds the new ellipse & draws the image again 
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(src,0, 0);
                return img;
            }
        }*/

        /*void requestImageFromUrl( string value)
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
        }*/
        #endregion

        private void contactName_Click(object sender, EventArgs e)
        {
            
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {    

        }

        private void ContactItem_Load(object sender, EventArgs e)
        {
            contactName.Text = _contact.getFirstName();
            lastSeen.Text = "last seen yesterday";
            Img = _contact.GetUserProfileDescription().getProfilePicture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactList pForm = (ContactList)ParentForm;
            pForm.populateContactInfo(_contact);
        }
    }
}
