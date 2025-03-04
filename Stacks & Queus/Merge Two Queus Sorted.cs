using System;
using System.Collections.Generic;

internal class Program
{
    static Queue<int> MergeTwoQueuesSorted(Queue<int> queue1, Queue<int> queue2)
    {
        Queue<int> result = new Queue<int>();
        while (queue1.Count > 0 && queue2.Count > 0)
        {
            if (queue1.Peek() <= queue2.Peek())
                result.Enqueue(queue1.Dequeue());
            else
                result.Enqueue(queue2.Dequeue());
        }

        while (queue1.Count > 0)
            result.Enqueue(queue1.Dequeue());

        while (queue2.Count > 0)
            result.Enqueue(queue2.Dequeue());

        return result;
    }
    static void Main(string[] args)
    {
        Queue<int> queue1 = new Queue<int>(new int[] { 1, 3, 5 });
        Queue<int> queue2 = new Queue<int>(new int[] { 2, 4, 6 });
        Queue<int> MergedSortedQueue = MergeTwoQueuesSorted(queue1, queue2);
        Console.WriteLine(string.Join(", ", MergedSortedQueue));
        Console.ReadKey();
    }
}