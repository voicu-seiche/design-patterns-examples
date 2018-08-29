namespace AbstractFactoryExample.Structural
{
    class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            this._abstractProductB = factory.CreateProductB();
            this._abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            this._abstractProductB.Interact(this._abstractProductA);
        }
    }
}
