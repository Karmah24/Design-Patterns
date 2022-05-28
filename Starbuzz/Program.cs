namespace Starbuzz
{
    public class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.getDescription());
            Console.WriteLine("$" + beverage.cost());
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.getDescription());
            Console.WriteLine("$" + beverage2.cost());
        }       
    }
}