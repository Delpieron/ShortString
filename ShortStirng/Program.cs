using System;

namespace ShortStirng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz text");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if(i>=20)
                {
                    Console.WriteLine($"{text.Substring(0,10)}...");
                    break;
                }

            }
        }
    }
}
