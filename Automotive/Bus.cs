
namespace Automotive;

public class Bus(string make, string model, int year, string driver) : IVehicle
{
  public string Make { get; private set; } = make;
  public string Model { get; private set; } = model;
  public int Year { get; private set; } = year;
  public string Driver { get; private set; } = driver;

  public void Start()
  {
    Console.WriteLine($"Starting the {Make} {Model}'s engine...");
  }

  public void Stop()
  {
    Console.WriteLine($"Stopping the {Make} {Model}'s engine...");
  }

  public void Tour()
  {
    Console.WriteLine($"Our driver {Driver} takes us on a tour with his {Year}'s {Make} {Model}.");
  }
}