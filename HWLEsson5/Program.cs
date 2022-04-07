using System;
using System.IO;

namespace HWLEsson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\binary.dat";
            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    Console.Write("Количество чисел: ");
                    int n = int.Parse(Console.ReadLine());
                    double[] num = new double[n];
                    Console.WriteLine("Введите числа: ");
                    for (int i = 0; i < n; i++)
                    {
                        double b = double.Parse(Console.ReadLine());
                        bw.Write(b);
                        num[i] = b;
                    }
                    Console.Write("Все элементы: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(num[i] + " ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
