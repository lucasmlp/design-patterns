using NUnit.Framework;
using DesignPatterns.CreationalPatterns.SimpleFactory;

namespace DesigntPatterns.CreationalPatterns.SimpleFactory.Test;

[TestFixture]
public class SimpleFactory_Tests
{
    private Door door;
    private double width;
    private double height;

    [SetUp]
    public void Setup()
    {
        door = new WoodenDoor(1.5, 2.2, "Carvalho");
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


}