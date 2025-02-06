using System;
using System.Collections.Generic;


namespace isQueuePalindrome
{
  
    internal class Program
    {
        static bool isQueuePalindrome(Queue<int> queue)
        {
            if (queue.Count == 0 || queue.Count == 1)
            {
                return false;
            }

            Stack<int> CheckingStack = new Stack<int>();
            foreach (int i in queue)
            {
                CheckingStack.Push(i);
            }
            while (CheckingStack.Count > 0)
            {
                if (CheckingStack.Pop() != queue.Dequeue())
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(1);

            Console.WriteLine(isQueuePalindrome(queue));
            Console.ReadKey();
        }
    }
}
