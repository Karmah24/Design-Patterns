namespace Starbuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public abstract override string getDescription();
    }
}