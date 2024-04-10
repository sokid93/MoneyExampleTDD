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
        five.times(2);
        Assert.AreEqual(10, five.amount);
    }
}
