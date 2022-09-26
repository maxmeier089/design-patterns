namespace AbstractFactory
{
    public class AppleWrap : Package
    {

        public override string ToString()
        {
            if (Fruit == null) return "Empty apple wrap.";
            else return "Apple wrap containing one " + Fruit;
        }

    }
}
