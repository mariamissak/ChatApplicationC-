using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class Status
    {
        //STATUS
        private DateTime dateTime;
        public DateTime DateTime { get { return dateTime; } set { dateTime = value; } } //https://www.geeksforgeeks.org/time-h-header-file-in-c-with-examples/
        private bool isSeen;
        public bool IsSeen { get { return isSeen; } set { isSeen = value; } } //which is either seen or unseen (when the message is sent it is initially unseen until the another user opens the chat room, In case of group chat it is seen if only all the other users opened the chat room

        public Status()
        {
            dateTime = DateTime.Now;
            isSeen = false;
        }

        //public DateTime getDateTime()
        //{
        //    return dateTime;
        //}
        //public void setDateTime(DateTime dateTime)
        //{
        //    this.dateTime = dateTime;
        //}
    }
}
