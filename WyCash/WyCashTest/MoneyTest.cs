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

            Assert.False(Money.Doller(5).Equals(Money.Franc(5)));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Doller(1).Currency);
            Assert.Equal("CHF", Money.Franc(1).Currency);
        }

        [Fact]
        public void TestSimpleAddition()
        {
            Money sum = Money.Doller(5).Plus(Money.Doller(5));

            Assert.Equal(Money.Doller(10), sum);
        }
    }
}
