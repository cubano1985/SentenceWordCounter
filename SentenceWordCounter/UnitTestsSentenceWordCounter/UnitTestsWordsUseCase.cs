using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SentenceWordCounter;

namespace UnitTestsSentenceWordCounter
{
    [TestClass]
    public class UnitTestsWordsUseCase
    {
        [TestMethod]
        public void DoesNotCountMeaninglessSigns()
        {
            var expectedCountOfWords = 2;

            List<string> words = new List<string>
            {
                "correct",
                "?",
                "word",
                "."
            };

            Dictionary<string, Counter> result = WordsUseCase.CountWords(words);

            Assert.AreEqual(expectedCountOfWords, result.Count);
            Assert.IsTrue(result.ContainsKey("correct"));
            Assert.IsTrue(result.ContainsKey("word"));
        }

        [TestMethod]
        public void CountsTheSameWordsCorrectly()
        {
            var expectedCount = 2;

            List<string> words = new List<string>
            {
                "first-",
                "first.",
                "second?",
                ",second"
            };

            Dictionary<string, Counter> result = WordsUseCase.CountWords(words);

            result.TryGetValue("first", out Counter firstCounter);
            result.TryGetValue("second", out Counter secondCounter);

            Assert.IsNotNull(firstCounter, "Counter for a word was not returned.");
            Assert.IsNotNull(secondCounter, "Counter for a word was not returned.");
            Assert.AreEqual(expectedCount, firstCounter.GetCount(), "Count was not right.");
            Assert.AreEqual(expectedCount, secondCounter.GetCount(), "Count was not right.");
        }
    }
}
