using System;
using System.Globalization;

namespace StringsAndDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModifyStrings testString = new ModifyStrings("Irina");
            testString.Greet();
            testString.SayGoodbye();
            testString.YellGreeting();
            testString.TrimStrings("           Hey     ");
            string[] testArray = { "apple", "almost", "August", "bear", "tree" };
            testString.WordsStartingWithA(testArray);
            string[] testArray2 = testString.SplitWords("Hello, how are you");
            Console.WriteLine(testString.JoinArray(testArray2));
            testString.CreateSentance("tired", "horse", "yells");
            testString.EndStringsGame();
        }
    }
}
