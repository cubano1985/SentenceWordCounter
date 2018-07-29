using System;
using System.Collections.Generic;
using System.Linq;

namespace SentenceWordCounter
{
    class Program
    {
        static char[] signsToRemove = { '.', ',', '?', '!', '-', ' ', '*' };

        static void Main(string[] args)
        {
            Console.WriteLine("Oh hey, I'm here to help you count your words better, so give me a sentence.");

            string sentence = Console.ReadLine();
            string sentencePreparedToCount = PrepareSentence(sentence);

            Console.WriteLine();
            List<string> words = SplitSentenceToWords(sentencePreparedToCount);
            List<string> trimmedWords = TrimWords(words);
            Dictionary<string, Counter> countedWords = CountWords(trimmedWords);

            PrintResults(sentence, countedWords);

            Console.ReadLine();
        }

        private static List<string> SplitSentenceToWords(string sentencePreparedToCount)
        {
            char[] splitCriteria = { ' ' };
            List<string> words = sentencePreparedToCount.Split(splitCriteria, StringSplitOptions.RemoveEmptyEntries).ToList();
            return words;
        }

        private static string PrepareSentence(string sentence)
        {
            var trimmedSentence = sentence.Trim(signsToRemove);
            var lowCaseSentence = sentence.ToLower();
            return lowCaseSentence;
        }

        private static void PrintResults(string sentence, Dictionary<string, Counter> countedWords)
        {
            Console.WriteLine("Your sentence: " + sentence);
            Console.WriteLine("consists of:");

            foreach (var word in countedWords)
            {
                Console.WriteLine(word.Key + " : " + word.Value.GetCount() + " times;");
            }
        }

        private static List<string> TrimWords(List<string> words)
        {
            var trimmedWords = new List<string>();

            foreach (var word in words)
            {
                string trimmedWord = word.Trim(signsToRemove);

                if (!string.IsNullOrEmpty(trimmedWord))
                {
                    trimmedWords.Add(trimmedWord);
                }
            }

            return trimmedWords;
        }

        private static Dictionary<string, Counter> CountWords(List<string> words)
        {
            var countedWords = new Dictionary<string, Counter>();

            foreach (var work in words)
            {
                if (countedWords.ContainsKey(work))
                {
                    countedWords.TryGetValue(work, out Counter counter);
                    counter.IncrementCounter();
                }
                else
                {
                    countedWords.Add(work, new Counter());
                }
            }

            return countedWords;
        }
    }
}
