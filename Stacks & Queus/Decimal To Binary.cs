using System;
using System.Collections.Generic;


namespace ConvertDecimalToBinary
{

    internal class Program
    {
        static string ConvertDecimalToBinary(int DecimalNum)
        {
            if (DecimalNum == 0) return "0";
            if (DecimalNum == 1) return "1";

            Stack<int> BinaryNumsStack = new Stack<int>();
            while (DecimalNum > 0)
            {
                BinaryNumsStack.Push(DecimalNum % 2);
                DecimalNum = DecimalNum / 2;
            }

            return string.Join("",BinaryNumsStack);

        }
        static void Main(string[] args)
        {
                       
            Console.WriteLine(ConvertDecimalToBinary(16));
            Console.ReadKey();
        }
    }
}
