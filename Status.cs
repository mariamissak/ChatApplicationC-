using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class Status
    {
        private DateTime dateTime;
        public DateTime DateTime 
        { 
            get { return dateTime; } 
            set { dateTime = value; } 
        }

        //when the message is sent it is initially unseen until the other user opens the chat room,
        //In case of group chat it is seen if only all the other users opened the chat room
        private bool isSeen;
        public bool IsSeen 
        { 
            get { return isSeen; } 
            set { isSeen = value; } 
        } 

        public Status()
        {
            dateTime = DateTime.Now;
            isSeen = false;
        }

        public Status(DateTime date, bool isSeen)
        {
            dateTime = date;
            this.isSeen = isSeen;
        }
    }
}
