using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Tests
{
    [Test]
    public void TestMultiplication()
    {
        Money five = Money.dollar(5);
        Assert.AreEqual(Money.dollar(10), five.times(2));
        Assert.AreEqual(Money.dollar(15), five.times(3));
    }

    [Test]
    public void TestEquality()
    {
        Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
        Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
        Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
    }

    [Test]
    public void TestCurrency()
    {
        Assert.AreEqual("USD", Money.dollar(1).currency());
        Assert.AreEqual("CHF", Money.franc(1).currency());
    }

    [Test]
    public void TestSimpleAddition()
    {
        Money five = Money.dollar(5);
        Expression sum = five.plus(five);
        Bank bank = new Bank();
        Money reduced = bank.reduce(sum, "USD");
        Assert.AreEqual(Money.dollar(10), reduced);
    }

    [Test]
    public void TestPlusRetunsSum()
    {
        Money five = Money.dollar(5);
        Expression result = five.plus(five);
        Sum sum = (Sum)result;
        Assert.AreEqual(five, sum.augend);
        Assert.AreEqual(five, sum.addend);
    }

    [Test]
    public void TestReduceSum()
    {
        Expression sum = new Sum(Money.dollar(3), Money.dollar(4));
        Bank bank = new Bank();
        Money result = bank.reduce(sum, "USD");
        Assert.AreEqual(Money.dollar(7), result);
    }

    [Test]
    public void TestReduceMoney()
    {
        Bank bank = new Bank();
        Money result = bank.reduce(Money.dollar(1), "USD");
        Assert.AreEqual(Money.dollar(1), result);
    }

    [Test]
    public void TestReduceMoneyDifferentCurrency()
    {
        Bank bank = new Bank();
        bank.addRate("CHF", "USD", 2);
        Money result = bank.reduce(Money.franc(2), "USD");
        Assert.AreEqual(Money.dollar(1), result);
    }
}
