namespace Numbers
{
  public class NumberSorter
  {
    public int numberOfNumbers;
    public List<double> numbers = [];

    public void read_data()
    {
      numberOfNumbers = (int)getNumberFromUser("Enter the number of numbers: ", "Please enter a valid number!");

      numbers = [numberOfNumbers];

      for (var i = 0; i < numberOfNumbers; i++)
      {
        numbers.Add(getNumberFromUser($"Enter number {i + 1}: ", "Please enter a valid number!"));
      }
    }

    public void process_data()
    {
      numbers.Sort();
    }

    public void show_results()
    {
      Console.WriteLine("The numbers in ascending order are:");

      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }
    }

    private double getNumberFromUser(string promptMessage, string errorMessage)
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
  }
}