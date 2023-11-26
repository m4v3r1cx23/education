var numbers = new List<double>();
var number = 0.0D;

while (number != 5)
{
    number = getNumberFromUser("Enter a number: ", "Please enter a valid number betwen 0 and 10!");

    numbers.Add(number);
}

Console.WriteLine($"The sum of the numbers is {sum(numbers)}.");
Console.WriteLine($"The minimum of the numbers is {findMin(numbers)}.");

double sum(List<double> numbers)
{
    return numbers.Sum();
}

double findMin(List<double> numbers)
{
    return numbers.Min();
}

double getNumberFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    double inputAsDouble;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = double.TryParse(userInput, out inputAsDouble);

        if (!success || inputAsDouble < 0 || inputAsDouble > 10)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success || inputAsDouble < 0 || inputAsDouble > 10);

    return inputAsDouble;
}