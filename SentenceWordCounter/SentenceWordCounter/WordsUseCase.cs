using System.Collections.Generic;

namespace SentenceWordCounter
{
    internal static class WordsUseCase
    {
        static char[] signsToRemove = { '.', ',', '?', '!', '-', ' ', '*' };

        internal static Dictionary<string, Counter> CountWords(List<string> words)
        {
            List<string> trimmedWords = TrimWords(words);

            var countedWords = new Dictionary<string, Counter>();

            foreach (string work in trimmedWords)
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

        private static List<string> TrimWords(List<string> words)
        {
            var trimmedWords = new List<string>();

            foreach (string word in words)
            {
                string trimmedWord = word.Trim(signsToRemove);

                if (!string.IsNullOrEmpty(trimmedWord))
                {
                    trimmedWords.Add(trimmedWord);
                }
            }

            return trimmedWords;
        }

        
    }
}
