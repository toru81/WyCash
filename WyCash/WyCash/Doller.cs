using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Doller
    {
        public Doller(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public Doller Times(int multiplier)
        {
            return new Doller(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return Amount == ((Doller)obj).Amount;
        }
    }
}
