using NUnit.Framework;
using DesignPatterns.CreationalPatterns.SimpleFactory;

namespace DesignPatterns.CreationalPatterns.SimpleFactory.Test;

[TestFixture]
public class SimpleFactory_Tests
{
    private Door door;
    private double width;
    private double height;

    public SimpleFactory_Tests()
    {
        this.door = new WoodenDoor(1.5, 2.2, 50, "Carvalho"); ;
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldGetWidth()
    {
        var width = door.GetWidth();
        Assert.AreEqual(width, 1.5);
    }

    [Test]
    public void ShouldGetHeight()
    {
        var width = door.GetHeight();
        Assert.AreEqual(width, 2.2);
    }

    [Test]
    public void ShouldGetWeight()
    {
        var weight = door.GetWeight();
        Assert.AreEqual(weight, 50);
    }


}