using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChatApplication
{
    public class ChatRoomInfo
    {
        private long chatRoomId;
        public long ChatRoomId { get { return chatRoomId; } set { chatRoomId = value; } }
        private DateTime lastSeen;
        public DateTime LastSeen { get { return lastSeen; } set { lastSeen = value; } }

        private List<User> listOfUsers;
        public List<User> ListUsers { get { return listOfUsers; } set { listOfUsers = value; } }
        //2 in case of one to one chat and 2 or more in case of group chat

        public ChatRoomInfo(List<User> listOfUsers, long chatRoomId, DateTime lastSeen)
        {
            this.listOfUsers = listOfUsers;
            this.chatRoomId = chatRoomId;
            this.lastSeen = lastSeen;
        }
    }
}
