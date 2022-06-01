namespace Duck_Turkey
{
    public class DuckAdapter : Turkey
    {
        Duck duck;
        static Random rand = new Random();
        public DuckAdapter(Duck duck)
        {
            this.duck = duck;
        }
        public void gobble()
        {
            duck.quack();
        }
        public void fly()
        {
            if (rand.Next(3) == 0) duck.fly();
        }
    }
}