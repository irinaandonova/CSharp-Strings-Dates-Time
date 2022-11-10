using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsAndDates
{
    public class ModifyStrings
    {
        private string Name;
        private string Greeting = "Hello";
        private string Yell;
        private DateTime StartingTime;
        private DateTime EndingTime;

        public ModifyStrings(string name)
        {
            Name = name;
            StartingTime = DateTime.UtcNow;
        }
        public void Greet()
        {
            Greeting = Greeting + " " + Name;
            Console.WriteLine(Greeting);
        }
        public void SayGoodbye()
        {
            string goodbuy = Greeting.Replace("Hello", "Goodbye");
            Console.WriteLine(goodbuy); 
        }
        public void YellGreeting()
        {
            Console.WriteLine(Greeting.ToUpper());
        }
        public string TrimStrings(string text)
        {
            return text.Trim(' ');
        }
        public string[] SplitWords(string text)
        {
            return text.Split(' ');
        }
        public string JoinArray(string[] stringArray)
        {
            return string.Join(' ', stringArray);
        }
        public void WordsStartingWithA(string[] wordArray)
        {
            string wordsStartingWithA = string.Join(", ", wordArray.Where(x => x.StartsWith("a")));
            if (wordsStartingWithA.Length == 0)
                Console.WriteLine("There are no words that start with a");
            else
                Console.WriteLine(wordsStartingWithA);
        }
        public void CreateSentance(string adjective,string noun, string verb)
        {
            string firstLetter = adjective.Substring(adjective[0]);
            string sentance;
            adjective = adjective.Remove(0, 1);
            adjective = string.Concat(firstLetter, adjective);
            sentance = string.Format(adjective, noun, verb, '.');
            Console.WriteLine(sentance);
        }
        public void EndStringsGame()
        {
            EndingTime = DateTime.UtcNow;
            Console.WriteLine(EndingTime);
        }
    }
}
