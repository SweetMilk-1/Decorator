
using Decorator;

public class PepperoniAddition : AdditionDecorator
{
    private int _myCost = 9;
    public PepperoniAddition(PizzaAbstract pizza) : base(pizza) { }

    public override int getCost()
    {
        return _myCost + _basePizza.getCost();
    }

    public override string getDescription()
    {
        return _basePizza.getDescription() + $"\nPepperoni - {_myCost}$";
    }
}

