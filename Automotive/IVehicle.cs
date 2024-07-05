namespace Automotive;

public interface IVehicle
{
  public string Make { get; }
  public string Model { get; }
  public int Year { get; }

  public void Start();

  public void Stop();
}