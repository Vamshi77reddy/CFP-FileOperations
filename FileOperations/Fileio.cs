using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileOperations
{
    internal class Fileio
    {
        public void io()
        {
            FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate,
           FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
