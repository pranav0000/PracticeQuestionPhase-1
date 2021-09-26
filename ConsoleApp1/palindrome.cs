using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class palindrome
    {
        static void Main(string[] args)
        {
            int reverse = 0, temp = 0;
            Console.WriteLine("Enter the number .");

            // num = int.Parse(Console.ReadLine()); can also be used for typecasting
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (temp > 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }

            if (num == reverse)
            {
                Console.WriteLine($"{num} is a palindrome ");
            }

            else
            {
                Console.WriteLine($"{num} is a not palindrome ");
            }
        }
            

            
    }
}

