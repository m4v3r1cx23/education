using System.Diagnostics;

var random = new Random();
var pointsInCircle = 0;

var numberOfPoints = getNumberFromUser("Enter the number of points to generate: ", "Invalid input, please enter a number.");

var watch = Stopwatch.StartNew();

for (var i = 0; i < numberOfPoints; i++)
{
    var x = getRandomNumber(-1, 1);
    var y = getRandomNumber(-1, 1);

    if (isPointInCircle(x, y))
    {
        pointsInCircle++;
    }
}

var pi = 4 * (double)pointsInCircle / numberOfPoints;

watch.Stop();

Console.WriteLine($"Points in circle: {pointsInCircle}");
Console.WriteLine($"The value of pi is {pi:0.00000}.");
Console.WriteLine($"It took {watch.ElapsedMilliseconds} milliseconds to calculate pi.");

double getRandomNumber(double min, double max)
{
    return random.NextDouble() * (max - min) + min;
}

bool isPointInCircle(double x, double y)
{
    return Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
}

long getNumberFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    long inputAsDouble;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = long.TryParse(userInput, out inputAsDouble);

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return inputAsDouble;
}