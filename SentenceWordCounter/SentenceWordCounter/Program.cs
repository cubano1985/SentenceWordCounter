using System;
using System.Collections.Generic;
using System.Linq;

namespace SentenceWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh hey, I'm here to help you count your words better, so give me a sentence.");
            string sentence = Console.ReadLine();
            Console.WriteLine();

            sentence.Replace(',', ' ');
            sentence.Replace('.', ' ');

            var lowCaseSentence = sentence.ToLower();

            char[] splitCriteria = { ' ' };
            List<string> words = lowCaseSentence.Split(splitCriteria, StringSplitOptions.RemoveEmptyEntries).ToList();

            var groupedWords = words.GroupBy(w => w);

            Console.WriteLine("Sentence: " + sentence);
            Console.WriteLine("Consists of:");

            foreach (var group in groupedWords)
            {
                Console.WriteLine(group.Key + " : " + group.Count() + " times;");
            }

            Console.ReadLine();
        }
    }
}
