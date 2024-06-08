
public class ClassicBase : BaseAbstract
{
    const int _myCost = 1;
    public override int getCost()
    {
        return _myCost;
    }

    public override string getDescription()
    {
        return $"Base: Classic - {_myCost}$\nAdditions";
    }
}

