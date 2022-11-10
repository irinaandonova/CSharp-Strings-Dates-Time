using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace StringsAndDates
{
    public class OptionalAssignment
    {
        public static void CountMistakes(string tagString)
        {
            int openingCount = 0;
            int closingCount = 0;
            string openingSequence = "<app>";
            string closingSequence = "</app>";
            int index = 0;
            /*
            while(index != -1)
            {
                index = tagString.IndexOf(openingSequence);
                Console.WriteLine(index);
                if(index != -1)
                {
                    tagString = tagString.Remove(index, index + 4);
                    openingCount++;
                }
            }
            do
            {
                index = tagString.IndexOf(closingSequence);
                if (index != -1)
                {
                    tagString = tagString.Remove(index, index + 6);
                    closingCount++;
                }
            } while(index != -1);
            Console.WriteLine(Math.Abs(openingCount - closingCount));
            */
        }
         
    }
}
