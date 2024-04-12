using System;

public class Franc
{
    private int amount;

    public Franc(int amount)
    {
        this.amount = amount;
    }

    public Franc times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    override public bool Equals(object obj)
    {
        Franc franc = (Franc) obj;
        return amount == franc.amount;
    }
}

