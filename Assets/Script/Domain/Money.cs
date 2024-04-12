using System;

public class Money
{
    protected int amount;

    public static Dollar dollar(int amount)
    {
        return new Dollar(amount);
    }

    override public bool Equals(object obj)
    {
        Money money = (Money)obj;
        return amount == money.amount && GetType().Equals(money.GetType());
    }
}
