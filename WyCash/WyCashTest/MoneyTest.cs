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
            var five = Money.Doller(5);
            var sum = five.Plus(five);
            var bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");

            Assert.Equal(Money.Doller(10), reduced);
        }

        [Fact]
        public void TestPlusReturnsSum()
        {
            var five = Money.Doller(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum)result;

            Assert.Equal(five, sum.Augend);
            Assert.Equal(five, sum.Addend);
        }

        [Fact]
        public void TestReduceSum()
        {
            Expression sum = new Sum(Money.Doller(3), Money.Doller(4));
            var bank = new Bank();
            Money result = bank.Reduce(sum, "USD");

            Assert.Equal(Money.Doller(7), result);
        }

        [Fact]
        public void TestReduceMoney()
        {
            var bank = new Bank();
            Money result = bank.Reduce(Money.Doller(1), "USD");

            Assert.Equal(Money.Doller(1), result);
        }

        [Fact]
        public void TestReduceMoneyDifferenceCurrency()
        {
            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");

            Assert.Equal(Money.Doller(1), result);
        }

        [Fact]
        public void TestIdentityRate()
        {
            Assert.Equal(1, new Bank().Rate("USD", "USD"));
        }

        [Fact]
        public void TestMixedAddition()
        {
            Expression fiveBucks = Money.Doller(5);
            Expression tenFrancs = Money.Franc(10);

            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            var result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Doller(10), result);
        }

        [Fact]
        public void TestSumPlusMoney()
        {
            Expression fiveBucks = Money.Doller(5);
            Expression tenFrancs = Money.Franc(10);

            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);

            var result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Doller(15), result);
        }

        [Fact]
        public void TestSumTimes()
        {
            Expression fiveBucks = Money.Doller(5);
            Expression tenFrancs = Money.Franc(10);

            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Times(2);

            var result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Doller(20), result);
        }
    }
}
