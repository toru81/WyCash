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
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public Expression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
            throw new NotImplementedException();
        }
    }
}