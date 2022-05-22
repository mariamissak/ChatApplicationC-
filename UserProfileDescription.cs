using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class UserProfileDescription
    {
        private long UserId { get; set; }
        private String PhotoPath { get; set; }
        private String PhotoName { get; set; }
        private String FileType { get; set; }
        private String AboutDescription { get; set; }
        private Boolean IsVisible { get; set; } //Boolean to make your information visible to anyone or only your contacts
                                                //The user can only see the photoand profile description for the users that
                                                // already have him as a contact if the visibility is false otherwise he can see any
                                                //of his contacts photoand profile description./

        public UserProfileDescription(long userId, string photoPath, string photoName, string fileType, string aboutDescription, bool isVisible)
        {
            this.UserId = userId;
            this.PhotoPath = photoPath;
            this.PhotoName = photoName;
            this.FileType = fileType;
            this.AboutDescription = aboutDescription;
            this.IsVisible = isVisible;
        }

        public UserProfileDescription(long userId, string aboutDescription, bool isVisible)
        {
            this.UserId = userId;
            this.PhotoPath = "";
            this.PhotoName = "";
            this.FileType = "";
            this.AboutDescription = aboutDescription;
            this.IsVisible = isVisible;
        }

    }
}
