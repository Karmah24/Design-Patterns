namespace factory_method
{
    public abstract class PizzaStore
    {
        public abstract Pizza createPizza(string type); // factory method
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}