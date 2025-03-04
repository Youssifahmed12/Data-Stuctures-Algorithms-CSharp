using System;
using System.Collections.Generic;


class Program
{
    static Queue<int> RearrangeQueueAlternately(Queue<int> queue)
    {
        Queue<int> FirstHalf = new Queue<int>();
        Stack<int> SecondHalf = new Stack<int>();

        int HalfCount = queue.Count / 2;

        for (int i = 0; i < HalfCount; i++)
            FirstHalf.Enqueue(queue.Dequeue());

        for (int i = 0; i < HalfCount; i++)
            SecondHalf.Push(queue.Dequeue());

        while (FirstHalf.Count > 0 && SecondHalf.Count > 0) 
        {
            queue.Enqueue(FirstHalf.Dequeue());
            queue.Enqueue(SecondHalf.Pop());
        }        
        
        while (FirstHalf.Count > 0)        
            queue.Enqueue(FirstHalf.Dequeue());
        
        while (SecondHalf.Count > 0)
            queue.Enqueue(SecondHalf.Pop());
        
        return queue;
    }

    static void Main()
    {
        Queue<int> q = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
        q =RearrangeQueueAlternately(q);
        Console.WriteLine(string.Join(", ",q));
        Console.ReadKey();
    }
}
