using System;
using NUnit.Framework;

[TestFixture]
public class CellTest
{
    [Test]
    public void FooSet()
    {
        Cell cell = new Cell();
        cell.Foo = (5150);
        Assert.AreEqual(5150, cell.Foo);
    }
}

