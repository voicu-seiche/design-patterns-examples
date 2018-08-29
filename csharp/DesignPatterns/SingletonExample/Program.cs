using System;
using SingletonExample.RealWorld;
using SingletonExample.Structural;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structural example:");
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Console.WriteLine();

            Console.WriteLine("Real-world example:");
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance");
                Console.WriteLine();
            }

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.GetServer();
                Console.WriteLine("Dispatch Request to: {0}", server);
            }

            Console.ReadLine();
        }
    }
}
