using System;
using System.Collections.Generic;

internal class Program
{
    static Queue<int> InterleaveQueue(Queue<int> queue) 
    {
        int halfSize = queue.Count / 2;
        Queue<int> firstHalf = new Queue<int>();
 
        for (int i = 0;i < halfSize;i++)
        {
            firstHalf.Enqueue(queue.Dequeue());
        }
        for (int i = 0; i < halfSize; i++)
        {
            queue.Enqueue(firstHalf.Dequeue());
            queue.Enqueue(queue.Dequeue());
        }
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6 });
         Queue<int> InterLeavedQueue = InterleaveQueue(queue);
        Console.WriteLine(string.Join(", ",InterLeavedQueue));
        Console.ReadKey();
    }
}

