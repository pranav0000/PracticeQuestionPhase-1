using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Number_Quess
    {
        static void Main(string[] args)
        {
            int i = 0, num, x, m=0, k=0 ;
            //  display numbers divisible by 2 and 20 both
            Console.WriteLine("Divided by 2 & 20: ");
            for ( i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 20 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

            //display even numbers from 15-25
            

            Console.WriteLine("Even Numbers :");
            for (i = 15; i <= 25; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            //  Program to generate factors of a given number

            
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();


            // Program to display even factors of given number
           
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0 && x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }


            // Program to display odd factors of a given number
            
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0 && x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }


            //Program to display count of factors

            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (k = 1; k <= num; k++)
            {
                if (num % k == 0)
                {
                    m = m + 1;

                }
            }
            Console.WriteLine($"No. of factors are :{m}");


            //program 16 - Program to display number of even factors

            m = 0; k=0;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (k = 1; k <= num; k++)
            {
                if (num % k == 0 && k % 2 == 0)
                {
                    m = m + 1;
                    Console.WriteLine(k);
                }
            }
            Console.WriteLine($"No. of even factors are :{m}");

            // program - 17 to find number of odd factors

            
            m = 0;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (k = 1; k <= num; k++)
            {
                if (num % k == 0 && k % 2 != 0)
                {
                    m = m + 1;
                    Console.WriteLine(k);
                }
            }
            Console.WriteLine($"No. of odd factors are :{m}");

            // display odd numbers from 2 to 9

            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (int n = 2; n < (9 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
    }
}
