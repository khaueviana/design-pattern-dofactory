using AbstractFactoryPattern.RealWorld;
using AbstractFactoryPattern.StructuralCode;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           //STRUCTURAL CODE
            var client = new Client(new ConcreteFactory1());
            client.Run();

            var client2 = new Client(new ConcreteFactory2());
            client2.Run();

            //REAL WORLD
            var animalWorld = new AnimalWorld(new AfricaFactory());
            animalWorld.RunFoodChain();

            var animalWorld2 = new AnimalWorld(new AmericaFactory());
            animalWorld2.RunFoodChain();
        }
    }
}