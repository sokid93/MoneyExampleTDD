using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Tests
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestMultiplication()
    {
        Dollar five = new Dollar(5);
        five.times(2);
        Assert.AreEqual(10, five.amount);
    }

}
