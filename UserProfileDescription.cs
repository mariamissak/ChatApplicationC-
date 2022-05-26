using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
namespace ChatApplication
{
    public class UserProfileDescription
    {
        private long userId;

        public long UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private Image profilePicture;

        public Image ProfilePicture
        {
            get { return profilePicture; }
            set { profilePicture = value; }
        }
        private String aboutDescription;

        public String AboutDescription
        {
            get { return aboutDescription; }
            set { aboutDescription = value; }
        }
        private Boolean isVisible;

        public Boolean IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }
        
        public UserProfileDescription(long userId, Image profilePicture, string aboutDescription, bool isVisible)
        {
            this.UserId = userId;
            this.profilePicture = profilePicture;
            this.AboutDescription = aboutDescription;
            this.IsVisible = isVisible;
        }

        public UserProfileDescription(long userId, string aboutDescription, bool isVisible)
        {
            this.UserId = userId;
            this.profilePicture = null;
            this.AboutDescription = aboutDescription;
            this.IsVisible = isVisible;
        }
       
        
        

    }
}
