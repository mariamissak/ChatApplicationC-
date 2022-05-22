using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatRoomsList<T>
    {
       private  int count;
       private Node head;
       private Node tail;
    }
    public class Node
    {
        public  Node next;
        public int value;
        public Node()
        {
            value = 0;
            next = null;
        }
        

    }
}
