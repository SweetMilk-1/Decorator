
using Decorator;

public class MozarellaAddition : AdditionDecorator
{
    private int _myCost = 5;
    public MozarellaAddition(PizzaAbstract pizza) : base(pizza) { }

    public override int getCost()
    {
        return _myCost + _basePizza.getCost();
    }

    public override string getDescription()
    {
        return _basePizza.getDescription() + $"\nMozarella - {_myCost}$";
    }
}

