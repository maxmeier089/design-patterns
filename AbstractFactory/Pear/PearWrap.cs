namespace AbstractFactory
{
    public class PearWrap : Package
    {

        public override string ToString()
        {
            if (Fruit == null) return "Empty pear wrap.";
            else return "Pear wrap containing one " + Fruit;
        }

    }
}
