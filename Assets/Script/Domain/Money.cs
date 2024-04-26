using System;

public class Money : Expression
{
    public int amount;
    public string _currency;

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

    public Expression plus(Money addend)
    {
        return new Sum(this, addend);
    }

    public string currency()
    {
        return _currency;
    }

    public Money reduce(Bank bank, string to)
    {
        int rate = bank.rate(_currency, to);
        return new Money(amount / rate, to);
    }
}
