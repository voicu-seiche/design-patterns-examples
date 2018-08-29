using System;

namespace AbstractFactoryExample.Structural
{
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine("{0} interacts with {1}", this.GetType().Name, productA.GetType().Name);
        }
    }
}
