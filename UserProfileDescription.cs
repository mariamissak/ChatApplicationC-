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
        private long UserId { get; set; }
        private Image profilePicture;
        private String AboutDescription { get; set; }
        private Boolean IsVisible { get; set; } //Boolean to make your information visible to anyone or only your contacts
                                                //The user can only see the photoand profile description for the users that
                                                // already have him as a contact if the visibility is false otherwise he can see any
                                                //of his contacts photoand profile description./

        
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
       
        
        public string getAboutDescription()
        {
            return AboutDescription;
        }
        public bool getIsVisible()
        {
            return IsVisible;
        }
        public Image getProfilePicture()
        {
            return profilePicture;
        }

    }
}
