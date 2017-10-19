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

        public void Times(int multiplier)
        {
            Amount = Amount * multiplier;
        }
    }
}
