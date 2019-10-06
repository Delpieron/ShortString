using System;

namespace ShortStirng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz text");
            string text = Console.ReadLine();
            if (text.Length >= 20)
                Console.WriteLine($"{text.Substring(0, 10)}...");
        }
    }
}
