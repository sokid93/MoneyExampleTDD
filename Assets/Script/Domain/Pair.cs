public class Pair
{
    private string from;
    private string to;

    public Pair(string from, string to)
    {
        this.from = from;
        this.to = to;
    }

    override public bool Equals(object obj)
    {
        Pair pair = (Pair)obj;
        return from.Equals(pair.from) && to.Equals(pair.to);
    }

    public override int GetHashCode()
    {
        return 0;
    }
}
