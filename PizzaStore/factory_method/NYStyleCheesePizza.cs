namespace factory_method
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() { 
		name = "NY Style Deep Dish Cheese Pizza";
		dough = "Thin Crust Dough";
		sauce = "Marinara Sauce";
 
		toppings.Add("Grated Reggiano Cheese");
		}
    }
}