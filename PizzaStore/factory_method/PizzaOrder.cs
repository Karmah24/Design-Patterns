namespace factory_method
{
    public class PizzaOrder
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            nyStore.orderPizza("veggie");
            PizzaStore chStore = new CHPizzaStore();
            chStore.orderPizza("cheese");
        }
    }
}