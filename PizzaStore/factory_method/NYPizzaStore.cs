namespace factory_method
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = new NYStyleCheesePizza();
            if (type == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                pizza = new NYStyleVeggiePizza();
            }
            return pizza;
        }
    }
}