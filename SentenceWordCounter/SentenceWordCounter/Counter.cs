namespace SentenceWordCounter
{
    public class Counter
    {
        public int CounterValue { get; private set; }

        public Counter()
        {
            CounterValue = 1;
        }

        public void IncrementCounter()
        {
            CounterValue++;
        }
    }
}
