using System;

public class Franc : Money
{
    private new string _currency;

    public Franc(int amount, string currency): base(amount, currency)
    {
        
    }

    override public Money times(int multiplier)
    {
        return new Franc(amount * multiplier, _currency);
    }
}

