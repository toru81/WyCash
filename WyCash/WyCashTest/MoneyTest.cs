using System;
using WyCash;
using Xunit;

namespace WyCashTest
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Doller five = new Doller(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
