using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    internal class Message
    {
		private static long counter = 0;
		private long  messageId { get; set; }
		private long  userId { get; set; } //who wrote the message
		private string text { get; set; }
		private Status messageStatus { get; set; }

		public Message(long userId, string text)
		{
			counter++;
			messageId = counter;
			this.userId = userId;
			this.text = text;
			messageStatus = new Status();
		}
		public string getMessage()
		{
			return text;
		}

	}
}
