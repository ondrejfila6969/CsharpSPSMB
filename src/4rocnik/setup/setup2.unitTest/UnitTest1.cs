namespace setup2.unitTest;
using setup2;

public class UnitTest1
{
    private CalculatorExample calculator = new CalculatorExample();
    
        [Theory]
        [InlineData("4 + 5")]
        [InlineData("10 - 3")]
        [InlineData("2 * 6")]
        [InlineData("8 / 2")]
        [InlineData("2 ** 3")]
        [InlineData("5.5 + 4.5")]
        [InlineData("7 - 12")]
        public void HappyCase(string equation)
        {
            var parts = equation.Split(" ");
            double a = double.Parse(parts[0].Replace(".", ","));
            string op = parts[1];
            double b = double.Parse(parts[2].Replace(".", ","));
            
            double result = 0;
            double expected = 0;

            switch (op)
            {
                case "+": result = calculator.Add(a, b); expected = a + b; break;
                case "-": result = calculator.Diff(a, b); expected = a - b; break;
                case "*": result = calculator.Multiply(a, b); expected = a * b; break;
                case "/": result = calculator.Divide(a, b); expected = a / b; break;
                case "**": result = calculator.Power(a, b); expected = Math.Pow(a, b); break;
            }

            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData("4 + 5")]
        [InlineData("10 - 3")]
        [InlineData("2 * 6")]
        [InlineData("8 / 2")]
        [InlineData("2 ** 3")]
        [InlineData("5.5 + 4.5")]
        [InlineData("7 - 12")]
        
        public void UnhappyCaseNegative(string equation)
        {
            var parts = equation.Split(" ");
            double a = double.Parse(parts[0].Replace(".", ","));
            string op = parts[1];
            double b = double.Parse(parts[2].Replace(".", ","));

            double result = 0;

            switch (op)
            {
                case "+": result = calculator.Add(a, b); break;
                case "-": result = calculator.Diff(a, b); break;
                case "*": result = calculator.Multiply(a, b); break;
                case "/": result = calculator.Divide(a, b); break;
                case "**": result = calculator.Power(a, b); break;
            }
            if (op != "+") Assert.NotEqual(a + b, result);
            if (op != "-") Assert.NotEqual(a - b, result);
            if (op != "*") Assert.NotEqual(a * b, result);
            if (op != "/") Assert.NotEqual(a / b, result);
            if (op != "**") Assert.NotEqual(Math.Pow(a, b), result);
        }
    }