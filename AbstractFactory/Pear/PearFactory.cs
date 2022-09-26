namespace AbstractFactory
{
    public class PearFactory : AbstractFruitFactory
    {
        public override IFruit CreateFruit()
        {
            return new Pear();
        }

        public override Package CreatePackage()
        {
            return new PearWrap();
        }
    }
}
