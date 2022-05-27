using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatRoom
    {
        private static long counter;
        public long chatRoomId { get { return chatRoomId; } set { chatRoomId = value; } }
        private Boolean isPrivate; //one to one chat or group chat
        public Boolean IsPrivate { get { return isPrivate; } set { isPrivate = value; } }
        private DateTime lastDate;
        public DateTime LastDate { get { return lastDate; } set { lastDate = value; } }
        private ChatRoomInfo chatRoomInfo;
        public ChatRoomInfo ChatRoomInfo { get { return chatRoomInfo; } set { chatRoomInfo = value; } }
        private MessageStack<Message> messagestack;
        public MessageStack<Message> MessageStack { get { return messagestack; } set { messagestack = value; } }
        public ChatRoom(Boolean isPrivate, List<User> listOfUsers)
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

    }
}
