var cityName = getStringFromUser("Enter a city name: ", "Please enter a valid city name!");
var stateName = getStringFromUser("Enter a state name: ", "Please enter a valid state name!");

Console.WriteLine($"Your city's name is {cityName} and it contains {cityName.Length} letters.");
Console.WriteLine($"Your state's name is {stateName} and it contains {stateName.Length} letters");

string getStringFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = userInput != null && userInput.Length > 0;

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return userInput ?? string.Empty;
}