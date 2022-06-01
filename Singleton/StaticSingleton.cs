namespace classic
{
    public class StaticSingleton
    {
        private static StaticSingleton uniqueInstance = new StaticSingleton();
        private StaticSingleton() {}
        public StaticSingleton getInstance()
        {
            // if (uniqueInstance == null) uniqueInstance = new StaticSingleton();
            return uniqueInstance;
        }
        public void getDescription()
        {
            System.Console.WriteLine("Statically initialized Singleton");
        }
    }
}