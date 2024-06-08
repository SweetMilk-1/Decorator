
using Decorator;

public class TomatoAddition : AdditionDecorator
{
    private int _myCost = 10;
    public TomatoAddition(PizzaAbstract pizza) : base(pizza) { }

    public override int getCost()
    {
        return _myCost + _basePizza.getCost();
    }

    public override string getDescription()
    {
        return _basePizza.getDescription() + $"\nTomato - {_myCost}$";
    }
}

