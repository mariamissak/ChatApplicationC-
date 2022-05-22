using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Application
{
    internal class ChatRoomsList<T>
    {
       private  int count;
       private Node head;
       private Node tail;
    }
    class Node
    {
       public  Node next;
       public Chatr value;
       
       public Node()
       {
            value = 0;
            next = null;
       }
        

    }
}
