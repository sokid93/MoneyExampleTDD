using System;

public class Dollar
{
    private int amount;

    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public Dollar times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    override public bool Equals(object obj)
    {
        Dollar dollar = (Dollar) obj;
        return amount == dollar.amount;
    }
}

