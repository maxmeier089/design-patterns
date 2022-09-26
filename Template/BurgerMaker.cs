namespace Template
{
    public abstract class BurgerMaker
    {
        public abstract string Name { get; }

        public void MakeBurger()
        {
            Console.WriteLine(Name);

            AddBun();

            AddPatty();

            AddToppings();

            Console.WriteLine();
        }

        public virtual void AddBun()
        {
            Console.WriteLine("Add regular bun");
        }

        public abstract void AddPatty();

        public abstract void AddToppings();


    }
}
