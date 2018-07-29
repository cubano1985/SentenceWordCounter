using System;
using System.Collections.Generic;

namespace SentenceWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh hey, I'm here to help you count your words better, so give me a sentence.");

            string sentence = Console.ReadLine();
            string sentencePreparedToCount = SentenceUseCase.PrepareSentence(sentence);

            Console.WriteLine();

            List<string> splitSentence = SentenceUseCase.SplitSentenceToWords(sentencePreparedToCount);
            Dictionary<string, Counter> countedWords = WordsUseCase.CountWords(splitSentence);

            PrintResults(sentence, countedWords);

            Console.ReadLine();
        }

        private static void PrintResults(string sentence, Dictionary<string, Counter> countedWords)
        {
            Console.WriteLine("Your sentence: " + sentence);
            Console.WriteLine("consists of:");

            foreach (var word in countedWords)
            {
                Console.WriteLine(word.Key + " - " + word.Value.CounterValue);
            }
        }
    }
}
