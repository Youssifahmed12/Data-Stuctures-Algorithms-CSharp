using System;
using System.Collections.Generic;

class Program
{
    static Queue<int> RearrangeEvenOdd(Queue<int> queue)
    {
        Queue<int> evenQueue = new Queue<int>();
        Queue<int> oddQueue = new Queue<int>();


        while (queue.Count > 0)
        {
            int num = queue.Dequeue();
            if (num % 2 == 0)
            {
                evenQueue.Enqueue(num);
            }
            else
            {
                oddQueue.Enqueue(num);
            }
        }


        while (evenQueue.Count > 0)
        {
            queue.Enqueue(evenQueue.Dequeue());
        }


        while (oddQueue.Count > 0)
        {
            queue.Enqueue(oddQueue.Dequeue());
        }

        return queue;
    }


    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5,6 });
        Queue<int> rearrangedQueue = RearrangeEvenOdd(queue);
        Console.WriteLine(string.Join(", ", rearrangedQueue)); // Output: 2, 4, 1, 3, 5,6
        Console.ReadKey();
    }
}