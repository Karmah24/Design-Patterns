namespace factory_method
{
    public class CHPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = new CHStyleCheesePizza();
            if (type == "cheese")
            {
                pizza = new CHStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                pizza = new CHStyleVeggiePizza();
            }
            return pizza;
        }
    }
}