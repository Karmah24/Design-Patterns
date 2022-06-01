namespace Starbuzz
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Steamed Milk";
        }
        public override double cost()
        {
            return .10 + beverage.cost();
        }
    }
}