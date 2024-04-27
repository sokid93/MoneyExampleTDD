public interface Expression
{
    Money reduce(Bank bank, string to);
    Expression plus(Expression addend);
}
