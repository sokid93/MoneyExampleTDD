using System;

public class Dollar : Money
{
    private new string _currency;

    public Dollar(int amount, string currency) : base(amount, currency)
    {

    }

    override public Money times(int multiplier)
    {
        return new Dollar(amount * multiplier, _currency);
    }
}

