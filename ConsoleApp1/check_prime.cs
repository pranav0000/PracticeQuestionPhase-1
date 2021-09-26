using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class check_prime
    {
        static void Main(string[] args)
        {
            int num = 0, div = 2, flag =0;
            Console.WriteLine("Enter the number .. ");
            num = int.Parse(Console.ReadLine());

            while (div < num / 2)
            {
                if ((num % div) == 0)
                { Console.WriteLine( num + " is not a prime number ");div += 1; flag = 1; break; }        
            }

            if (flag == 0)
                { Console.WriteLine( num + " is a prime number "); }

        }
    }
}
