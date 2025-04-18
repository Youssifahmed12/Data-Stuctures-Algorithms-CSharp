using System;
using System.Collections.Generic;


class Program
{
    static bool IsPalindrome(string input)
    {
        Stack<char> stack = new Stack<char>();


        for (int i = 0; i < input.Length/2; i++)
        {
            stack.Push(input[i]);
        }
        //to handle odd lengthed strings

        for (int i = (int)(Math.Ceiling((float)input.Length/2)); i < input.Length;i++)
        {
            char top = stack.Pop();
            if (!(input[i] == top))
            {
                return false;
            }
        }

        return stack.Count == 0; // Stack should be empty if Palindrome
    }
    static void Main()
    {
        string input = "ABCBA";
        Console.WriteLine($"Is \"{input}\" balanced? {IsPalindrome(input)}");

        Console.ReadKey();
    }
}