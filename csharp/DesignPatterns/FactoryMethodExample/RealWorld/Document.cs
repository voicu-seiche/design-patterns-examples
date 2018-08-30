using System.Collections.Generic;

namespace FactoryMethodExample.RealWorld
{
    abstract class Document
    {
        private readonly List<Page> pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return this.pages; }
        }

        // Factory Method

        public abstract void CreatePages();
    }
}
