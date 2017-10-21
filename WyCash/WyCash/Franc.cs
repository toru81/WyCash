using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Franc
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return Amount == ((Franc)obj).Amount;
        }
    }
}
