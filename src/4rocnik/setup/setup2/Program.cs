// See https://aka.ms/new-console-template for more information

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