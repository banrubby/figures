using NUnit.Framework;

namespace Figures.Tests;
public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(3, 4, 5)]
    public void IsRightTriangle(decimal a, decimal b, decimal c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.True(triangle.IsRightTriangle);
        Assert.Pass();
    }

    [Test]
    [TestCase(3, 4, 5, 6)]
    public void TriangleSquare(decimal a, decimal b, decimal c, decimal expectedSquare)
    {
        var triangle = new Triangle(a, b, c);
        Assert.True(triangle.CalulateSquare() == expectedSquare);
    }
}