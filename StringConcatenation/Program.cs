var firstName = getStringFromUser("Enter your first name: ", "First name cannot be empty");
var lastName = getStringFromUser("Enter your last name: ", "Last name cannot be empty");

Console.WriteLine($"Your full name is {firstName} {lastName}.");

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