using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatRoomInfo
    {
        private long UserId { get; set; }
        private long ChatRoomId { get; set; }
        private DateTime LastSeen { get; set; }

        public ChatRoomInfo(long userId, long chatRoomId, DateTime lastSeen)
        {
            this.UserId = userId;
            this.ChatRoomId = chatRoomId;
            this.LastSeen = lastSeen;
        }
    }
}
