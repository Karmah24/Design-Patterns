namespace simple_factory
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "PepperoniPizza Pizza";
            dough = "Thin crust dough";
            sauce = "BBQ Sauce";
            toppings.Add("Pepperoni");
            toppings.Add("Black Olives");
            toppings.Add("Cheddar");
            toppings.Add("Mozzerela");
        }
        public override void bake()
        {
            System.Console.WriteLine("Baking at 300 degrees for 10 minutes");
        }
    }
}