namespace SentenceWordCounter
{
    public class Counter
    {
        private int counter;

        public Counter()
        {
            counter = 1;
        }

        public void IncrementCounter()
        {
            counter++;
        }

        public int GetCount()
        {
            return counter;
        }
    }
}
