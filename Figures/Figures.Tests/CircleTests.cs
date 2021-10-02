using NUnit.Framework;
using System.Globalization;

namespace Figures.Tests;
public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1, "3.14159265358979")]
    [TestCase(2, "12.56637061435916")]
    public void CircleSquare(decimal radius, string expectedSquare)
    {
        var triangle = new Circle(radius);
        var actualSquare = triangle.CalulateSquare();
        Assert.True(actualSquare == decimal.Parse(expectedSquare, CultureInfo.InvariantCulture));
    }
}