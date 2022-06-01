namespace SimUDuck
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        public Duck() {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        } 
        public abstract void display();
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}