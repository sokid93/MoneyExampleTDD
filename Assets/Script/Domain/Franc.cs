using System;

public class Franc : Money
{
    private String _currency;

    public Franc(int amount)
    {
        this.amount = amount;
        _currency = "CHF";
    }

    override public Money times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    public override string currency()
    {
        return _currency;
    }
}

