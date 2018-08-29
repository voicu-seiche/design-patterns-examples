namespace SingletonExample.Structural
{
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
