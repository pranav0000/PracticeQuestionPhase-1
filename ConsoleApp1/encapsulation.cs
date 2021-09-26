using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class nums
    {
        // data member
        private int num1;

        public void setter(int n)
            { this.num1 = n; }

        public int getter()
           { return num1; }

    }

    class encapsulation
    {
        static void Main(string[] args)
        {
            nums obj = new nums();
            obj.setter(10);
            Console.WriteLine(obj.getter());
        }
    }

}
