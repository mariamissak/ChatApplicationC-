using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChatApplication
{

    public class Node
    {
        public Node next;
        public ChatRoom value;

        public Node(ChatRoom val)
        {
            value = val;
            next = null;
        }

    }
    public class ChatRoomsList
    {
        private int count;
        public Node head;
        private Node tail;



        public ChatRoomsList()
        {
            head = tail = null;
            count = 0;
        }


        public int Length()
        {
            return count;
        }



        public void Append(ChatRoom val)
        {
            Node newNode = new Node(val);
            if (head == null)
                head = tail = newNode;
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            count++;
        }


        public ChatRoom At(int pos)
        {
            Debug.Assert(pos >= 0 && pos < count);
            Node tmp = head;
            for (int i = 0; i < pos; i++)
                tmp = tmp.next;
            return tmp.value;
        }

        public void InsertAt(int pos, ChatRoom val)
        {
            Debug.Assert(pos >= 0 && pos < count);
            Node tmp = head;
            Node newNode = new Node(val);
            if (pos == 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                for (int i = 0; i < pos - 1; i++)
                    tmp = tmp.next;

                newNode.next = tmp.next;
                tmp.next = newNode;
            }
            count++;
        }

        public void DeleteAt(int pos)
        {
            Debug.Assert(pos >= 0 && pos < count);
            Node tmp = head;
            if (pos == 0)
            {
                head = head.next;
            }
            else
            {
                for (int i = 0; i < pos - 1; i++)
                    tmp = tmp.next;
                Node del = tmp.next;
                tmp.next = del.next;
                if (pos == count - 1)
                    tail = tmp;
            }
            count--;
        }

        public void moveToTop(long chatRoomId)
        {
            Node tmp = head;
            ChatRoom x = null;
            for (int i = 0; i < count; i++)
            {
                if (chatRoomId == tmp.value.chatRoomId)
                {
                    x = tmp.value;
                    DeleteAt(i);
                    break;
                }

                tmp = tmp.next;
            }
            InsertAt(0, x);
        }
        public int findPrivateChatroom(long userId)
        {
            ChatRoomInfo tempinfo;
            for (int i = 0; i < Length(); i++)
            {
                tempinfo = At(i).ChatRoomInfo;
                if (tempinfo.ListUsers.Count == 2)
                {
                    foreach (User user in tempinfo.ListUsers)
                    {
                        if (user.UserId == userId)
                        {
                            return i;
                        }
                    }
                }
            }

            return -1;
        }

    }

}
   


   



