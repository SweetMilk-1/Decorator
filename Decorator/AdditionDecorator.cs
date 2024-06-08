namespace Decorator
{
    public abstract class AdditionDecorator : PizzaAbstract
    {
        protected PizzaAbstract _basePizza;

        public AdditionDecorator(PizzaAbstract basePizza)
        {
            _basePizza = basePizza;
        }
    }
}
