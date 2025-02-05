using System;
using System.Collections.Generic;


namespace Printer
{

    class Printer
    {
        Queue<string> PrinterQueue = new Queue<string>();
        public Printer()
        {

        }
        public Printer(string doc)
        {
            PrinterQueue.Enqueue(doc);
        }
        public void Print()
        {
            Console.WriteLine(PrinterQueue.Dequeue());
        }
        public void AddDocument(string doc)
        {
            PrinterQueue.Enqueue(doc);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer("Document 1");
            printer.AddDocument("Document 2");
            printer.AddDocument("Document 3");
            printer.Print();
            printer.Print();
            printer.Print();

            Console.ReadKey();
        }
    }
}
