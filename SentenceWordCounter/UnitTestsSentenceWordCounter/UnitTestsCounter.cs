using Microsoft.VisualStudio.TestTools.UnitTesting;
using SentenceWordCounter;

namespace UnitTestsSentenceWordCounter
{
    [TestClass]
    public class UnitTestsCounter
    {
        [TestMethod]
        public void NewCounterShouldHaveCountOfOne()
        {
            var expectedCounterValue = 1;
            Counter newCounter = new Counter();

            Assert.AreEqual(expectedCounterValue, newCounter.CounterValue);
        }

        [TestMethod]
        public void ShouldIncrementCountCorrectly()
        {
            var expectedCounterValue = 2;
            Counter newCounter = new Counter();
            newCounter.IncrementCounter();

            Assert.AreEqual(expectedCounterValue, newCounter.CounterValue);
        }
    }
}
