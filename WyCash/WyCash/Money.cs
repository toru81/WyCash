using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Money
    {
        public int Amount { get; }

        public Money(int amount)
        {
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Amount == ((Money)obj).Amount;
        }
    }
}
