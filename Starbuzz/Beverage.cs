namespace Starbuzz
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";
        public virtual string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}