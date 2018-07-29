using System;
using System.Collections.Generic;
using System.Linq;

namespace SentenceWordCounter
{
    internal static class SentenceUseCase
    {
        internal static List<string> SplitSentenceToWords(string sentencePreparedToCount)
        {
            char[] splitCriteria = { ' ' };
            List<string> words = sentencePreparedToCount.Split(splitCriteria, StringSplitOptions.RemoveEmptyEntries).ToList();
            return words;
        }

        internal static string PrepareSentence(string sentence)
        {
            var lowCaseSentence = sentence.ToLower();
            return lowCaseSentence;
        }
    }
}
