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

            Assert.Equal(new Doller(10), five.Times(2));
            Assert.Equal(new Doller(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Doller(5).Equals(new Doller(5)));
            Assert.False(new Doller(5).Equals(new Doller(6)));
        }
    }
}
