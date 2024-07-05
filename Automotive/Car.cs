namespace Automotive;

public class Car(string make, string model, int year, int hp) : IVehicle
{
  public string Make { get; private set; } = make;
  public string Model { get; private set; } = model;
  public int Year { get; private set; } = year;
  public int HP { get; private set; } = hp;

  public void Start()
  {
    Console.WriteLine($"Starting the {Make} {Model}'s engine...");
  }

  public void Stop()
  {
    Console.WriteLine($"Stopping the {Make} {Model}'s engine...");
  }

  public void Race()
  {
    Console.WriteLine($"I have {HP}HP in my {Year}'s {Make} {Model}, of course I will win!");
  }
}