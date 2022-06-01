namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            // flyBehavior = new FlyWithRocket();
            quackBehavior = new Quack();
            // quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}