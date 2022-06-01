namespace Duck_Turkey
{
    public class Test
    {
        static void Main(string[] args)
        {
            Turkey wildTurkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);
            turkeyAdapter.quack();
            turkeyAdapter.fly();

            Duck mallardDuck = new MallardDuck();
            Turkey duckAdapter = new DuckAdapter(mallardDuck);
            duckAdapter.gobble();
            duckAdapter.fly();
        }
    }
}