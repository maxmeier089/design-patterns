namespace Composite
{
    public abstract class BookComponent
    {

        public void Print()
        {
            Print("");
            Console.WriteLine();
        }

        internal abstract void Print(string prefix);

    }

}
