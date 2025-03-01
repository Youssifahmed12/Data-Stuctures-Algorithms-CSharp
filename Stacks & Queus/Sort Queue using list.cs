using System;
using System.Collections.Generic;

internal class Program
{
    static Queue<int> SortQueue(Queue<int> queue)
    {
        List<int> list = new List<int>(queue);
        list.Sort();
        return new Queue<int>(list);
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new int[] { 1, 8, 7, 5, 2, 3, 4, 9 });
        Queue<int> sorted = SortQueue(queue);
        Console.WriteLine(string.Join(", ",sorted));
        Console.ReadKey();
    }
}

