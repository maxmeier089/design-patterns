namespace Template
{
    public class VeggieBurgerMaker : BurgerMaker
    {

        public override string Name => "Veggie Burger";

        public override void AddPatty()
        {
            Console.WriteLine("Add veggie patty");
        }

        public override void AddToppings()
        {
            Console.WriteLine("Add salad");
            Console.WriteLine("Add mayo");
        }

    }
}
