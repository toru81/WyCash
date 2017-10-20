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
            Doller product = five.Times(2);
            Assert.Equal(10, product.Amount);

            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }
    }
}
