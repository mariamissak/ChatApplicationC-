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
        private long userId;
        public long UserId { get { return userId; } set { userId = value; } }
        private DateTime publishedStoryTime;
        public DateTime PublishedStoryTime { get { return publishedStoryTime; } set { publishedStoryTime = value; } }
        private Image photo;
        public Image Photo { get { return photo; } set { photo = value; } }
        private string storyText;
        public string StoryText { get { return storyText; } set { storyText=value; } }
        //Each user story should be disappeared to all his contacts after 24 hours from the time it was published.
        public Story(long userId, string storyText)
        {
            this.userId = userId;
            this.storyText = storyText;
        }
        public Story(long userId, Image photo, string storyText)
        {
            publishedStoryTime = DateTime.Now;

            this.userId = userId;
            this.storyText = storyText;
            this.photo = photo;
        }
    }
}