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
        MySqlConnection con;

        private long chatRoomId;
        public long ChatRoomId 
        { 
            get { return chatRoomId; } 
            set { chatRoomId = value; } 
        }

        private Dictionary<long , DateTime> lastSeen;
        public Dictionary<long, DateTime> LastSeen 
        { 
            get { return lastSeen; } 
            set { lastSeen = value; } 
        }

        private List<User> listOfUsers;
        public List<User> ListUsers 
        { 
            get { return listOfUsers; } 
            set { listOfUsers = value; } 
        }

        public ChatRoomInfo(List<User> listOfUsers, long chatRoomId)
        {
            this.listOfUsers = listOfUsers;
            this.chatRoomId = chatRoomId;
            this.lastSeen = new Dictionary<long, DateTime>();
            for (int i = 0; i < listOfUsers.Count(); i ++)
            {
                lastSeen.Add(listOfUsers[i].UserId, DateTime.Now);
            }
        }

        public void updateLastSeen(long userId)
        {
            lastSeen[userId] = DateTime.Now;

            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update chatroomusers set lastSeen = @lastSeen where userid = @uid and chatroomid = @chid;";
            cmd.Parameters.AddWithValue("@lastSeen" , lastSeen[userId]);
            cmd.Parameters.AddWithValue("@uid", userId);
            cmd.Parameters.AddWithValue("@chid", chatRoomId);
            cmd.ExecuteNonQuery();

            con.Dispose();
        }
    }
}
