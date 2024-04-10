using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Modelo;

public class Tests
{
    [Test]
    public void TestMultiplication()
    {
        Dollar five = new Dollar(5);
        Dollar product= five.times(2);
        Assert.AreEqual(10, product.amount);
        product = five.times(3);
        Assert.AreEqual(15, product.amount);
    }

    [Test]
    public void TestEquality()
    {
        Assert.IsTrue(new Dollar(5).equals(new Dollar(5)));
        Assert.IsFalse(new Dollar(5).equals(new Dollar(6)));
    }
}
