using System;

public class Dollar : Money
{
    public Dollar(int amount)
    {
        this.amount = amount;
    }

    override public Money times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }
}

