using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatApplication
{
    public class Message
    {
		private static long counter = 0;
		private long  messageId { get; set; }
		private long  userId { get; set; } //who wrote the message
		private string text { get; set; }
		private Status messageStatus { get; set; }
		private long chatRoomId { get; set; }
       // public static long Counter { get => counter; set => counter = value; }

        public Message(long userId, string text, long chatRoomId)
		{
			counter++;
			messageId = counter;
			this.userId = userId;
			this.text = text;
			this.chatRoomId = chatRoomId;
			messageStatus = new Status();
			MainForm.mainUser.getChatRoomsList().moveToTop(chatRoomId);

		}
		public string getMessage()
		{
			return text;
		}

	}
}
