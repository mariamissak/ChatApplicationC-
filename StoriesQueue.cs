using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChatApplication
{
	public class StoriesQueue<T>
	{
		private T[] arr;
		private int count;
		private int size;
		private int front;
		private int back;

		public StoriesQueue()
		{
			size = 10;
			count = 0;
			front = back = -1;
			arr = new T[size];
		}

		public int Length()
		{
			return count;
		}

		public void Enqueue(T val)
		{
            if (Full())
            {
                Expand();
            }

			if (count == 0)
				front = 0;

			back = (back + 1) % size;
			arr[back] = val;
			count++;
		}

		public void Dequeue()
		{
			Debug.Assert(!Empty());
			if (count == 1)
				front = back = -1;
			else
				front = (front + 1) % size;
			count--;
		}

		public T Back()
		{
			Debug.Assert(!Empty());
			return arr[back];
		}

		public T Front()
		{
			Debug.Assert(!Empty());
			return arr[front];
		}

		public bool Full()
		{
			return (count == size);
		}

		public bool Empty()
		{
			return (count == 0);
		}

		public void Expand()
		{
			T[] tmpArr = new T[size + 10];

			int c = count;
			int i = front;
			int ind = 0;

            while (count != 0)
            {
                count--;
                tmpArr[ind] = arr[i];

                i++; i %= size;
                ind++;
            }

            front = 0;
			back = size;
			size += 10;
		}
	}
}

