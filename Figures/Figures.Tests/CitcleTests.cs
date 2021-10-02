using NUnit.Framework;

namespace Figures.Tests;
public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1, Math.PI)]
    [TestCase(2, 4 * Math.PI)]
    public void CircleSquare(decimal radius, decimal expectedSquare)
    {
        var triangle = new Circle(radius);
        Assert.True(triangle.CalulateSquare() == expectedSquare);
    }
}