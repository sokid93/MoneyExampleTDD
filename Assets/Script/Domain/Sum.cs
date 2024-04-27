public class Sum : Expression
{
    public Money augend;
    public Money addend;

    public Sum(Money augend, Money addend)
    {
        this.augend = augend;
        this.addend = addend;
    }

    public Money reduce(Bank bank, string to)
    {
        int amount = augend.reduce(bank, to).amount + addend.reduce(bank, to).amount;
        return new Money(amount, to);
    }
}
