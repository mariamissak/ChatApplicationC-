//STORY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChatApplication
{
    public class Story
    {
        static int counter = 0;
        private long userId;
        private long storyId;
        public long UserId { get { return userId; } set { userId = value; } }
        public long StoryId{ get { return storyId; } set { storyId = value; } }
        private DateTime publishedStoryTime;
        public DateTime PublishedStoryTime { get { return publishedStoryTime; } set { publishedStoryTime = value; } }
        private Image photo;
        public Image Photo { get { return photo; } set { photo = value; } }
        private string storyText;
        public string StoryText { get { return storyText; } set { storyText=value; } }
        //Each user story should be disappeared to all his contacts after 24 hours from the time it was published.
        public Story(long userId, string storyText)
        {
            counter++;
            storyId = counter;
            this.userId = userId;
            this.storyText = storyText;
        }
        public Story(long userId, Image photo, string storyText)
        {
            publishedStoryTime = DateTime.Now;
            counter++;
            storyId = counter;
            this.userId = userId;
            this.storyText = storyText;
            this.photo = photo;
        }
    }
}