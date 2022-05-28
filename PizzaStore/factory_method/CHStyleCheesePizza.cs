namespace factory_method
{
    public class CHStyleCheesePizza : Pizza
    {
        public CHStyleCheesePizza() { 
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
    
            toppings.Add("Shredded Mozzarella Cheese");
	    }
 
        public override void cut() {
            System.Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}