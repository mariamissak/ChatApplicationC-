using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ChatApplication
{
	public class User
    {
		private static long  counter = 0;
		private long  userId { get; set; }
		private string mobileNumber;
		private string password { get; set; }

		private string firstName;

		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

		public string FirstName 
		{ 
			get { return firstName; } 
			set { firstName = value; } 
		}

		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private ChatRoomInfo chatRoomInfo; //not in constructor bcz idk
		private StoriesQueue<Story> userStories;

		private UserProfileDescription userDescription;
		public UserProfileDescription UserDescription
		{
			get { return userDescription; }
			set { userDescription = value; }
		}

		public StoriesQueue<Story> UserStories
        {
			get { return userStories; }
			set { userStories = value; }
        }

		private Dictionary<string, User> contacts; //pointer to user or userId
													//priority_queue< tm, vector< pair< tm, ChatRoom*>>>  chatrooms; //pointer to chatrooms

		public User(string mobileNumber, string password, string firstName, string lastName, string photoName, string photoPath, string fileType, string aboutDescription, bool isVisible)
		{
			counter++;
			userId = counter;
			this.mobileNumber = mobileNumber;
			this.password = password;
			this.firstName = firstName;
			this.lastName = lastName;

			userDescription = new UserProfileDescription(this.userId, photoPath, photoName, fileType, aboutDescription, isVisible);
		}
	}
}
