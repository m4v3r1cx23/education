var kilograms = getNumberFromUser("Enter your weight in kilograms: ", "Please enter a valid number!");
var meters = getNumberFromUser("Enter your height in meters: ", "Please enter a valid number!");

var bmi = kilograms / Math.Pow(meters, 2);

Console.WriteLine($"Your BMI is {bmi}.");

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