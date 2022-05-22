using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ChatApplication
{
    public class ChatRoom
    {
		private static long  counter { get; set; }
		private long chatRoomId { get; set; }
		private string chatRoomType { get; set; } //one to one chat or group chat
		private DateTime lastDate { get; set; }
		private ChatRoomInfo chatRoomInfo { get; set; }
		private List<User> listOfUsers { get; set; } //2 in case of one to one chat and 2 or more in case of group chat

		public ChatRoom(string chatRoomType, List<User> listOfUsers)
		{
			counter++;
			chatRoomId = counter;
			this.chatRoomType = chatRoomType;
			this.listOfUsers = listOfUsers;
		}
		public void setLastDate(DateTime lastDate)
		{
			this.lastDate = lastDate;
		}

	}
}
