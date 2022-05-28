namespace simple_factory
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = new CheesePizza();
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            return pizza;
        }
    }
}