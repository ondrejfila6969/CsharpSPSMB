namespace setup2;

public class CalculatorExample
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Diff(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException e)
        {
            throw new DivideByZeroException("Dividing by zero", e);
        }
    }

    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

}