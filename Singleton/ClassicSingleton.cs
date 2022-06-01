namespace Singleton
{
    // not thread safe
    public class ClassicSingleton
    {
        private static ClassicSingleton uniqueInstance = null;
        private ClassicSingleton() {}
        public ClassicSingleton getInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new ClassicSingleton();
            return uniqueInstance;
        }
        public void getDescription()
        {
            System.Console.WriteLine("Classic Singleton");
        }
    }
}