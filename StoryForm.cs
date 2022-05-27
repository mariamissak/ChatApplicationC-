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
using MySql.Data.Types;


namespace ChatApplication
{
/* foreach(var contact in user1.contacts.values)
{
 sql select * from stories where userid=:userid
  * add parameter userid= contact.userid
  * while (dr.read){
  * create new story object() with the output parameters that we retrieved
  * add story object to contact.stories queue
  * }
 
}
*/
public partial class StoryForm :UserControl
    {
        public User user1;
        StoriesQueue<Story> tempStories= new StoriesQueue<Story>();

        public StoryForm()
        {
            

            InitializeComponent();
        }

        private void LoadNextImg()
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (user1.UserStories.Empty())
            {
                this.Visible = false;
                timer1.Stop();
                timer2.Stop();
                user1.UserStories = tempStories;
            }
            else
            {
                panel3.Width = 0;

                label1.Text = user1.UserStories.Front().StoryText;
                pictureBox1.Image= user1.UserStories.Front().Photo;
                tempStories.Enqueue(user1.UserStories.Front());

                user1.UserStories.Dequeue();
            }
           
        }

        private void StoryForm_Load(object sender, EventArgs e)
        {
            BringToFront();
            if (!this.DesignMode)
            {

                timer1.Start();
                timer2.Start();
                panel3.Width = 0;
                panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
                panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
                panel2.Parent = pictureBox1;
                panel1.Parent = pictureBox1;
                //panel3.Parent = pictureBox1;
                //string constring = "datasource=localhost;port=3306;username=root;password=root";
                //string server = "localhost";
                ////change the following according to your local database
                //string database = "chat";
                //string username = "root";
                //string password = "root";
                //string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
                //MySqlConnection conn = new MySqlConnection(constring);
                //conn.Open();
                //MySqlCommand cmd = new MySqlCommand("select * from stories where userid=@userid", conn);
                //cmd.Parameters.AddWithValue("@userid", user1.UserId);
                //MySqlDataReader dr = cmd.ExecuteReader();
                //int imageNumber = 1;
                //while (dr.Read())
                //{
                //    //label1.Text = dr["storytext"].ToString();
                //    byte[] img = (byte[])dr["photo"];
                //    MemoryStream ms = new MemoryStream(img);
                //    //pictureBox1.Image = Image.FromStream(ms);
                //    //string x = dr["photopath"].ToString();


                //    Story mystory = new Story(1, Image.FromStream(ms), dr["storytext"].ToString());
                //    mystory.PublishedStoryTime = Convert.ToDateTime(dr["timepublished"].ToString());
                //    imageNumber++;
                //    user1.UserStories.Enqueue(mystory);



                //}
                //dr.Close();
                //conn.Close();
               
                label1.Text = user1.UserStories.Front().StoryText;
                pictureBox1.Image = user1.UserStories.Front().Photo;
                tempStories.Enqueue(user1.UserStories.Front());
                user1.UserStories.Dequeue();
                

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;
            if (panel3.Width >= 345)
            {
                //panel3.Width = 0;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
