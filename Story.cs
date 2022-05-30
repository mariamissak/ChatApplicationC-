using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace ChatApplication
{
    public class Story
    {
        MySqlConnection con;

        private long userId;
        public long UserId 
        { 
            get { return userId; } 
            set { userId = value; } 
        }

        private long storyId;
        public long StoryId
        { 
            get { return storyId; } 
            set { storyId = value; } 
        }

        private DateTime publishedStoryTime;
        public DateTime PublishedStoryTime 
        { 
            get { return publishedStoryTime; } 
            set { publishedStoryTime = value; } 
        }

        private Image photo;
        public Image Photo 
        { 
            get { return photo; } 
            set { photo = value; } 
        }

        private string storyText;
        public string StoryText 
        { 
            get { return storyText; } 
            set { storyText=value; } 
        }

        //Each user story should be disappeared to all his contacts after 24 hours from the time it was published.
        public Story(long userId, string storyText)
        {
            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(storyid) from stories;";

            MySqlDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read()) storyId = Convert.ToInt64(dr[0]) + 1;
            else storyId = 1;

            this.userId = userId;
            this.storyText = storyText;
            dr.Close();
            con.Dispose();
        }
        public Story(long userId, Image photo, string storyText)
        {
            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(storyid) from stories;";

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) storyId = Convert.ToInt64(dr[0]) + 1;
            else storyId = 1;

            publishedStoryTime = DateTime.Now;
       
            this.userId = userId;
            this.storyText = storyText;
            this.photo = photo;
            dr.Close();
            con.Dispose();
        }
    }
}