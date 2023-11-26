Console.WriteLine("Please provide x, b and c for: ax2 + bx + c = 0");

var a = getNumberFromUser("Enter a: ", "Please enter a valid number!");
var b = getNumberFromUser("Enter b: ", "Please enter a valid number!");
var c = getNumberFromUser("Enter c: ", "Please enter a valid number!");

var delta = calculateDelta(a, b, c);

if (delta < 0)
{
    Console.WriteLine("There are no real roots.");
}
else if (delta == 0)
{
    var root = calculateRoot0(a, b, c);

    Console.WriteLine($"There is one real root: {root:0.00}.");
}
else
{
    var root1 = calculateRoot1(a, b, c, delta);
    var root2 = calculateRoot2(a, b, c, delta);

    Console.WriteLine($"There are two real roots: {root1:0.00} and {root2:0.00}.");
}

double calculateRoot0(double a, double b, double c)
{
    return -b / (2 * a);
}

double calculateRoot1(double a, double b, double c, double delta)
{
    return (-b + Math.Sqrt(delta)) / (2 * a);
}

double calculateRoot2(double a, double b, double c, double delta)
{
    return (-b - Math.Sqrt(delta)) / (2 * a);
}

double calculateDelta(double a, double b, double c)
{
    return Math.Pow(b, 2) - 4 * a * c;
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

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return inputAsDouble;
}