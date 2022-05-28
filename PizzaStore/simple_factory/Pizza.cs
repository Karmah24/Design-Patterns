namespace simple_factory
{
    public abstract class Pizza
    {
        public string name = "", dough = "", sauce = "";
        public List<string> toppings = new List<string>();
        public virtual void prepare()
        {
            System.Console.WriteLine("Preparing " + name);
            System.Console.WriteLine("Tossing " + dough);
            System.Console.WriteLine("Adding " + sauce);
            System.Console.WriteLine("Adding Toppings: ");
            foreach (var topping in toppings)
            {
                System.Console.WriteLine(topping + " ");
            }
            System.Console.WriteLine();
        }
        public virtual void bake()
        {
            System.Console.WriteLine("Baking at 250 degress for 15 minutes");
        }
        public virtual void cut()
        {
            System.Console.WriteLine("Cutting pizza into diagonals");
        }
        public virtual void box()
        {
            System.Console.WriteLine("Placing pizza in offical PizzaStore box");
        }
    }
}