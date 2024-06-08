public class NewYorkBase : BaseAbstract
{
    const int _myCost = 2;
    public override int getCost()
    {
        return _myCost;
    }

    public override string getDescription()
    {
        return $"Base: NewYork - {_myCost}$\nAdditions";
    }
}

