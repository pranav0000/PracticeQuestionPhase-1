using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class lambda_exp
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<string, int> len = x => x.Length;

            Console.WriteLine(len("pranav"));
            Console.WriteLine(square(10));
        }
    }
}
