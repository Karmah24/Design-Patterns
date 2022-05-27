namespace Starbuzz
{
    public class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.getDescription());
            Console.WriteLine("$" + beverage.cost());
        }       
    }
}