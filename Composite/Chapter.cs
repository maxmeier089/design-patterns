namespace Composite
{
    public class Chapter : BookComponent
    {

        public string Title { get; }

        public List<BookComponent> Children { get; }

        internal override void Print(string prefix)
        {
            Console.WriteLine(prefix + Title);

            foreach (BookComponent component in Children)
            {
                component.Print(prefix + "    ");
            }
        }

        public Chapter(string title, List<BookComponent> children)
        {
            Title = title;
            Children = children;
        }
    }
}
