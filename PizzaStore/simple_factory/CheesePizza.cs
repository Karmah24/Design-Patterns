namespace simple_factory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Cheese Burst dough";
            sauce = "Marinara Sauce";
            toppings.Add("Diced Onions");
            toppings.Add("Cheddar");
            toppings.Add("Mozzerela");
        }
        public override void cut()
        {
            System.Console.WriteLine("Cutting pizza into squares");
        }
    }
}