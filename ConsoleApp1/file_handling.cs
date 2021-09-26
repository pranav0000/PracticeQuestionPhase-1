using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class file_handling
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\11036288\Documents\Visual Studio 2019\file1.txt";
            StreamWriter fname = new StreamWriter(path);

            fname.WriteLine("Hello World");
            Console.WriteLine("file created ");

            fname.Close();
        }
    }
}


/*
 IO stands for Input and Output
.NET provided an API containing built in classes to handle a files,  namespace is System.IO
File Handling:    This is the feature used to handle files like
    Write data, read data, delete file, etc.,
To create Object:
StreamWriter obj = new StreamWrite("filename");
Note: The above system will create a new file, overwrite if file already exist
StreamWriter obj = new StreamWrite("filename",true);
By providing true as second parameter, the data will into the content
 */