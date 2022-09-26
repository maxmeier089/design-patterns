using AbstractFactory;

static void CreateFruitAndPackage(AbstractFruitFactory factory)
{
    IFruit fruit = factory.CreateFruit();
    Package package = factory.CreatePackage();

    package.Fruit = fruit;

    Console.WriteLine(package);
}

CreateFruitAndPackage(new AppleFactory());

CreateFruitAndPackage(new PearFactory());