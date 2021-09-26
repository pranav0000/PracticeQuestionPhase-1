using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class produce_factors
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter the number ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    { Console.WriteLine($"{i} is the factor of {num}"); }
            }
        }
    }
}
