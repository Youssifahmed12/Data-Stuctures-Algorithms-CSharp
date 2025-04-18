using System;
using System.Collections.Generic;



class Program
{
    static int EvalPostfix(string postfix)
    {
        Stack<int> stack = new Stack<int>();
        foreach (char c in postfix)
        {
            if (char.IsDigit(c))
            {
                stack.Push(c - '0');
            }
            else
            {
                int b = stack.Pop();
                int a = stack.Pop();
                switch (c)
                {
                    case '+': stack.Push(a + b); break;
                    case '-': stack.Push(a - b); break;
                    case '*': stack.Push(a * b); break;
                    case '/': stack.Push(a / b); break;
                }
            }

        }
        return stack.Pop();
    }
    static void Main()
    {

        Console.WriteLine(EvalPostfix("231*+9-"));
        Console.ReadKey();
    }
}