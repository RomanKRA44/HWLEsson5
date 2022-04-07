using System;
using System.IO;

namespace HWLEsson5
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"D:\startup.txt", DateTime.Now.ToString());
        }
    }
}
