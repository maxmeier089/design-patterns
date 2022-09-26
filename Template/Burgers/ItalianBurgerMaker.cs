namespace Template
{
    public class ItalianBurgerMaker : BurgerMaker
    {

        public override string Name => "Italian Burger";

        public override void AddBun()
        {
            Console.WriteLine("Add ciabatta bun");
        }

        public override void AddPatty()
        {
            Console.WriteLine("Add meat patty");
        }

        public override void AddToppings()
        {
            Console.WriteLine("Add rocket");
            Console.WriteLine("Add tomato");
            Console.WriteLine("Add balsamico");
        }

    }
}
