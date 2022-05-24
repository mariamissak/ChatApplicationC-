using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
namespace ChatApplication
{
	public class User
	{
		private static long counter = 0;
		private long userId { get; set; }
		private string mobileNumber { get; set; }
		private string password { get; set; }
		private string firstName { get; set; }
		private string lastName { get; set; }

		private StoriesQueue<Story> userStories;
		private UserProfileDescription userDescription;
		private Dictionary<string, User> contacts; //pointer to user or userId
		private ChatRoomsList chatRoomsList;

		public User(string mobileNumber, string password, string firstName, string lastName, Image ProfilePicture, string aboutDescription, bool isVisible)
		{
			counter++;
			userId = counter;
			this.mobileNumber = mobileNumber;
			this.password = password;
			this.firstName = firstName;
			this.lastName = lastName;

			userDescription = new UserProfileDescription(this.userId, ProfilePicture, aboutDescription, isVisible);
		}

		public User(long userId, string mobileNumber, string password, string firstName, string lastName, Image ProfilePicture, string aboutDescription, bool isVisible)
		{
			this.userId = userId;
			this.mobileNumber = mobileNumber;
			this.password = password;
			this.firstName = firstName;
			this.lastName = lastName;

			userDescription = new UserProfileDescription(this.userId,ProfilePicture, aboutDescription, isVisible);
		}
		public void setChatRoomList(ChatRoomsList chatRoomsList)
        {
			this.chatRoomsList = chatRoomsList;
        }
		public ChatRoomsList getChatRoomsList()
		{
			return chatRoomsList;
		}
		public long getUserId()
		{
			return userId;
		}
		public string getMobileNumber()
		{
			return mobileNumber;
		}
		public string getPassword()
		{
			return password;
		}
		public string getFirstName()
		{
			return firstName;
		}
		public string getLastName()
		{
			return lastName;
		}
		public StoriesQueue<Story> getStoriesQueue()
		{
			return userStories;
		}
		public UserProfileDescription GetUserProfileDescription()
		{
			return userDescription;
		}
		public Dictionary<string, User> getContactsList()
		{
			return contacts;
		} 
		
	}
}
