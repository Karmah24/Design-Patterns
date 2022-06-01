namespace Starbuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage = new Decaf();
        public abstract override string getDescription();
    }
}