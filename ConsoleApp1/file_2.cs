/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class file_2
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\file_handling\file1.txt";
             = null;
            try
            {
                StreamReader sr = new StreamReader(fpath);
                string fileContent = sr.ReadToEnd();
                Console.WriteLine(fileContent);
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine($"{fpath} not exist...");
            }
           
        }
    }
}
