using System;

namespace SwitchEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, whats your favorite subject?");
            var Respond = Console.ReadLine();

            switch (Respond)
            {
                case "Math":
                    Console.WriteLine("Thats whats up whats the square root of 748");
                    break;
                case "English":
                    Console.WriteLine("Have ever read Charlottes Web?");
                    break;
                case "Science":
                    Console.WriteLine("Dont cut no frogs up.");
                    break;
                case "Social Studies":
                    Console.WriteLine("Thats my favorite to.");
                    break;
                default:
                    Console.WriteLine("Is this a real subject");
                    break;
            }
        }
    }
}
