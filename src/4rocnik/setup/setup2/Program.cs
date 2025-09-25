using System.Text.RegularExpressions;
using setup2;
// See https://aka.ms/new-console-template for more information

// FIZZBUZZ
/*
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    } else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    } else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

void fizzbuzz(int number)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    } else if (number % 3 == 0)
    {
        Console.WriteLine("fizz");
    } else if (number % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}

fizzbuzz(15);
*/

// HÁDÁNÍ ČÍSLA

/*
bool programRunning = true;

Console.WriteLine("Zadejte horní hranici: ");
int maxValue = Int32.Parse(Console.ReadLine());

Console.WriteLine("Zadejte spodní hranici: ");
int minValue = Int32.Parse(Console.ReadLine());

var random = new Random();
int programNumber = random.Next(minValue, maxValue);
Console.WriteLine("Cheaty: " + programNumber);

int tries = 0;
do
{
    Console.WriteLine("Zadejte váš odhad: ");
    int guess = Int32.Parse(Console.ReadLine());

    if (guess != programNumber)
    {
        tries++;
        if (guess > programNumber)
        {
            Console.WriteLine("Číslo, které jste typoval, je větší než číslo programu");
        }
        else if (guess < programNumber)
        {
            Console.WriteLine("Číslo, které jste typoval, je menší než číslo programu");
        }
    }
    else
    {
        tries++;
        Console.WriteLine($"Gratulujeme, uhádl jste číslo a váš počet pokusů: {tries}");
        programRunning = false;
    }
} while (programRunning);
*/

// KALKULAČKA

Console.WriteLine("Zadejte rovnici pro výpočet: ");
string equation = Console.ReadLine();
string[] equationArray = Regex.Split(equation, @"\s+");

double firstNumber = Double.Parse(equationArray[0].Replace(".", ","));
string symbol = equationArray[1];
double secondNumber = Double.Parse(equationArray[2].Replace(".", ","));

CalculatorExample calculator = new CalculatorExample();
switch (symbol)
{
    case "+":
        Console.WriteLine($"{firstNumber.ToString().Replace(",", ".")} {symbol} {secondNumber.ToString().Replace(",", ".")} = {calculator.Add(firstNumber, secondNumber).ToString().Replace(",", ".")}");
        break;
    case "-":
        Console.WriteLine($"{firstNumber.ToString().Replace(",", ".")} {symbol} {secondNumber.ToString().Replace(",", ".")} = {calculator.Diff(firstNumber, secondNumber).ToString().Replace(",", ".")}");
        break;
    case "*":
        Console.WriteLine($"{firstNumber.ToString().Replace(",", ".")} {symbol} {secondNumber.ToString().Replace(",", ".")} = {calculator.Multiply(firstNumber, secondNumber).ToString().Replace(",", ".")}");
        break;
    case "/":
        Console.WriteLine($"{firstNumber.ToString().Replace(",", ".")} {symbol} {secondNumber.ToString().Replace(",", ".")} = {calculator.Divide(firstNumber, secondNumber).ToString().Replace(",", ".")}");
        break;
    case "**":
        Console.WriteLine($"{firstNumber.ToString().Replace(",", ".")} {symbol} {secondNumber.ToString().Replace(",", ".")} = {calculator.Power(firstNumber, secondNumber).ToString().Replace(",", ".")}");
        break;
    default:
        Console.WriteLine("Invalid symbol");
        break;
}


