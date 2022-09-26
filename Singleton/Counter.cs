namespace Singleton
{
    public class Counter
    {

        private int counter = 0;

        public void Count()
        {
            counter++;

            Console.WriteLine("Counter has been called " + counter + " times.");
        }

        public static Counter Instance { get; private set; }
        
        private Counter()
        {
        }

        static Counter()
        {
            Instance = new();
        }

    }
}