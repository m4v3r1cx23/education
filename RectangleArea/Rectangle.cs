namespace RectangleArea
{
  public class Rectangle
  {
    public double length;
    public double width;
    public double surface_area;

    public void read_data()
    {
      length = getNumberFromUser("Enter the length of the rectangle: ", "Please enter a valid number!");
      width = getNumberFromUser("Enter the width of the rectangle: ", "Please enter a valid number!");
    }

    public void process_data()
    {
      surface_area = length * width;
    }

    public void show_results()
    {
      Console.WriteLine($"The surface area of the rectangle with lenght of {length:0.00} and width of {width:0.00} is {surface_area:0.00}.");
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