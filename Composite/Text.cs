namespace Composite
{
    public class Text : BookComponent
    {

        public string Content { get; }

        public override string ToString()
        {
            return Content;
        }

        internal override void Print(string prefix)
        {
            Console.WriteLine(prefix + Content);
        }

        public Text(string content)
        {
            Content = content;
        }

    }
}
