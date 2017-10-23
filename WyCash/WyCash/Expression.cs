using System;
using System.Collections.Generic;
using System.Text;

namespace WyCash
{
    public interface Expression
    {
        Money Reduce(string to);
    }
}
