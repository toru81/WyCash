using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public abstract class Money
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
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Amount == ((Money)obj).Amount;
        }

        public static Money Doller(int amount)
        {
            return new Doller(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);
    }
}
