using Factory;

static void CreateFruit(FruitCreator creator)
{
    IFruit fruit = creator.CreateProduct();
    Console.WriteLine(fruit);
}

CreateFruit(new AppleCreator());

CreateFruit(new PearCreator());