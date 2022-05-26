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
		private string chatRoomType { get; set; } //one to one chat or group chat
		private DateTime lastDate { get; set; }
		public ChatRoomInfo chatRoomInfo { get; set; }
		private MessageStack<Message> messagestack;
		public ChatRoom(string chatRoomType , List<User> listOfUsers )
		{
			counter++;
			chatRoomId = counter;
			this.chatRoomType = chatRoomType;
			chatRoomInfo = new ChatRoomInfo(listOfUsers, chatRoomId, lastDate);
		}
		public void setLastDate(DateTime lastDate)
		{
			this.lastDate = lastDate;
		}
		public DateTime getLastDate()
        {
			return lastDate;
        }
		public MessageStack<Message> GetMessageStack()
        {
			return messagestack;
        }

	}
}
