namespace Employees
{
  public class HumanResources : Employee
  {
    public string education = string.Empty;
    public string businessRole = string.Empty;

    override
    public void read()
    {
      base.read();
      education = getData("Enter the employee's education: ", "Please enter a valid education!");
      businessRole = getData("Enter the employee's business role: ", "Please enter a valid business role!");
    }

    override
    public void show()
    {
      base.show();
      Console.WriteLine($"Education: {education}");
      Console.WriteLine($"Business role: {businessRole}");
    }

    public void read1()
    {
      education = getData("Enter the employee's education: ", "Please enter a valid education!");
      businessRole = getData("Enter the employee's business role: ", "Please enter a valid business role!");
    }

    public void show1()
    {
      Console.WriteLine("Employee's information:");
      Console.WriteLine($"Education: {education}");
      Console.WriteLine($"Business role: {businessRole}");
    }
  }
}