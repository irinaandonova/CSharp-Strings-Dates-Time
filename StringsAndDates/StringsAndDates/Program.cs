using System;

namespace StringsAndDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello, everyone";
            string farewell = greeting.Replace("Hello", "Goodbuy");
            string[] animals = { "cat", "dog", "rabbit", "parrot" };
            Console.WriteLine(string.Join("\n", animals));
            string names = "John, Melissa, Karen, Toby";
            string [] splitNames = names.Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string name in splitNames)
            {                
                Console.WriteLine($"{name}");
            }
        }
    }
}
