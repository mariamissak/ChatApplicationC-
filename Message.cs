using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatApplication
{
    public class Message
    {
        // Message
        private static long counter = 0;
        private long messageId;
        public long MessageId { get { return messageId; } set { messageId = value; } }
        private long userId;
        public long UserId { get { return userId; } set { userId = value; } } //who wrote the message
        private string text;
        public string Text { get { return text; } set { text = value; } }
        private Status messageStatus;
        public Status MessageStatus { get { return messageStatus; } set { messageStatus = value; } }
        private long chatRoomId;
        // public static long Counter { get => counter; set => counter = value; }

        public Message(long userId, string text, long chatRoomId)
        {
            counter++;
            messageId = counter;
            this.userId = userId;
            this.text = text;
            this.chatRoomId = chatRoomId;
            messageStatus = new Status();
            MainForm.mainUser.ChatRoomsList.moveToTop(chatRoomId);

        }
        public Message(long userId, long messageId, string text, long chatRoomId)
        {
            this.userId = userId;
            this.messageId = messageId;
            this.text = text;
            this.chatRoomId = chatRoomId;
            messageStatus = new Status();
            MainForm.mainUser.ChatRoomsList.moveToTop(chatRoomId);

        }

    }
}
