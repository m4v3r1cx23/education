const decimal _PLN_2_USD = 0.24683434946M;
const decimal _USD_2_EUR = 0.91457837936M;
const decimal _USD_2_CHF = 1.06712197204M;
const decimal _USD_2_GBP = 0.79339467301M;

var amount = getNumberFromUser("Enter the amount you want to convert in PLN: ", "Please enter a valid number!");
var currency = getCurrencyFromUser("Enter the currency you want to convert to (EUR, CHF, GBP): ", "Please enter a valid currency!");

var indirectConversionRate = amount * _PLN_2_USD;

try
{
    var result = currency switch
    {
        Currency.EUR => indirectConversionRate * _USD_2_EUR,
        Currency.CHF => indirectConversionRate * _USD_2_CHF,
        Currency.GBP => indirectConversionRate * _USD_2_GBP,
        _ => throw new NotImplementedException()
    };

    Console.WriteLine($"Your converted amount is {result} {currency}.");
}
catch (NotImplementedException)
{
    Console.WriteLine("This currency is not supported.");
}

decimal getNumberFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    decimal inputAsDouble;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = decimal.TryParse(userInput, out inputAsDouble);

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return inputAsDouble;
}

Currency getCurrencyFromUser(string promptMessage, string errorMessage)
{
    string? userInput;
    Currency inputAsCurrency;
    bool success;

    do
    {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        success = Enum.TryParse(userInput, out inputAsCurrency);

        if (!success)
        {
            Console.WriteLine(errorMessage);
        }
    } while (!success);

    return inputAsCurrency;
}

enum Currency
{
    EUR,
    CHF,
    GBP,
}