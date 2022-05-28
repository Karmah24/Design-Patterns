namespace simple_factory
{
    public class PizzaOrder
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            store.orderPizza("cheese");
            store.orderPizza("pepperoni");
        }
    }
}