namespace Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}