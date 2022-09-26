namespace AbstractFactory
{
    public class AppleFactory : AbstractFruitFactory
    {
        public override Apple CreateFruit()
        {
            return new Apple();
        }

        public override Package CreatePackage()
        {
            return new AppleWrap();
        }
    }
}
