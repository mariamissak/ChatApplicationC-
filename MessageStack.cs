using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChatApplication
{
    public class MessageStack<T>
    {
        private int top;
        private int size;
        private Message[] arr;

        public MessageStack () {
            top = -1;
            size = 10;
            arr =  new Message[size];
        }

        public int Length()
        {
            return top+1;
        }

        public void Push(Message val)
        {
            if (top == size - 1)
                Expand();
            top++;
            arr[top] = val;
        }

        public void Pop()
        {
            Debug.Assert(!Empty());
            top--;
        }

        public Message Top()
        {
            Debug.Assert(!Empty());
            return arr[top];
        }

        public Boolean Empty()
        {
            return (top == -1);
        }

        public void Expand()
        {
            size += 5;
            Message[] tmp = new Message[size];
            for (int i = 0; i <= top; i++)
                tmp[i] = arr[i];

            arr = tmp;
        }


        public int LastSentIndex()
        {
            int temp = -1;
            for (int i = top ; i > -1; i--)
            {
                if (arr[i] != null && arr[i].UserId == MainForm.mainUser.UserId)
                {
                    temp = i;
                    break;

                }
            }
            
            return temp;
        }
       
        public long Undo(int index)
        {
            int temp = index;
            long mId = -1;

            if (temp != -1)
            {
                mId = arr[index].MessageId;
                for (int j = temp; j <= top; j++)
                {
                    if (j!=top)
                    {
                        arr[j] = arr[j + 1];
                    }
                    else Pop();
                }
                
            }
            

            return mId;
        }

        public Message[] ViewAll()
        {
            return arr;
        } 
    }
}
