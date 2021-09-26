using System;

namespace ConsoleApp1
{
    class check_armstrong_number
    {
        static void Main(string[] args)
        {
            int num = 0, rem = 0, sum = 0;
            Console.WriteLine("Enter the number .. ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i = i/10 )
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }
            if (sum == num)
            {
                Console.Write("Entered number is an Armstrong number.");
            }

            else
                Console.Write("Entered number is not an Armstrong number.");
        }
    }
}

