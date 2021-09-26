using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _12_8_num_params
    {
        static void Main(string[] args)
            
        {
            int sum = 0;
            void fun(params  int[] list)
            {
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
                    Console.WriteLine(sum);

            }

            }

            fun(1, 2, 3, 4);
        }
    }
}
