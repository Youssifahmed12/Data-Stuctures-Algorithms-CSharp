using System;
using System.Collections.Generic;
using System.Linq;


class PriorityQueue
{
    private SortedDictionary<int, Queue<int>> MyQueue = new SortedDictionary<int, Queue<int>>();


    public void Enqueue(int value, int priority)
    {
        if (!MyQueue.ContainsKey(priority))
        {
            MyQueue[priority] = new Queue<int>();
        }
        MyQueue[priority].Enqueue(value);
    }


    public int? Dequeue()
    {
        if (MyQueue.Count == 0) return null;

        int highestPriority = MyQueue.Keys.Min();
        int value = MyQueue[highestPriority].Dequeue();

        if (MyQueue[highestPriority].Count == 0)
            MyQueue.Remove(highestPriority);

        return value;
    }
}


class Program
{
    static void Main()
    {
        PriorityQueue pq = new PriorityQueue();
        pq.Enqueue(10, 3);
        pq.Enqueue(5, 1);
        pq.Enqueue(20, 2);
        Console.WriteLine(pq.Dequeue()); // Output: 5
        Console.ReadKey();
    }
}