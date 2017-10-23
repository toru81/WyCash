using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Money : Expression
    {
        public int Amount { get; }
        public string Currency { get; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object obj)
        {
            if (((Money)obj).Currency != Currency)
            {
                return false;
            }
            return Amount == ((Money)obj).Amount;
        }

        public static Money Doller(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(string to)
        {
            return this;
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }
}
