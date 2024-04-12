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
        Dollar five = new Dollar(5);
        Assert.AreEqual(new Dollar(10), five.times(2));
        Assert.AreEqual(new Dollar(15), five.times(3));
    }

    [Test]
    public void TestEquality()
    {
        Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
        Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
        Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        Assert.IsFalse(new Dollar(5).Equals(new Franc(5)));
    }

    [Test]
    public void TestFrancMultiplication()
    {
        Franc five = new Franc(5);
        Assert.AreEqual(new Franc(10), five.times(2));
        Assert.AreEqual(new Franc(15), five.times(3));
    }
}
