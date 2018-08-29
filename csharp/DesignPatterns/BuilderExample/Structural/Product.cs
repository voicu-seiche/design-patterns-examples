using System;
using System.Collections.Generic;

namespace BuilderExample.Structural
{
    class Product
    {
        private readonly List<string> parts = new List<string>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Product Parts -------");
            foreach (string part in this.parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
