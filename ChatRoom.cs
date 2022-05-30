using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChatApplication
{
    public class ChatRoom
    {
        MySqlConnection con;

        private long _chatRoomId;
        public long chatRoomId 
        { 
            get { return _chatRoomId; } 
            set { _chatRoomId = value; } 
        }

        private Boolean isPrivate; //one to one chat or group chat
        public Boolean IsPrivate 
        { 
            get { return isPrivate; } 
            set { isPrivate = value; } 
        }

        private DateTime lastDate;
        public DateTime LastDate 
        { 
            get { return lastDate; } 
            set { lastDate = value; } 
        }

        private ChatRoomInfo chatRoomInfo;
        public ChatRoomInfo ChatRoomInfo 
        { 
            get { return chatRoomInfo; } 
            set { chatRoomInfo = value; } 
        }

        private MessageStack<Message> messagestack;
        public MessageStack<Message> MessageStack 
        { 
            get { return messagestack; } 
            set { messagestack = value; } 
        }
                
        public ChatRoom(Boolean isPrivate, List<User> listOfUsers)
        {

            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(chatroomId) from chatrooms;";

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                try
                {
                    _chatRoomId = Convert.ToInt64(dr[0]) + 1;
                }
                catch(Exception)
                {
                    _chatRoomId = 1;
                }
            }
             
          
            this.isPrivate = isPrivate;
            chatRoomInfo = new ChatRoomInfo(listOfUsers, _chatRoomId);
            dr.Close();
            con.Dispose();
        }

        public ChatRoom(long _chatRoomId, Boolean isPrivate, List<User> listOfUsers, DateTime lastDate)
        {

            this._chatRoomId = _chatRoomId;
            this.isPrivate = isPrivate;
            this.lastDate = lastDate;
            chatRoomInfo = new ChatRoomInfo(listOfUsers, chatRoomId);
            messagestack = new MessageStack<Message>();
        }
    }
}