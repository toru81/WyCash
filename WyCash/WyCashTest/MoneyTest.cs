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
            var five = Money.Doller(5);

            Assert.Equal(Money.Doller(10), five.Times(2));
            Assert.Equal(Money.Doller(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Doller(5).Equals(Money.Doller(5)));
            Assert.False(Money.Doller(5).Equals(Money.Doller(6)));

            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));

            Assert.False(Money.Doller(5).Equals(Money.Franc(5)));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            var five = new Franc(5);

            Assert.Equal(Money.Franc(10), five.Times(2));
            Assert.Equal(Money.Franc(15), five.Times(3));
        }

    }
}
