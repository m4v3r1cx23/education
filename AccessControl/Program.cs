const string _ACCESS_GRANTED = "Access Granted!";
const string _ACCESS_DENIED = "Access Denied!";

var age = getNumberFromUser("Enter your age: ", "Please enter a valid number!");

if (age > 18)
{
    Console.WriteLine(_ACCESS_GRANTED);
}
else if (age >= 15 && age <= 18)
{
    var consent = getParentalConsentFromUser("Do you have parental consent? (YES, NO): ", "Please enter a valid answer!");

    if (consent == ParentalConsent.YES)
    {
        Console.WriteLine(_ACCESS_GRANTED);
    }
    else
    {
        Console.WriteLine(_ACCESS_DENIED);
    }
}
else
{
    Console.WriteLine(_ACCESS_DENIED);
}

int getNumberFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    int inputAsDouble;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = int.TryParse(userInput, out inputAsDouble);

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return inputAsDouble;
}

ParentalConsent getParentalConsentFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    ParentalConsent inputParentalConsent;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = Enum.TryParse(userInput?.ToUpper(), out inputParentalConsent);

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return inputParentalConsent;
}

enum ParentalConsent
{
    YES,
    NO,
}