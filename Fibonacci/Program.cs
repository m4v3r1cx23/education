var fibonacciSequence = new Dictionary<int, long>();

fibonacci(10, fibonacciSequence);

foreach (var item in fibonacciSequence)
{
    Console.WriteLine($"Fibonacci number for {item.Key:00} have value of: {item.Value:000}");
}

long fibonacci(int n, Dictionary<int, long> fibonacciSequence)
{
    if (n < 0)
    {
        Console.WriteLine("The value must be greater than or equal to 0.");
    }

    if (n == 0)
    {
        fibonacciSequence[n] = 0;

        return 0;
    }

    if (n == 1)
    {
        fibonacciSequence[n] = 1;

        return 1;
    }

    var value = fibonacci(n - 1, fibonacciSequence) + fibonacci(n - 2, fibonacciSequence);

    fibonacciSequence[n] = value;

    return value;
}