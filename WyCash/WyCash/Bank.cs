namespace WyCash
{
    public class Bank
    {
        public Bank()
        {
        }

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(to);
        }
    }
}