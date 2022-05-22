using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Chat_Application
{
	internal class StoriesQueue<T>
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
		public int length()
		{
			return count;
		}
		public void enqueue(T val)
		{
			Debug.Assert(!full());
			if (count == 0)
				front = 0;
			back = (back + 1) % size;
			arr[back] = val;
			count++;
		}
		public void dequeue()
		{
			Debug.Assert(!empty());
			if (count == 1)
				front = back = -1;
			else
				front = (front + 1) % size;
			count--;
		}
		public T Front()
		{
			Debug.Assert(!empty());
			return arr[front];
		}
		public bool full()
		{
			return (count == size);
		}
		public bool empty()
		{
			return (count == 0);
		}

		public void viewAll()
		{
			for (int str = 0; str < count; str++)
			{
				//show story for 3 seconds
			}
		}

		public void expand()
		{
			T[] tmpArr = new T[size + 10];

			int c = count;
			int i = front;
			int ind = 0;

			while (count--)
			{
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

