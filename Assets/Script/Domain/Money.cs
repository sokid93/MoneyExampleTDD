using System;

public class Money
{
    protected int amount;
    override public bool Equals(object obj)
    {
        Money money = (Money)obj;
        return amount == money.amount && GetType().Equals(money.GetType());
    }
}
