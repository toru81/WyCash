using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public class Doller : Money
    {
        public Doller(int amount)
            : base(amount)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Doller(Amount * multiplier);
        }
    }
}
