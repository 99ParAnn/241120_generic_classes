using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120_generikus_osztalyok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Enqueue("a", 1);
			queue.Enqueue("b", 2);
			queue.Enqueue("c", 13);
			queue.Enqueue("d", 1);

			Console.Write(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            
		}
	}
}
