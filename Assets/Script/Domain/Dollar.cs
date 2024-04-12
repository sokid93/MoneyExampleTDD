using System;

public class Dollar : Money
{
    private String _currency;

    public Dollar(int amount)
    {
        this.amount = amount;
        _currency = "USD";
    }

    override public Money times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override string currency()
    {
        return _currency;
    }
}

