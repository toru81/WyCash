using System;

namespace WyCash
{
    public class Sum : Expression
    {
        public Sum(Money money, Money addend)
        {
            Augend = money;
            Addend = addend;
        }

        public Money Augend { get; set; }
        public Money Addend { get; set; }

        public Money Reduce(string to)
        {
            var amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }

    }
}