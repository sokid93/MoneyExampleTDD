using System;

public class Franc : Money
{
    public Franc(int amount)
    {
        this.amount = amount;
    }

    override public Money times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }
}

