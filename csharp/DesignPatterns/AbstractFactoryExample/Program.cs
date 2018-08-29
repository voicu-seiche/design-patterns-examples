using System;
using AbstractFactoryExample.RealWorld;
using AbstractFactoryExample.Structural;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structural example:");
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.WriteLine();

            Console.WriteLine("Real-world example:");
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}
