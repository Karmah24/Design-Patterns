namespace Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso Coffee";
        }
        public override double cost() 
        {
            return 1.99;
        }
    }
}