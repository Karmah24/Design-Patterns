namespace Starbuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }
        public override double cost() 
        {
            return .99;
        }
    }
}