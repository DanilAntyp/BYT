namespace BYT.Task2.Tests;
public class CalcTests
{
    private Calculator calculator;
    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }
    [Test]
    public void AddTwoNumberReturnsCorrectResult()
    {
        Assert.That( calculator.Calculate(4,4,'+'), Is.EqualTo(8));
    }
    [Test]
    public void SubstractTwoNumberReturnsCorrectResult()
    {
        Assert.That( calculator.Calculate(4,4,'-'), Is.EqualTo(0));
    }
    [Test]
    public void MultiplyTwoNumberReturnsCorrectResult()
    {
        Assert.That( calculator.Calculate(4,4,'*'), Is.EqualTo(16));
    }
    [Test]
    public void DivideTwoNumberReturnsCorrectResult()
    {
        Assert.That( calculator.Calculate(4,4,'/'), Is.EqualTo(1));
    }

    [Test]
    public void DivideByZeroThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Calculate(4,0,'/'));
    }
}