using System;
using System.IO;


namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* String path = @"C:\Users\Teju Reddy\Desktop\vamshi.txt";


             String copypath = @"D:\ExampleNew.txt";

             File.Copy(path, copypath);

             Console.ReadKey();*/
            Fileio fileio = new Fileio();
            fileio.io();
        }
    }
}