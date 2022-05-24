using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatRoomInfo
    {
        private long ChatRoomId { get; set; }
        private DateTime LastSeen { get; set; }

        public List<User> listOfUsers { get; set; } //2 in case of one to one chat and 2 or more in case of group chat

        public ChatRoomInfo(List<User> listOfUsers, long chatRoomId, DateTime lastSeen)
        {
            this.listOfUsers = listOfUsers;
            this.ChatRoomId = chatRoomId;
            this.LastSeen = lastSeen;
        }
    }
}
