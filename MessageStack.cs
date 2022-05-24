using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ChatApplication
{
    public class MessageStack<T>
    {
        private int count { get; set; }
        private int size { get; set; }
        private T[] arr;

        public MessageStack()
        {
            size = 10;
            count = 0;
            arr = new T[size];
        }

        public int Length()
        {
            return count;
        }

        public void Push(T val)
        {
            if (count == size)
                Expand();
            arr[count] = val;
            count++;
        }

        public void Pop()
        {
            Debug.Assert(!Empty());
            count--;
        }

        public T Top()
        {
            Debug.Assert(!Empty());
            return arr[count - 1];
        }

        public Boolean Empty()
        {
            return (size == 0);
        }

        public void Expand()
        {
            size += 5;
            T[] tmp = new T[size];
            for (int i = 0; i < count; i++)
                tmp[i] = arr[i];

            arr = tmp;
        }

        public void ViewAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }

        public void Undo()
        {
            for (int i = count - 1; i < Length(); i++)
            {

            }
        }


    }
}
