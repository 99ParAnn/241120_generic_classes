using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120_generikus_osztalyok
{
	//TBA: sorted list so we can search logarythmically?
	internal class PriorityQueue<T>
	{
		private List<KeyValuePair<T,int>> mainQueue;

		public PriorityQueue()
		{
			this.mainQueue = new List<KeyValuePair<T, int>>();
		}

		public void Enqueue(T item, int priority)
		{
			this.mainQueue.Add(new KeyValuePair<T, int>(item,priority));
		}

		public T Dequeue() 
		{
			if (mainQueue.Count == 0)
			{
				throw new Exception("Tried to dequeue from an empty queue");
			}
			else
			{
				KeyValuePair<T, int> min = mainQueue[0];
				foreach (var item in mainQueue)
				{
					if (min.Value > item.Value)
					{
						min = item;
					}
				}
				mainQueue.Remove(min);
				return min.Key;
			}
		}

		public T Peek() 
		{
			if (mainQueue.Count == 0)
			{
				throw new Exception("Tried to peek at empty queue");
				
			}
			else
			{
				KeyValuePair<T, int> min= mainQueue[0];
				foreach (var item in mainQueue)
				{
					if (min.Value > item.Value)
					{
						min	= item; 
					}
				}
				return min.Key;
			}


		}
	}
}
