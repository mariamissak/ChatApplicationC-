using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ChatApplication
{
    public partial class ContactsStories : Form
    {
        public ContactsStories()
        {
            InitializeComponent();
        }
        private void populateItems()
        {
            //////////////GET CONTACT FROM MAIN USER CONTACTS
            User currentuser = MainForm.mainUser;
            //string server = "localhost";
            ////change the following according to your local database
            //string database = "chat";
            //string username = "root";
            //string password = "root";
            //string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            //MySqlConnection conn = new MySqlConnection(constring);
            //conn.Open();
            //MySqlCommand cmd = new MySqlCommand("select firstname,lastname,max(timepublished) from users u, contacts c,stories s where c.userid=@userid and c.phonenumber=u.phonenumber and u.userid=s.userid group by u.userid;", conn);
            ////missing retrieve image from database
            //cmd.Parameters.AddWithValue("@userid", currentuser);//mainform.currentuser.id
            //MySqlDataReader dr = cmd.ExecuteReader();

            if (!currentuser.UserStories.Empty())
            {
                storyContact1.SContact = currentuser;
                //storyContact1.TimePublished =currentuser.UserStories.Back().PublishedStoryTime.ToString();

                //storyContact1.SContactName = currentuser.FirstName + " " + currentuser.LastName;
            }
            int i = 0;
            StoryContact[] storyContacts = new StoryContact[20];
            foreach (User contact in currentuser.Contacts.Values)
            {
                if (!contact.UserStories.Empty())
                {
                    storyContacts[i] = new StoryContact();
                    //storyContacts[i].Icon -> retrieve image from database
                    storyContacts[i].SContact = contact;
                    //storyContacts[i].SContactName = contact.FirstName + " " + contact.LastName;
                    //storyContacts[i].TimePublished = contact.UserStories.Back().PublishedStoryTime.ToString();
                    //add read image


                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                        flowLayoutPanel1.Controls.Add(storyContacts[i]);
                    i++;
                }
            }
            //dr.Close();
            //conn.Close();
            
        }

        private void ContactsStories_Load(object sender, EventArgs e)
        {
            populateItems();

        }

        private void storyContact1_Load(object sender, EventArgs e)
        {
            storyContact1.SContactName = "My Story";
        }
        public void showStories(User sContact)
        {
            //send user clicked on to story form to show their stories
            
            if (sContact != null )
            {
                StoryForm s = new StoryForm();
                s.user1 = sContact;
                s.Location = new Point((panel1.Width - s.Width) / 2, (panel1.Height - s.Height) / 2);

                panel1.Controls.Add(s);
                panel3.SendToBack();
                pictureBox1.SendToBack();
                s.BringToFront();
            }
            
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter="jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                    
                    
                }

            }
            catch(Exception)
            {
                MessageBox.Show("An Error ocurred", "Error", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            
            string server = "localhost";
            //change the following according to your local database
            string database = "chat";
            string username = "root";
            string password = "root";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            Story newstory = new Story(MainForm.mainUser.UserId, pictureBox1.Image, textBoxg1.Texts);
            MainForm.mainUser.UserStories.Enqueue(newstory);


            string insertquery = "INSERT INTO stories(storyID,userID,timepublished,photo,storytext) VALUES(@storyId,@userId,sysdate(),@img,@storyText);";
            MySqlCommand cmd = new MySqlCommand(insertquery, conn);
            cmd.Parameters.Add("@storyId", MySqlDbType.Int32);
            cmd.Parameters.Add("@userId", MySqlDbType.Int32);
            cmd.Parameters.Add("@img", MySqlDbType.Blob);
            cmd.Parameters.Add("@storyText", MySqlDbType.VarChar);
            

            cmd.Parameters["@img"].Value = img;
            cmd.Parameters["@storyText"].Value = textBoxg1.Texts;
            cmd.Parameters["@storyId"].Value = newstory.StoryId;
            cmd.Parameters["@userId"].Value = MainForm.mainUser.UserId;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Story added");
            }
        }
    }
}

