namespace Calc.Tests;

[TestClass]
public class CalcTest
{
    private static Calc calc;

    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        calc = new Calc();
    }

    [TestMethod]
    public void TestDiscriminantLessThanZero()
    {
        // Arrange
        double a = 1, b = 2, c = 3;
        double[] expected = Array.Empty<double>();

        double[] actual = calc.Roots(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDiscriminantEqualToZero()
    {
        double a = 1, b = 2, c = 1;
        double[] expected = [-1];

        double[] actual = calc.Roots(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDiscriminantMoreThanZero()
    {
        double a = 1, b = -3, c = 2;
        double[] expected = { 2, 1 };

        double[] actual = calc.Roots(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestPercent()
    {
        double x = 100, percent = 40;
        double expected = 40;

        double actual = calc.Percent(x, percent);

        Assert.AreEqual(expected, actual, 0.001);
    }
}