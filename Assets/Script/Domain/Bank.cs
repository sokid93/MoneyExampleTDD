public class Bank
{
    public Money reduce(Expression source, string to)
    {
        return source.reduce(this, to);
    }

    public int rate(string from, string to)
    {
        return (from.Equals("CHF") && to.Equals("USD")) ? 2 : 1;
    }
}
