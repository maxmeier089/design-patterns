namespace Template
{
    public class CheeseburgerMaker : BurgerMaker
    {

        public override string Name => "Cheeseburger";

        public override void AddPatty()
        {
            Console.WriteLine("Add meat patty");
        }

        public override void AddToppings()
        {
            Console.WriteLine("Add cheese");
            Console.WriteLine("Add pickles");
            Console.WriteLine("Add ketchup");
        }
    }
}
