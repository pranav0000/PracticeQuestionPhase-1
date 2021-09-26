using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _5_and_7
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter the number . .");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
                {
                if (i % 5 == 0 && i % 7 == 0)
                    { Console.WriteLine($"{i} is divisible by 7 and 5"); }
                }

        }
    }
}
