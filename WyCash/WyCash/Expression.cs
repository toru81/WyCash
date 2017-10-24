using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);
    }
}
