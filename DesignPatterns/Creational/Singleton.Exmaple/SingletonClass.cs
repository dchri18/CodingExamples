namespace Singleton.Exmaple
{
    public sealed class SingletonClass
    {
        private static volatile SingletonClass instance;
        private static object syncRoot = new object();

        private SingletonClass() { }

        public static SingletonClass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SingletonClass();
                    }
                }

                return instance;
            }
        }

        public int TestValue { get; set; }
    }
}
