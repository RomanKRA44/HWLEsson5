using System;
using System.IO;

namespace HWLEsson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, way;
            Console.WriteLine("Вводите текст: ");
            text = Console.ReadLine();
            Console.WriteLine("Введите путь и имя для сохранения (в формате D:\text.txt:)");
            way = Console.ReadLine();
            File.WriteAllText(way, text);
            Console.WriteLine("Успешное сохранение");
            Console.ReadKey();
        }
    }
}
