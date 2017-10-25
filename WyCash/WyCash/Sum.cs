using System;

namespace WyCash
{
    public class Sum : Expression
    {
        public Sum(Expression money, Expression addend)
        {
            Augend = money;
            Addend = addend;
        }

        public Expression Augend { get; set; }
        public Expression Addend { get; set; }

        public Expression Plus(Expression addend)
        {
            throw new NotImplementedException();
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

    }
}