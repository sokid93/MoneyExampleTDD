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
        Money sum = Money.dollar(5).plus(Money.dollar(5));
        Assert.AreEqual(Money.dollar(10), sum);
        Money five = Money.dollar(5);
        Expression sum = five.plus(five);
        Bank bank = new Bank();
        Money reduced = bank.reduce(sum, "USD");
        Assert.AreEqual(Money.dollar(10), reduced);
    }
}
