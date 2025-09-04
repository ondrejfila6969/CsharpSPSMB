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
bool programRunning = true;

Console.WriteLine("Zadejte horní hranici: ");
int maxValue = Int32.Parse(Console.ReadLine());

Console.WriteLine("Zadejte spodní hranici: ");
int minValue = Int32.Parse(Console.ReadLine());

var random = new Random();
int programNumber = random.Next(minValue, maxValue);
Console.WriteLine(programNumber);

int tries = 0;
do
{
    Console.WriteLine("Zadejte váš odhad: ");
    int guess = Int32.Parse(Console.ReadLine());
    
    if (guess != programNumber)
    {
        if (guess > programNumber)
        {
            Console.WriteLine("Číslo, které jste typoval, je větší než číslo programu");
            tries++;
        }
        else if (guess < programNumber)
        {
            Console.WriteLine("Číslo, které jste typoval, je menší než číslo programu");
            tries++;
        }
    } else
    {
        tries++;
        Console.WriteLine($"Gratulujeme, uhádl jste číslo a váš počet pokusů: {tries}");
        programRunning = false;
    }
} while (programRunning);


