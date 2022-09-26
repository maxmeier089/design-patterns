namespace Factory
{
    public class AppleCreator : FruitCreator
    {
        public override IFruit CreateProduct()
        {
            return new Apple();
        }

    }
}
