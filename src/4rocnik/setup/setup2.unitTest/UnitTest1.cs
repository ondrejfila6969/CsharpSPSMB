namespace setup2.unitTest;
using setup2;

public class UnitTest1
{
    [Theory]
    [InlineData()]
    public void happy_case(double a, string s, double b)
    {
        CalculatorExample calculator = new CalculatorExample();
        switch(s) {
            case "+":
                Assert.Equal(a + b, calculator.Add(a, b));
                break;
            case "-":
                Assert.Equal(a - b, calculator.Diff(a, b));
                break;
            case "*":
                Assert.Equal(a * b, calculator.Multiply(a, b));
                break;
            case "/":
                Assert.Equal(a / b, calculator.Divide(a, b));
                break;
            case "**":
                Assert.Equal(Math.Pow(a, b), calculator.Power(a, b));
                break;
        }
    }

    [Theory]
    [InlineData(1, "+", 1)]
    public void unhappy_case()
    {
    }
}