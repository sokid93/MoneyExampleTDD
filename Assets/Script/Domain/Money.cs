using System;

public class Money
{
    protected int amount;
    protected string _currency;

    public Money(int amount, string currency)
    {
        this.amount = amount;
        this._currency = currency;
    }

    public static Money dollar(int amount)
    {
        return new Money(amount, "USD");
    }

    public static Money franc(int amount)
    {
        return new Money(amount, "CHF");
    }

    override public bool Equals(object obj)
    {
        Money money = (Money)obj;
        return amount == money.amount && currency().Equals(money.currency());
    }

    public Money times(int multiplier)
    {
        return new Money(amount * multiplier, _currency);
    }

    public Money plus(Money addend)
    {
        return new Money(amount + addend.amount, _currency);
    }

    public string currency()
    {
        return _currency;
    }
}
