using Microsoft.VisualStudio.TestTools.UnitTesting;
using SentenceWordCounter;
using System.Collections.Generic;

namespace UnitTestsSentenceWordCounter
{
    [TestClass]
    public class UnitTestsSentenceUseCase
    {
        [TestMethod]
        public void SplitsSentenceByEmptySpaces()
        {
            var sentence = "Three words sentence.";
            var expectedWordCount = 3;

            List<string> resultSplit = SentenceUseCase.SplitSentenceToWords(sentence);

            Assert.AreEqual(expectedWordCount, resultSplit.Count);
            Assert.AreEqual("Three", resultSplit[0]);
            Assert.AreEqual("words", resultSplit[1]);
            Assert.AreEqual("sentence.", resultSplit[2]);
        }

        [TestMethod]
        public void ChangesWordCaseToLowe()
        {
            var sentence = "UPPER case SENTENCE";

            string resultSentence = SentenceUseCase.PrepareSentence(sentence);

            Assert.AreNotEqual(sentence, resultSentence, false);
        }
    }
}
