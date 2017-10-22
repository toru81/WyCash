using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Doller : Money
    {
        public Doller(int amount, string currency)
            : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Doller(Amount * multiplier);
        }
    }
}
