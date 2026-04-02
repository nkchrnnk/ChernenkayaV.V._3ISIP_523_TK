using Xunit;
using System;
using tk;
using Assert = Xunit.Assert;

public class CalculatorTests
{
    

    [Fact]
    public void AddTest()
    {
        double result = Calculator.Calculate(5, 3, "+");
        Assert.Equal(8, result);
    }

    [Fact]
    public void SubtractTest()
    {
        double result = Calculator.Calculate(10, 4, "-");
        Assert.Equal(6, result);
    }

    [Fact]
    public void MultiplyTest()
    {
        double result = Calculator.Calculate(2, 6, "*");
        Assert.Equal(12, result);
    }

    [Fact]
    public void DivideTest()
    {
        double result = Calculator.Calculate(8, 2, "/");
        Assert.Equal(4, result);
    }

    [Fact]
    public void DivideByZeroTest()
    {
        Assert.Throws<DivideByZeroException>(() =>
            Calculator.Calculate(5, 0, "/"));
    }

    [Fact]
    public void InvalidOperationTest()
    {
        Assert.Throws<ArgumentException>(() =>
            Calculator.Calculate(5, 5, "%"));
    }

    

    [Fact]
    public void Add_NegativeNumbers()
    {
        double result = Calculator.Calculate(-5, -3, "+");
        Assert.Equal(-8, result);
    }

    [Fact]
    public void Subtract_ResultNegative()
    {
        double result = Calculator.Calculate(3, 10, "-");
        Assert.Equal(-7, result);
    }

    [Fact]
    public void Divide_FractionResult()
    {
        double result = Calculator.Calculate(7, 2, "/");
        Assert.Equal(3.5, result, 5); // точность
    }

    
    [Fact]
    public void Multiply_ByZero()
    {
        double result = Calculator.Calculate(5, 0, "*");
        Assert.Equal(0, result);
    }

   
    [Fact]
    public void Divide_NegativeByPositive()
    {
        double result = Calculator.Calculate(-10, 2, "/");
        Assert.Equal(-5, result);
    }
}