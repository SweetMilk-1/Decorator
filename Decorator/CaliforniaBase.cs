
public class CaliforniaBase : BaseAbstract
{
    const int _myCost = 3;
    public override int getCost()
    {
        return _myCost;
    }

    public override string getDescription()
    {
        return $"Base: California - {_myCost}$\nAdditions";
    }
}

