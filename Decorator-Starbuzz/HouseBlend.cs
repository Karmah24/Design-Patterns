namespace Starbuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double cost() 
        {
            return .89;
        }
    }
}