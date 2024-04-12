using System;

public class Dollar : Money
{
    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public Money times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }
}

