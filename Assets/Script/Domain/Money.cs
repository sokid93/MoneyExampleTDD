using System;

public abstract class Money
{
    protected int amount;

    public static Money dollar(int amount)
    {
        return new Dollar(amount);
    }

    public static Money franc(int amount)
    {
        return new Franc(amount);
    }

    override public bool Equals(object obj)
    {
        Money money = (Money)obj;
        return amount == money.amount && GetType().Equals(money.GetType());
    }

    public abstract Money times(int multiplier);
    public abstract String currency();
}
