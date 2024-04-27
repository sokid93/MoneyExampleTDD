public class Sum : Expression
{
    public Expression augend;
    public Expression addend;

    public Sum(Expression augend, Expression addend)
    {
        this.augend = augend;
        this.addend = addend;
    }

    public Money reduce(Bank bank, string to)
    {
        int amount = augend.reduce(bank, to).amount + addend.reduce(bank, to).amount;
        return new Money(amount, to);
    }

    public Expression plus(Expression addend)
    {
        return new Sum(this, addend);
    }
}
