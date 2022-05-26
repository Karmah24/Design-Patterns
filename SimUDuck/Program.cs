namespace SimUDuck
{
    public class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            mallard.swim();
            mallard.setFlyBehavior(new FlyWithRocket());
            mallard.performFly();
        }
    }
}