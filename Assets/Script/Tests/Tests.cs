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
        Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
        Assert.IsFalse(Money.franc(5).Equals(Money.franc(6)));
        Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
    }

    [Test]
    public void TestFrancMultiplication()
    {
        Money five = Money.franc(5);
        Assert.AreEqual(Money.franc(10), five.times(2));
        Assert.AreEqual(Money.franc(15), five.times(3));
    }
}
