namespace Starbuzz
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }
        public override double cost() 
        {
            return 1.05;
        }
    }
}