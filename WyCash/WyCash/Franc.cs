using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Franc :Money
    {
        public Franc(int amount)
            :base(amount)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
