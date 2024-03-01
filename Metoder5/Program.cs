using System;

namespace Metoder2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[2];
            string[] text = new string[2];
            Console.WriteLine("1. Skriv in text");
            Console.WriteLine("2. Skriv in tal");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Skriv in en mening");
                    text[i] = (Console.ReadLine());
                }
                Console.WriteLine(störst(text[0], text[1], 1));
            }
            else if (answer == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Skriv in ett tal");
                    text[i] = (Console.ReadLine());
                }
                Console.WriteLine(störst(text[0], text[1], 2));
            }
        }

        static string störst(string tal1, string tal2, int option)
        {
            if (option == 1)
            {
                if (tal2.Length > tal1.Length)
                {
                    return tal2;
                }
                else
                {
                    return tal1;
                }
            }
            else if (option == 2)
            {
                if (int.Parse(tal2) > int.Parse(tal1))
                {
                    return tal2;
                }
                else
                {
                    return tal1;
                }
            }
            return "Inkorrekt värde";
        }
    }
}