using System;
using FactoryMethodExample.RealWorld;
using FactoryMethodExample.Structural;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structural example:");
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            Console.WriteLine();

            Console.WriteLine("Real-world example:");
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
