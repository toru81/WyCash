using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Franc :Money
    {
        public Franc(int amount, string currency)
            :base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}
