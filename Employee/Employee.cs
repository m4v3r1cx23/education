namespace Employees
{
  public class Employee
  {
    public string name = string.Empty;
    public string lastName = string.Empty;
    public string street = string.Empty;
    public string city = string.Empty;

    public virtual void read()
    {
      name = getData("Enter the employee's name: ", "Please enter a valid name!");
      lastName = getData("Enter the employee's last name: ", "Please enter a valid last name!");
      street = getData("Enter the employee's street: ", "Please enter a valid street!");
      city = getData("Enter the employee's city: ", "Please enter a valid city!");
    }

    public virtual void show()
    {
      Console.WriteLine("Employee's information:");
      Console.WriteLine($"Name: {name}");
      Console.WriteLine($"Last name: {lastName}");
      Console.WriteLine($"Street: {street}");
      Console.WriteLine($"City: {city}");
    }

    protected string getData(string promptMessage, string errorMessage)
    {
      string? userInput;

      do
      {
        Console.Write(promptMessage);

        userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput))
        {
          Console.WriteLine(errorMessage);
        }
      } while (string.IsNullOrEmpty(userInput));

      return userInput;
    }
  }
}