using System;

namespace AbstractFactoryExample.RealWorld
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine("{0} eats {1}", this.GetType().Name, herbivore.GetType().Name);
        }
    }
}
