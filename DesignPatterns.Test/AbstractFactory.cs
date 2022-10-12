using NUnit.Framework;
using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesigntPatterns.CreationalPatterns.AbstractFactory.Test;

[TestFixture]
public class AbstractFactory_Tests
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldGenerateWoodenDoorAndCarpenter()
    {
        var woodenDoorFactory = new WoodenDoorFactory();
        var door = woodenDoorFactory.MakeDoor();
        var fittingExpert = woodenDoorFactory.MakeFittingExpert();
        Assert.AreEqual(door.GetDescription(), "I am a wooden door!");
        Assert.AreEqual(fittingExpert.GetDescription(), "I can only fit wooden doors");
    }

    [Test]
    public void ShouldGenerateIronDoorAndWelder()
    {
        var ironDoorFactory = new IronDoorFactory();
        var door = ironDoorFactory.MakeDoor();
        var fittingExpert = ironDoorFactory.MakeFittingExpert();
        Assert.AreEqual(door.GetDescription(), "I am a iron door!");
        Assert.AreEqual(fittingExpert.GetDescription(), "I can only fit iron doors");
    }
}