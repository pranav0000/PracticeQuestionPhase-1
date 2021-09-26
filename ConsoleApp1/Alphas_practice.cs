using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Alphas_practice
    {
        void UpperCaseAlphabets()
        {
            for (int c = 65; c <= 90; ++c)
                Console.Write(" " + (char)c);
            Console.Write("\n");
        }

        void UpperCaseAlphabetsReverse()
        {
            for (int c = 90; c >= 65; c--)
                Console.Write(" " + (char)c);
            Console.Write("\n");
        }
        void LowerCaseAlphabets()
        {
            for (int c = 97; c <= 122; ++c)
                Console.Write(" " + (char)c);
            Console.Write("\n");
        }
        void LowerCaseAlphabetsReverse()
        {
            for (int c = 122; c >= 97; c--)
                Console.Write(" " + (char)c);
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            // Program to display capital letter alphabets (A-Z) (ASCII 65-90)
            Console.WriteLine("Uppercase Alphabets are as follows");
            Alphas_practice obj = new Alphas_practice();
            obj.UpperCaseAlphabets();

            //  To dispaly lower case alphabets
            Console.WriteLine("Lowercase Alphabets are as follows ");
            obj.LowerCaseAlphabets();

            // To display capital letters from Z-A
            Console.WriteLine("UpperCase letters in Reverse Order");
            obj.UpperCaseAlphabetsReverse();

            // Display capital letters from z-a
            Console.WriteLine("LowerCase letters in Reverse Order");
            obj.LowerCaseAlphabetsReverse();
        }




    }
}

