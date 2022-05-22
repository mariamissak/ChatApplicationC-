using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Application
{
    internal class Story
    {
        private long userId { get; set; }
        private DateTime publishedStoryTime { get; set; }
        // Story photo (This attribute is optional)
        private string photoPath { get; set; }
        private string storyText { get; set; }
        //Each user story should be disappeared to all his contacts after 24 hours from the time it was published.
        public Story(long userId, string storyText)
        {
            this.userId = userId;
            this.storyText = storyText;
        }
        public Story(long userId, string photoPath, string storyText)
        {
            publishedStoryTime = DateTime.Now;

            this.userId = userId;
            this.storyText = storyText;
            this.photoPath = photoPath;
        }
    }
}
