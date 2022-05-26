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
		public long chatRoomId { get { return chatRoomId; } set {; } }
		private Boolean isPrivate; //one to one chat or group chat
		private DateTime lastDate { get; set; }
		public ChatRoomInfo chatRoomInfo { get; set; }
		private MessageStack<Message> messagestack;
		public ChatRoom(Boolean isPrivate, List<User> listOfUsers )
		{
			counter++;
			chatRoomId = counter;
			this.isPrivate = isPrivate;
			chatRoomInfo = new ChatRoomInfo(listOfUsers, chatRoomId, lastDate);
		}
		public ChatRoom(long chatRoomId, Boolean isPrivate, List<User> listOfUsers)
		{
			
			this.chatRoomId = chatRoomId;
			this.isPrivate = isPrivate;
			chatRoomInfo = new ChatRoomInfo(listOfUsers, chatRoomId, lastDate);
		}
		public void setLastDate(DateTime lastDate)
		{
			this.lastDate = lastDate;
		}

		public MessageStack<Message> GetMessageStack()
        {
			return messagestack;
        }

	}
}
