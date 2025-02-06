using System;
using System.Collections.Generic;


namespace ReverseQueue
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Stack<int> ReversingStack = new Stack<int>();
            while (queue.Count > 0)
            {
                ReversingStack.Push(queue.Dequeue());
            }
            while (ReversingStack.Count > 0)
            {
                queue.Enqueue(ReversingStack.Pop()); 
            }
            Console.WriteLine(string.Join(", ", queue));
            Console.ReadKey();
        }
    }
}
