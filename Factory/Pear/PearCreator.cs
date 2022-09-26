namespace Factory
{
    public class PearCreator : FruitCreator
    {
        public override IFruit CreateProduct()
        {
            return new Pear();
        }
    }
}
