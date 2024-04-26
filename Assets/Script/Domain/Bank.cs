public class Bank
{
    public Money reduce(Expression source, string to)
    {
        if (source.GetType() == typeof(Money))
            return (Money)source;
        Sum sum = (Sum)source;
        return sum.reduce(to);
    }
}
