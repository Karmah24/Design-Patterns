namespace Starbuzz
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return .15 + beverage.cost();
        }
    }
}